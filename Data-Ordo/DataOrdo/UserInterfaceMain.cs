using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataOrdo
{
    public partial class UserInterfaceMain : UserControl
    {
        public MainPlugin PlugInstance;
        public bool CB_OOCLog;
        public bool CB_Timestamp;

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

        private void toolStripButton1_Click(object sender, EventArgs e)
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
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
            richTextBox1.Clear();
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
