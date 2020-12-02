using Advanced_Combat_Tracker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using System.Diagnostics;
//using FFXIV_ACT_Plugin;

namespace DataOrdo
{
	public class MainPlugin : UserControl, IActPluginV1
	{
		Label lblStatus;    // Create a lblStatus to print a message on the plugin status in the plugin list in ACT
		UserInterfaceMain UIMain;   // Init UserInterface to display UI later
		public System.Windows.Forms.Timer LogsTimer = new System.Windows.Forms.Timer();

		#region Init & DeInit PLugin
		public void InitPlugin(TabPage pluginScreenSpace, Label pluginStatusText)
		{
			lblStatus = pluginStatusText;               // Hand the status label's reference to our local var
			pluginScreenSpace.Controls.Add(this);       // Add this UserControl to the tab ACT provides
			xmlSettings = new SettingsSerializer(this); // Create a new settings serializer and pass it this instance
			this.Dock = DockStyle.Fill;                 // Expand the UserControl to fill the tab's client space
			ActGlobals.oFormActMain.OnLogLineRead += OFormActMain_OnLogLineRead;
			ActGlobals.oFormActMain.OnCombatStart += OFormActMain_OnCombatStart;
			ActGlobals.oFormActMain.OnCombatEnd += OFormActMain_OnCombatEnd;
			ActGlobals.oFormActMain.BeforeLogLineRead += OFormActMain_BeforeLogLineRead;

			UIMain = new UserInterfaceMain();       // Declare UIMain 
			this.Controls.Add(UIMain);              // Use UI main and display it

			#region Set Button "CombatToggle" on Init
			// This Region sets the state of the "CombatToggle" button on PluginInit
			if (ActGlobals.oFormActMain.InCombat)
			{
				UIMain.CombatToggle.BackColor = UIMain.DisableColorPicker.BackColor;
				UIMain.CombatToggle.Text = "In Combat";
				UIMain.IsInCombat = true;
			}
			else if (!ActGlobals.oFormActMain.InCombat)
			{
				UIMain.CombatToggle.BackColor = UIMain.EnableColorPicker.BackColor;
				UIMain.CombatToggle.Text = "Out Of Combat";
				UIMain.IsInCombat = false;
			}
			#endregion

			UIMain.SetPluginVar(this);

			LoadSettings();

			lblStatus.Text = "Crash Avoided!";

			LogsTimer.Tick += LogsTimer_Tick;
			LogsTimer.Interval = 2000;
			LogsTimer.Start();

			UIMain.TrackbarValue.Text = "" + UIMain.LogsTimerTrackBarSet.Value;
		}

		private void LogsTimer_Tick(object sender, EventArgs e)
		{
			if (UIMain.ParseON)
			{
				if (!UIMain.IsInCombat)
				{
					if (UIMain.CB_OOCLog)
					{
						UIMain.OOC_Logs_ListView.BeginUpdate();
						UIMain.OOC_Logs_ListView.VirtualListSize = ACTFFLogsOOC.Count;
						UIMain.OOC_Logs_ListView.EndUpdate();
						if (UIMain.OOC_Logs_ListView.Items.Count - 1 > 0 & UIMain.AutoLogScroll)
							UIMain.OOC_Logs_ListView.Items[UIMain.OOC_Logs_ListView.Items.Count - 1].EnsureVisible();
					}
				}
				else
				{
					UIMain.Enc_Logs_ListView.BeginUpdate();
					UIMain.Enc_Logs_ListView.VirtualListSize = ACTFFLogsEnc.Count;
					UIMain.Enc_Logs_ListView.EndUpdate();
					if (UIMain.Enc_Logs_ListView.Items.Count - 1 > 0 & UIMain.AutoLogScroll)
						UIMain.Enc_Logs_ListView.Items[UIMain.Enc_Logs_ListView.Items.Count - 1].EnsureVisible();
				}
			}
		}

        public void DeInitPlugin()
		{
			ActGlobals.oFormActMain.OnLogLineRead -= OFormActMain_OnLogLineRead;
			ActGlobals.oFormActMain.OnCombatStart -= OFormActMain_OnCombatStart;
			ActGlobals.oFormActMain.OnCombatEnd -= OFormActMain_OnCombatEnd;

			SaveSettings();

			lblStatus.Text = "Ready To Crash";
		}

		#endregion

		#region Parsing
		public List<FFLogLine> ACTFFLogsOOC = new List<FFLogLine>();
		public List<FFLogLine> ACTFFLogsEnc = new List<FFLogLine>();

		private void OFormActMain_OnLogLineRead(bool isImport, LogLineEventArgs logInfo)
		{
			if (UIMain.ParseON)
			{
				if (!logInfo.inCombat)
					ACTFFLogsOOC.Add(new FFLogLine(logInfo.logLine));
				else
					ACTFFLogsEnc.Add(new FFLogLine(logInfo.logLine));
			}
		}

		public List<FFLogLine> RAWFFLogsOOC = new List<FFLogLine>();
		public List<FFLogLine> RAWFFLogsEnc = new List<FFLogLine>();
		#endregion

		#region OnCombat Start/End Events & TreeView Building
		private void OFormActMain_OnCombatEnd(bool isImport, CombatToggleEventArgs encounterInfo)
		{
			UIMain.CombatToggle.BackColor = UIMain.EnableColorPicker.BackColor;
			UIMain.CombatToggle.Text = "Out Of Combat";
			UIMain.IsInCombat = false;

			// grab the out of combat tab IF CB_OOCLog == True - maybe
			if (UIMain.ParseON)
				UIMain.PluginTabControl.SelectTab(0);

			EncounterTreeMaker(false, encounterInfo);
		}
		private void OFormActMain_OnCombatStart(bool isImport, CombatToggleEventArgs encounterInfo)
		{
			UIMain.CombatToggle.BackColor = UIMain.DisableColorPicker.BackColor;
			UIMain.CombatToggle.Text = "In Combat";
			UIMain.IsInCombat = true;

			if (UIMain.ParseON)
				UIMain.PluginTabControl.SelectTab(1);

			EncounterTreeMaker(true, encounterInfo);
		}

		private void EncounterTreeMaker(bool IsInCombat, CombatToggleEventArgs encounterInfo)
		{
			var NetworkLogsNode = UIMain.EncounterListTreeView.Nodes[0];

			//Control.CheckForIllegalCrossThreadCalls = true;
			if (UIMain.CB_NetworkLogSetting && UIMain.ParseON)
			{
				if (IsInCombat) // This is _OnCombatStart
				{
					if (NetworkLogsNode.Nodes.Count > 0)
					{
						if (NetworkLogsNode.Nodes[NetworkLogsNode.Nodes.Count - 1].Text != ActGlobals.oFormActMain.CurrentZone)
						{
							TreeNode newNetworkNode = new TreeNode(ActGlobals.oFormActMain.CurrentZone);
							this.Invoke(new Action(() => NetworkLogsNode.Nodes.Add(newNetworkNode)));
						}
					}
					else
					{
						TreeNode newNetworkNode = new TreeNode(ActGlobals.oFormActMain.CurrentZone);
						this.Invoke(new Action(() => NetworkLogsNode.Nodes.Add(newNetworkNode)));
					}
					this.Invoke(new Action(() => NetworkLogsNode.Nodes[NetworkLogsNode.Nodes.Count - 1].Nodes.Add("Encounter").ForeColor = Color.Green));
				}
				else // This is _OnCombatEnd
				{
					if (NetworkLogsNode.Nodes.Count > 0)
					{
						if (NetworkLogsNode.Nodes[NetworkLogsNode.Nodes.Count - 1].Text != ActGlobals.oFormActMain.CurrentZone)
						{
							TreeNode newNetworkNode = new TreeNode(ActGlobals.oFormActMain.CurrentZone);
							this.Invoke(new Action(() => NetworkLogsNode.Nodes.Add(newNetworkNode)));
						}
					}
					else
					{
						TreeNode newNetworkNode = new TreeNode(ActGlobals.oFormActMain.CurrentZone);
						this.Invoke(new Action(() => NetworkLogsNode.Nodes.Add(newNetworkNode)));
					}
					this.Invoke(new Action(() => {
						NetworkLogsNode.Nodes[NetworkLogsNode.Nodes.Count - 1].Nodes[NetworkLogsNode.Nodes[NetworkLogsNode.Nodes.Count - 1].Nodes.Count - 1].Text = encounterInfo.encounter.Title;
						NetworkLogsNode.Nodes[NetworkLogsNode.Nodes.Count - 1].Nodes.Add("Out Of Combat").ForeColor = Color.Purple;
					}));
				}
				this.Invoke(new Action(() => {
					NetworkLogsNode.Expand();
					NetworkLogsNode.Nodes[NetworkLogsNode.Nodes.Count - 1].Expand();
					if (NetworkLogsNode.Nodes.Count >= 2)
						NetworkLogsNode.Nodes[NetworkLogsNode.Nodes.Count - 2].Collapse();
				}));
			}
			else { this.Invoke(new Action(() => NetworkLogsNode.Collapse())); }


			// Temporary; will need to do later
			if (UIMain.CB_RawLogSetting)
			{
				TreeNode newRawNode = new TreeNode(ActGlobals.oFormActMain.CurrentZone);
				UIMain.EncounterListTreeView.Nodes[1].Nodes.Add(newRawNode);
			}
		}
		private void OFormActMain_BeforeLogLineRead(bool isImport, LogLineEventArgs logInfo)
		{
			var NetworkLogsNode = UIMain.EncounterListTreeView.Nodes[0];

			if (UIMain.CB_NetworkLogSetting && UIMain.ParseON)
			{
				if (NetworkLogsNode.Nodes.Count > 0
					&& NetworkLogsNode.Nodes[NetworkLogsNode.Nodes.Count - 1].Text != ActGlobals.oFormActMain.CurrentZone)
				{
					TreeNode newNetworkNode = new TreeNode(ActGlobals.oFormActMain.CurrentZone);
					
					// This trow exeption about invoke not being able to be called until window handle is created
					this.Invoke(new Action(() => {
						NetworkLogsNode.Nodes.Add(newNetworkNode);
						NetworkLogsNode.Nodes[NetworkLogsNode.Nodes.Count - 1].Nodes.Add("Out Of Combat").ForeColor = Color.Purple;
						NetworkLogsNode.Nodes[NetworkLogsNode.Nodes.Count - 1].Expand();
						if (NetworkLogsNode.Nodes.Count >= 2)
							NetworkLogsNode.Nodes[NetworkLogsNode.Nodes.Count - 2].Collapse();
					}));
				}
				else if (NetworkLogsNode.Nodes.Count == 0)
				{
					TreeNode newNetworkNode = new TreeNode(ActGlobals.oFormActMain.CurrentZone);
					this.Invoke(new Action(() => {
						NetworkLogsNode.Nodes.Add(newNetworkNode);
						NetworkLogsNode.Nodes[NetworkLogsNode.Nodes.Count - 1].Nodes.Add("Out Of Combat").ForeColor = Color.Purple;
						NetworkLogsNode.Expand();
						NetworkLogsNode.Nodes[NetworkLogsNode.Nodes.Count - 1].Expand();
					}));
				}
			}
		}
		#endregion

		#region Load & Save Settings
		SettingsSerializer xmlSettings; // For the settings file ? i think
		readonly string settingsFile = Path.Combine(ActGlobals.oFormActMain.AppDataFolder.FullName, "Config\\DataOrdo.config.xml"); // Path for the settings file
		private void LoadSettings()
		{
			xmlSettings.AddControlSetting(UIMain.DevModeCB.Name, UIMain.DevModeCB);
			xmlSettings.AddControlSetting(UIMain.ClearLogEnableCB.Name, UIMain.ClearLogEnableCB);
			xmlSettings.AddControlSetting(UIMain.EnableColorPicker.Name, UIMain.EnableColorPicker);
			xmlSettings.AddControlSetting(UIMain.DisableColorPicker.Name, UIMain.DisableColorPicker);
			xmlSettings.AddControlSetting(UIMain.EnabledRegexColorPicker.Name, UIMain.EnabledRegexColorPicker);
			xmlSettings.AddControlSetting(UIMain.DisabledRegexColorPicker.Name, UIMain.DisabledRegexColorPicker);
			xmlSettings.AddControlSetting(UIMain.LogsTimerTrackBarSet.Value.ToString(), UIMain.LogsTimerTrackBarSet);

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
								xmlSettings.ImportFromXml(xReader);
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
			// This will reload the plugin and then grab the last opened tab (which is said plugin that we just restarted)
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
			// maybe break the different loglines depending on LineID
			// and have {target} {caster} and so on
			LogText = Logline.Substring(18);

			FFFullLogLine = ToStringWithTimeline();
			FFNoTSLogLine = ToStringNoTimeline();
		}
		public string Timestamp { get; set; }
		public string LineId { get; set; }
		public string LogText { get; set; }
		public string FFFullLogLine { get; }
		public string FFNoTSLogLine { get; }
		public string ToStringWithTimeline() { return $"{Timestamp} {LineId}:{LogText}"; }
		public string ToStringNoTimeline() { return $"{LineId}:{LogText}"; }
	}
}