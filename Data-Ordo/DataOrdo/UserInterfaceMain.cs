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

        public bool CB_OOCLog = true;
        
        public bool CB_OOCTimestamp = true;
        public bool CB_EncTimestamp;

        public bool IsInCombat;

        public BindingList<FFLogLine> MyFFDataOOC = new BindingList<FFLogLine>();
        public BindingList<FFLogLine> MyFFDataEnc = new BindingList<FFLogLine>();

        public UserInterfaceMain()
        {
            this.Dock = DockStyle.Fill;
            InitializeComponent();

            toolStrip1.Renderer = new MyRenderer();

            OOC_Logs_ListBox.DataSource = MyFFDataOOC;
            OOC_Logs_ListBox.DisplayMember = "FullDisplay";

            Enc_Logs_ListBox.DataSource = MyFFDataEnc;
            Enc_Logs_ListBox.DisplayMember = "FullDisplay";
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
        private void Parse_Click(object sender, EventArgs e)
        {
            if (Parse.BackColor == Color.Red)
            {
                Parse.Text = "Parse ON";
                Parse.BackColor = Color.Green;
            }
            else if (Parse.BackColor == Color.Green)
            {
                Parse.Text = "Parse OFF";
                Parse.BackColor = Color.Red;
            }
        }
        #endregion

        #region Out Of Combat Logs Tab Controlls
        private void RegexOOCSearchBar_CheckedChanged(object sender, EventArgs e) //WIP
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
        private void OOC_Timestamp_CheckedChanged(object sender, EventArgs e)
        {
            if (OOC_Timestamp.BackColor == Color.Green)
            {
                OOC_Timestamp.BackColor = Color.Red; // Disable Option
                OOC_Timestamp.Text = "Timestamp OFF";
                CB_OOCTimestamp = false;
                OOC_Logs_ListBox.DisplayMember = "FFNoTSLogLine";
            }
            else if (OOC_Timestamp.BackColor == Color.Red)
            {
                OOC_Timestamp.BackColor = Color.Green; // Enable Option
                OOC_Timestamp.Text = "Timestamp ON";
                CB_OOCTimestamp = true;
                OOC_Logs_ListBox.DisplayMember = "FFFullLogLine";
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
        private void ClearOOCLogButton_Click(object sender, EventArgs e) //WIP - Broken ATM
        {
            // this line will throw an error because listbox is tied to a DataSource
            // listBox1.Items.Clear();
        }
      
        private void OOC_SearchTextBox_TextChanged(object sender, EventArgs e) // WIP
        {
            //listBox1.DataSource = MyFFDataOOC.Where(item => item.ToString().Contains(OOC_SearchTextBox.Text));
        }

        private void OOC_Logs_ListBox_KeyDown(object sender, KeyEventArgs e)
        {
            // This allows the user to use CTRL+C to copy the selected line.
            if (e.Control == true && e.KeyCode == Keys.C)
            {
                string s = OOC_Logs_ListBox.SelectedItem.ToString();
                Clipboard.SetData(DataFormats.StringFormat, s);
            }
        }
        #endregion

        #region Encounter Logs Tab Controls
        private void RegexEncSearchBar_CheckedChanged(object sender, EventArgs e)
        {
            if (RegexEncSearchBar.BackColor == Color.Gray)
            {
                RegexEncSearchBar.Text = "Regex ON";
                RegexEncSearchBar.BackColor = Color.Blue;
            }
            else if (RegexEncSearchBar.BackColor == Color.Blue)
            {
                RegexEncSearchBar.Text = "Regex OFF";
                RegexEncSearchBar.BackColor = Color.Gray;
            }
        }
        private void EncTimestamp_CheckedChanged(object sender, EventArgs e)
        {
            if (Enc_Timestamp.BackColor == Color.Green)
            {
                Enc_Timestamp.BackColor = Color.Red; // Disable Option
                Enc_Timestamp.Text = "Timestamp OFF";
                CB_EncTimestamp = false;
                Enc_Logs_ListBox.DisplayMember = "FFNoTSLogLine";
            }
            else if (Enc_Timestamp.BackColor == Color.Red)
            {
                Enc_Timestamp.BackColor = Color.Green; // Enable Option
                Enc_Timestamp.Text = "Timestamp ON";
                CB_EncTimestamp = true;
                Enc_Logs_ListBox.DisplayMember = "FFFullLogLine";
            }
        }
        #endregion

    }

    class MyRenderer : ToolStripProfessionalRenderer
    {
        // This whole thing is to remove the highlight on the toolstrip button Parse >.>
        protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
        {
            if (!e.Item.Selected)
            {
                base.OnRenderButtonBackground(e);
            }

            else if (e.Item.BackColor == Color.Red || e.Item.BackColor == Color.Green)
            {
                Rectangle rectangle = new Rectangle(0, 0, e.Item.Size.Width - 1, e.Item.Size.Height - 1);

                if (e.Item.BackColor == Color.Green)
                {
                    e.Graphics.FillRectangle(Brushes.Green, rectangle);
                    e.Graphics.DrawRectangle(Pens.Green, rectangle);
                }
                else if (e.Item.BackColor == Color.Red)
                {
                    e.Graphics.FillRectangle(Brushes.Red, rectangle);
                    e.Graphics.DrawRectangle(Pens.Red, rectangle);
                }
            }
        }
    }
}