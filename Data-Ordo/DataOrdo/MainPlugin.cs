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
    public class MainPlugin : IActPluginV1
    {
        Label lblStatus;

        public void InitPlugin(TabPage pluginScreenSpace, Label pluginStatusText)
        {
            lblStatus = pluginStatusText;   // Hand the status label's reference to our local var
			pluginScreenSpace.Controls.Add(this);   // Add this UserControl to the tab ACT provides
			this.Dock = DockStyle.Fill; // Expand the UserControl to fill the tab's client space
			xmlSettings = new SettingsSerializer(this); // Create a new settings serializer and pass it this instance
			ActGlobals.oFormActMain.AfterCombatAction += new CombatActionDelegate(oFormActMain_AfterCombatAction); // Create some sort of parsing event handler.  After the "+=" hit TAB twice and the code will be generated for you.
			lblStatus.Text = "Plugin Started";



            LoadSettings();
        }

        public void DeInitPlugin()
        {
            SaveSettings();
        }

        private void LoadSettings()
        {

        }

        private void SaveSettings()
        {

        }
    }
}