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
        Label lblStatus;	// Create a lblStatus to print a message on the plugin status in the plugin list in ACT
        SettingsSerializer xmlSettings;	// For the settings file ? i think
		string settingsFile = Path.Combine(ActGlobals.oFormActMain.AppDataFolder.FullName, "Config\\Data-Ordo.config.xml"); // Path for the setting (file i think)
		UserInterfaceMain UIMain;	// Init UserInterface to display UI later

        public void InitPlugin(TabPage pluginScreenSpace, Label pluginStatusText)
        {
			
			lblStatus = pluginStatusText;			    // Hand the status label's reference to our local var
			pluginScreenSpace.Controls.Add(this);		// Add this UserControl to the tab ACT provides
			xmlSettings = new SettingsSerializer(this);	// Create a new settings serializer and pass it this instance
			this.Dock = DockStyle.Fill;                 // Expand the UserControl to fill the tab's client space
			ActGlobals.oFormActMain.OnLogLineRead += OFormActMain_OnLogLineRead;
			UIMain = new UserInterfaceMain();		// Declare UIMain 
			this.Controls.Add(UIMain);              // Use UI main and display it
			UIMain.SetPluginVar(this);

			LoadSettings();

            lblStatus.Text = "Crash Avoided!";
        }

		public void DeInitPlugin()
        {
			ActGlobals.oFormActMain.OnLogLineRead -= OFormActMain_OnLogLineRead;

			SaveSettings();

			lblStatus.Text = "Ready To Crash";
        }


		private void SetText(string text, RichTextBox textBox)
		{
			textBox.Text = text;
		}

		private void OFormActMain_OnLogLineRead(bool isImport, LogLineEventArgs logInfo)
		{
			if (UIMain.CB_OOCLog == true && ActGlobals.oFormActMain.InCombat == false)
			{
				string msg = $"{UIMain.richTextBox1.Text}{logInfo.logLine}{Environment.NewLine}";
				this.Invoke(new Action<string, RichTextBox>(SetText), msg, UIMain.richTextBox1);
			}
		}

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

		public void ReloadPlugin()
		{
			ActPluginData pluginData = ActGlobals.oFormActMain.PluginGetSelfData(this);
			pluginData.cbEnabled.Checked = false; // Deinit the old plugin
			Application.DoEvents();
			pluginData.cbEnabled.Checked = true;  // Init the new version
			TabControl tc = (TabControl)pluginData.tpPluginSpace.Parent;
			tc.SelectTab(tc.TabPages.Count - 1);    // Switch to last opened tab after reload
		}
	}
}