using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Advanced_Combat_Tracker;

namespace DataOrdo
{
    public partial class UserInterfaceMain : UserControl
    {
        public MainPlugin PlugInstance;
        public bool CB_OOCParse;
        public bool CB_Timestamp = true;
        public bool CB_OOCLogScroll;
        public bool CB_OOCLog = true;
        public BindingList<FFLogLine> MyFFData = new BindingList<FFLogLine>();
        public bool IsInCombat;
        

        public UserInterfaceMain()
        {
            this.Dock = DockStyle.Fill;
            InitializeComponent();

            listBox1.DataSource = MyFFData;
            listBox1.DisplayMember = "FullDisplay";
        }

        #region ToolStrip Controls
        public void SetPluginVar(MainPlugin PluginInstance)
        {
            this.PlugInstance = PluginInstance; 
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            PlugInstance.ReloadPlugin();
        }
        #endregion

        #region Out Of Combat Logs Tab Controlls
        private void OutOfCombarParsing_CheckedChanged(object sender, EventArgs e)
        {
            if (OutOfCombarParsing.BackColor == Color.Green)
            {
                OutOfCombarParsing.Text = "Parsing OFF";
                OutOfCombarParsing.BackColor = Color.Red;
                CB_OOCParse = false;
            }

            else if (OutOfCombarParsing.BackColor == Color.Red)
            {
                OutOfCombarParsing.Text = "Parsing ON";
                OutOfCombarParsing.BackColor = Color.Green;
                CB_OOCParse = true;
            }
        }

        private void OOC_Timestamp_CheckedChanged(object sender, EventArgs e)
        {
            if (OOC_Timestamp.BackColor == Color.Green)
            {
                OOC_Timestamp.BackColor = Color.Red; // Disable Option
                OOC_Timestamp.Text = "Timestamp OFF";
                CB_Timestamp = false;
                listBox1.DisplayMember = "FFNoTSLogLine";
            }
            else if (OOC_Timestamp.BackColor == Color.Red)
            {
                OOC_Timestamp.BackColor = Color.Green; // Enable Option
                OOC_Timestamp.Text = "Timestamp ON";
                CB_Timestamp = true;
                listBox1.DisplayMember = "FFFullLogLine";
            }
        }

        private void ClearOOCLogButton_Click(object sender, EventArgs e)
        {
            // this line will throw an error because listbox is tied to a DataSource
            // listBox1.Items.Clear();
        }

        private void RegexOOCSearchBar_CheckedChanged(object sender, EventArgs e)
        {
            if (RegexOOCSearchBar.BackColor == Color.Gray)
            {
                RegexOOCSearchBar.Text = "Regex ON";
                RegexOOCSearchBar.BackColor = Color.Blue;
            }
            else if (RegexOOCSearchBar.BackColor == Color.Blue)
            {
                RegexOOCSearchBar.Text = "Regex OFF";
                RegexOOCSearchBar.BackColor = Color.Gray;
            }
        }

        private void OOCLog_CheckedChanged(object sender, EventArgs e)
        {
            if (OOCLog.BackColor == Color.Green)
            {
                OOCLog.Text = "Log OFF";
                OOCLog.BackColor = Color.Red;
                CB_OOCLog = false;
            }

            else if (OOCLog.BackColor == Color.Red)
            {
                OOCLog.Text = "Log ON";
                OOCLog.BackColor = Color.Green;
                CB_OOCLog = true;
            }
        }
        
        private void CombatToggle_Click(object sender, EventArgs e)
        {
            if (IsInCombat)
                ActGlobals.oFormActMain.EndCombat(export: true);
        }
        #endregion

        #region Encounter Logs Tab Controls
        private void EncountersParsing_CheckedChanged(object sender, EventArgs e)
        {
            if (EncountersParsing.BackColor == Color.Green)
            {
                EncountersParsing.Text = "Parsing OFF";
                EncountersParsing.BackColor = Color.Red;
            }
            else if (EncountersParsing.BackColor == Color.Red)
            {
                EncountersParsing.Text = "Parsing ON";
                EncountersParsing.BackColor = Color.Green;
            }
        }
        #endregion

    }
}
