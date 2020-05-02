using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DataOrdo
{
    public partial class UserInterfaceMain : UserControl
    {
        public MainPlugin PlugInstance;
        public bool CB_OOCLog;
        public bool CB_Timestamp;
        public bool CB_OOCLogScroll;
        public int i;

        public UserInterfaceMain()
        {
            this.Dock = DockStyle.Fill;
            InitializeComponent();
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
                CB_OOCLog = false;
            }

            else if (OutOfCombarParsing.BackColor == Color.Red)
            {
                OutOfCombarParsing.Text = "Parsing ON";
                OutOfCombarParsing.BackColor = Color.Green;
                CB_OOCLog = true;
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (OOC_Timestamp.BackColor == Color.Green)
            {
                OOC_Timestamp.BackColor = Color.Red; // Disable Option
                OOC_Timestamp.Text = "Timestamp OFF";
                CB_Timestamp = false;
            }

            else if (OOC_Timestamp.BackColor == Color.Red)
            {
                OOC_Timestamp.BackColor = Color.Green; // Enable Option
                OOC_Timestamp.Text = "Timestamp ON";
                CB_Timestamp = true;

            }
        }

        private void ClearOOCLogButton_Click(object sender, EventArgs e)
        {
            listBox1.Text = ""; 
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

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Scroll at the bottom when new lines gets added
            if (CB_OOCLogScroll == true)
            {
                //listBox1.SelectedIndex = listBox1.Items.Count - 1;
                //listBox1.SelectedIndex = -1;
            }
        }

        private void AutoScrollOOCLog_CheckedChanged(object sender, EventArgs e)
        {
            if (autoScrollOOCLog.BackColor == Color.Green)
            {
                autoScrollOOCLog.BackColor = Color.Red; // Disable Option
                autoScrollOOCLog.Text = "Autoscroll OFF";
                CB_OOCLogScroll = false;
            }

            else if (autoScrollOOCLog.BackColor == Color.Red)
            {
                autoScrollOOCLog.BackColor = Color.Green; // Enable Option
                autoScrollOOCLog.Text = "Autoscroll ON";
                CB_OOCLogScroll = true;
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
                listBox1.SelectedIndex = -1;
            }
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

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            
        }
    }
}
