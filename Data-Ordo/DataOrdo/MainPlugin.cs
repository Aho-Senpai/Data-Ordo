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
		string settingsFile = Path.Combine(ActGlobals.oFormActMain.AppDataFolder.FullName, "Config\\Data-Ordo.config.xml"); // Path for the setting file i think
		UserInterfaceMain UIMain;	// Init UserInterface to display UI later

        public void InitPlugin(TabPage pluginScreenSpace, Label pluginStatusText)
        {
			
			lblStatus = pluginStatusText;			    // Hand the status label's reference to our local var
			pluginScreenSpace.Controls.Add(this);		// Add this UserControl to the tab ACT provides
			xmlSettings = new SettingsSerializer(this);	// Create a new settings serializer and pass it this instance
			this.Dock = DockStyle.Fill;					// Expand the UserControl to fill the tab's client space
			ActGlobals.oFormActMain.AfterCombatAction += new CombatActionDelegate(oFormActMain_AfterCombatAction); // Create some sort of parsing event handler.  After the "+=" hit TAB twice and the code will be generated for you.
			UIMain = new UserInterfaceMain();		// Declare UIMain 
			this.Controls.Add(UIMain);				// Use UI main and display it
			
            LoadSettings();

            lblStatus.Text = "Crash Avoided!";
        }

        public void DeInitPlugin()
        {
            ActGlobals.oFormActMain.AfterCombatAction -= oFormActMain_AfterCombatAction; // Unsubscribe from any events you listen to when exiting!


            SaveSettings();

			lblStatus.Text = "Ready To Crash";
        }

        void oFormActMain_AfterCombatAction(bool isImport, CombatActionEventArgs actionInfo)
		{
			throw new NotImplementedException();
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
    }
}