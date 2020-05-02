using Advanced_Combat_Tracker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;

namespace DataOrdo
{
	public class MainPlugin : UserControl, IActPluginV1
	{
		Label lblStatus;    // Create a lblStatus to print a message on the plugin status in the plugin list in ACT
		UserInterfaceMain UIMain;   // Init UserInterface to display UI later

		#region Init & DeInit PLugin
		public void InitPlugin(TabPage pluginScreenSpace, Label pluginStatusText)
		{

			lblStatus = pluginStatusText;               // Hand the status label's reference to our local var
			pluginScreenSpace.Controls.Add(this);       // Add this UserControl to the tab ACT provides
			xmlSettings = new SettingsSerializer(this); // Create a new settings serializer and pass it this instance
			this.Dock = DockStyle.Fill;                 // Expand the UserControl to fill the tab's client space
			ActGlobals.oFormActMain.OnLogLineRead += OFormActMain_OnLogLineRead;
			UIMain = new UserInterfaceMain();       // Declare UIMain 
			this.Controls.Add(UIMain);              // Use UI main and display it

			UIMain.SetPluginVar(this);
			UIMain.CB_Timestamp = true;

			LoadSettings();

			lblStatus.Text = "Crash Avoided!";
		}

		public void DeInitPlugin()
		{
			ActGlobals.oFormActMain.OnLogLineRead -= OFormActMain_OnLogLineRead;

			SaveSettings();
			File.WriteAllText(OOCLogFile, "");  // Clears the file

			lblStatus.Text = "Ready To Crash";
		}
		#endregion

		#region OOCLogs Tab Parsing
		public string OOCLogFile = Path.Combine(ActGlobals.oFormActMain.AppDataFolder.FullName, "Config\\OOC_LogFileTemp.txt"); // Path for my temp log file for OOC Logs

		private void OFormActMain_OnLogLineRead(bool isImport, LogLineEventArgs logInfo)
		{
			if (!ActGlobals.oFormActMain.InCombat && UIMain.CB_OOCParse)
			{
				var line = new FFLogLine(logInfo.logLine);
				string Log = line.ToString();
				File.AppendAllText(OOCLogFile, Log);

				if (UIMain.CB_OOCLog)
				{
					if (UIMain.CB_Timestamp)
					{
						UIMain.listBox1.Items.Add(line.ToString());
					}
					else if (!UIMain.CB_Timestamp)
					{
						UIMain.listBox1.Items.Add(line.ToStringNoTimestamp());
					}
				}
			}
		}
		#endregion

		#region Load & Save Settings
		SettingsSerializer xmlSettings; // For the settings file ? i think
		readonly string settingsFile = Path.Combine(ActGlobals.oFormActMain.AppDataFolder.FullName, "Config\\DataOrdo.config.xml"); // Path for the settings file
		private void LoadSettings()
		{
			if (File.Exists(settingsFile))
			{
				FileStream fs = new FileStream(settingsFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
				XmlTextReader xReader = new XmlTextReader(fs);

				try
				{
					while (xReader.Read())
					{
						if (xReader.NodeType == XmlNodeType.Element)
						{
							if (xReader.LocalName == "SettingsSerializer")
							{
								xmlSettings.ImportFromXml(xReader);
							}
						}
					}
				}
				catch (Exception ex)
				{
					lblStatus.Text = "Error loading settings: " + ex.Message;
				}
				xReader.Close();
			}
		}

		private void SaveSettings()
		{
			FileStream fs = new FileStream(settingsFile, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
			XmlTextWriter xWriter = new XmlTextWriter(fs, Encoding.UTF8)
			{
				Formatting = Formatting.Indented,
				Indentation = 1,
				IndentChar = '\t'
			};
			xWriter.WriteStartDocument(true);
			xWriter.WriteStartElement("Config");                // <Config>
			xWriter.WriteStartElement("SettingsSerializer");    // <Config><SettingsSerializer>
			xmlSettings.ExportToXml(xWriter);                   // Fill the SettingsSerializer XML
			xWriter.WriteEndElement();                          // </SettingsSerializer>
			xWriter.WriteEndElement();                          // </Config>
			xWriter.WriteEndDocument();                         // Tie up loose ends (shouldn't be any)
			xWriter.Flush();                                    // Flush the file buffer to disk
			xWriter.Close();
		}
		#endregion

		public void ReloadPlugin()
		{
			// This will reload the plugin and then grab the last opened tab (which is said plugin that we just restarted
			ActPluginData pluginData = ActGlobals.oFormActMain.PluginGetSelfData(this);
			pluginData.cbEnabled.Checked = false; // Deinit the old plugin
			Application.DoEvents();
			pluginData.cbEnabled.Checked = true;  // Init the new version
			TabControl tc = (TabControl)pluginData.tpPluginSpace.Parent;
			tc.SelectTab(tc.TabPages.Count - 1);
		}
	}

	public class FFLogLine
	{
		public FFLogLine(string Logline)
		{
			Timestamp = Logline.Substring(0, 14);
			LineId = Logline.Substring(15, 2);
			LogText = Logline.Substring(18);
		}
		public string Timestamp { get; set; }
		public string LineId { get; set; }
		public string LogText { get; set; }
		public override string ToString() { return $"{Timestamp} {LineId}:{LogText}{Environment.NewLine}"; }
		public string ToStringNoTimestamp() { return $"{LineId}:{LogText}{Environment.NewLine}"; }
	}
}