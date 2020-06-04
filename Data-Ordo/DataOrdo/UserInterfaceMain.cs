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

        public bool OOC_Regex = false;
        public bool Enc_Regex = false;
        
        public bool CB_OOCTimestamp = true;
        public bool CB_EncTimestamp;

        public bool IsInCombat;

        public BindingList<FFLogLine> MyFFDataOOC = new BindingList<FFLogLine>();
        public BindingList<FFLogLine> MyFFDataEnc = new BindingList<FFLogLine>();

        public UserInterfaceMain()
        {
            this.Dock = DockStyle.Fill;
            InitializeComponent();
            
            this.OOC_SearchTextBox.KeyDown += OOC_SearchTextBox_KeyDown;
            this.Enc_SearchTextBox.KeyDown += Enc_SearchTextBox_KeyDown;

            toolStrip1.Renderer = new MyRenderer();

            OOC_Logs_ListBox.DataSource = MyFFDataOOC;
            // OOC_Logs_ListBox.DisplayMember = "FullDisplay";

            Enc_Logs_ListBox.DataSource = MyFFDataEnc;
            // Enc_Logs_ListBox.DisplayMember = "FullDisplay";
        }
        public void SetPluginVar(MainPlugin PluginInstance)
        {
            this.PlugInstance = PluginInstance;
        }

        #region ToolStrip Controls
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
        private void RegexOOCSearchBar_CheckedChanged(object sender, EventArgs e)
        {
            if (RegexOOCSearchBar.BackColor == Color.Gray)
            {
                RegexOOCSearchBar.Text = "Regex ON";
                RegexOOCSearchBar.BackColor = Color.Blue;
                OOC_Regex = true;

                OOC_SearchTextBox.BackColor = Color.LightGreen;
            }
            else if (RegexOOCSearchBar.BackColor == Color.Blue)
            {
                RegexOOCSearchBar.Text = "Regex OFF";
                RegexOOCSearchBar.BackColor = Color.Gray;
                OOC_Regex = false;

                OOC_SearchTextBox.BackColor = SystemColors.Window;
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

                // add a way to stop updating the list, but will probably need to "update it" back when log back in ?

            }
        }
        private void CombatToggle_Click(object sender, EventArgs e)
        {
            if (IsInCombat)
                ActGlobals.oFormActMain.EndCombat(export: true);
        }
        private void ClearOOCLogButton_Click(object sender, EventArgs e) // Prob to add under a setting later
        {
            // This clears the WHOLE list. Be careful when using it.
            MyFFDataOOC.Clear();
        }

        #region OOC Searchbar
        private void OOC_SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                FindMyStringOOC(OOC_SearchTextBox.Text);
        }
        private void OOC_SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            // This is where we change the background color of the Searchbar
            if (OOC_Regex)
            {
                try
                {
                    Regex rex = new Regex(OOC_SearchTextBox.Text);
                    OOC_SearchTextBox.BackColor = Color.LightGreen;
                }
                catch (ArgumentException)
                {
                    OOC_SearchTextBox.BackColor = Color.LightCoral;
                }
            }
        }
        private void FindMyStringOOC(string searchString)
        {
            if (!string.IsNullOrEmpty(searchString))
            {
                OOC_Logs_ListBox.ClearSelected();
                for (int i = 0; i < OOC_Logs_ListBox.Items.Count; i++)
                {
                    if (OOC_Regex)
                    {
                        if (Regex.IsMatch(OOC_Logs_ListBox.Items[i].ToString(), searchString))
                        {
                            OOC_Logs_ListBox.SetSelected(i, true);
                            OOC_Logs_ListBox.Focus();
                        }
                    }
                    else if (OOC_Logs_ListBox.Items[i].ToString().Contains(searchString))
                    {
                        OOC_Logs_ListBox.SetSelected(i, true);
                        OOC_Logs_ListBox.Focus();
                    }
                }
            }
            else
                OOC_Logs_ListBox.ClearSelected();
        }
        #endregion

        private void OOC_Logs_ListBox_KeyDown(object sender, KeyEventArgs e)
        {
            // This allows the user to use CTRL+C to copy the selected lines.
            if (e.Control == true && e.KeyCode == Keys.C)
            {
                try
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (object row in OOC_Logs_ListBox.SelectedItems)
                    {
                        sb.Append(row.ToString());
                    }
                    sb.Remove(sb.Length - 1, 1); // Just to avoid copying last empty row
                    Clipboard.SetData(System.Windows.Forms.DataFormats.Text, sb.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
                Enc_Regex = true;

                Enc_SearchTextBox.BackColor = Color.LightGreen;
            }
            else if (RegexEncSearchBar.BackColor == Color.Blue)
            {
                RegexEncSearchBar.Text = "Regex OFF";
                RegexEncSearchBar.BackColor = Color.Gray;
                Enc_Regex = false;

                Enc_SearchTextBox.BackColor = SystemColors.Window;
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
        private void Enc_Logs_ListBox_KeyDown(object sender, KeyEventArgs e)
        {
            // This allows the user to use CTRL+C to copy the selected lines.
            if (e.Control == true && e.KeyCode == Keys.C)
            {
                try
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (object row in Enc_Logs_ListBox.SelectedItems)
                    {
                        sb.Append(row.ToString());
                    }
                    sb.Remove(sb.Length - 1, 1); // Just to avoid copying last empty row
                    Clipboard.SetData(System.Windows.Forms.DataFormats.Text, sb.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        #region Enc Searchbar
        private void Enc_SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                FindMyStringEnc(Enc_SearchTextBox.Text);
        }
        private void Enc_SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            // This is where we change the background color of the Searchbar
            if (Enc_Regex)
            {
                try
                {
                    Regex rex = new Regex(Enc_SearchTextBox.Text);
                    Enc_SearchTextBox.BackColor = Color.LightGreen;
                }
                catch (ArgumentException)
                {
                    Enc_SearchTextBox.BackColor = Color.LightCoral;
                }
            }
        }
        private void FindMyStringEnc(string searchString)
        {
            if (!string.IsNullOrEmpty(searchString))
            {
                Enc_Logs_ListBox.ClearSelected();
                for (int i = 0; i < Enc_Logs_ListBox.Items.Count; i++)
                {
                    if (Enc_Regex)
                    {
                        if (Regex.IsMatch(Enc_Logs_ListBox.Items[i].ToString(), searchString))
                        {
                            Enc_Logs_ListBox.SetSelected(i, true);
                            Enc_Logs_ListBox.Focus();
                        }
                    }
                    else if (Enc_Logs_ListBox.Items[i].ToString().Contains(searchString))
                    {
                        Enc_Logs_ListBox.SetSelected(i, true);
                        Enc_Logs_ListBox.Focus();
                    }
                }
            }
            else
                Enc_Logs_ListBox.ClearSelected();
        }
        #endregion

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