using Advanced_Combat_Tracker;
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
using System.Threading;

namespace DataOrdo
{
    public partial class UserInterfaceMain : UserControl
    {
        public MainPlugin PlugInstance;
        public bool ParseON = false;
        public bool AutoLogScroll = true;
        public bool CB_OOCLog = true;
        public bool OOC_Regex = false;
        public bool Enc_Regex = false;
        public bool CB_OOCTimestamp = true;
        public bool CB_EncTimestamp = true;
        public bool IsInCombat = false;
        public bool CB_NetworkLogSetting = true;
        public bool CB_RawLogSetting = false;

        public UserInterfaceMain()
        {
            this.Dock = DockStyle.Fill;
            InitializeComponent();

            this.OOC_SearchTextBox.KeyDown += OOC_SearchTextBox_KeyDown;
            this.Enc_SearchTextBox.KeyDown += Enc_SearchTextBox_KeyDown;

            this.OOC_Logs_ListView.KeyDown += OOC_Logs_ListView_KeyDown;
            this.Enc_Logs_ListView.KeyDown += Enc_Logs_ListView_KeyDown;

            ToolStrip.Renderer = new MyRenderer();

            OOC_Logs_ListView.RetrieveVirtualItem += new RetrieveVirtualItemEventHandler(OOC_Logs_ListView_RetrieveVirtualItem);
            Enc_Logs_ListView.RetrieveVirtualItem += new RetrieveVirtualItemEventHandler(Enc_Logs_ListView_RetrieveVirtualItem);

            OOC_Logs_ListView.SizeChanged += OOC_Logs_ListView_SizeChanged;
            Enc_Logs_ListView.SizeChanged += Enc_Logs_ListView_SizeChanged;
            OOC_Logs_ListView.SearchForVirtualItem += new SearchForVirtualItemEventHandler(OOC_Logs_ListView_SearchForVirtualItem);
        }

        void OOC_Logs_ListView_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            if (CB_OOCTimestamp)
                e.Item = new ListViewItem(PlugInstance.ACTFFLogsOOC[e.ItemIndex].ToStringWithTimeline());
            else
                e.Item = new ListViewItem(PlugInstance.ACTFFLogsOOC[e.ItemIndex].ToStringNoTimeline());
        }
        void Enc_Logs_ListView_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            if (CB_EncTimestamp)
                e.Item = new ListViewItem(PlugInstance.ACTFFLogsEnc[e.ItemIndex].ToStringWithTimeline());
            else
                e.Item = new ListViewItem(PlugInstance.ACTFFLogsEnc[e.ItemIndex].ToStringNoTimeline());
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
            if (!ParseON)
            {
                Parse.Text = "Parse ON";
                Parse.BackColor = EnableColorPicker.BackColor;
                ParseON = true;
            }
            else if (ParseON)
            {
                Parse.Text = "Parse OFF";
                Parse.BackColor = DisableColorPicker.BackColor;
                ParseON = false;
            }
        }
        private void ToolStripSettingsButton_Click(object sender, EventArgs e)
        {
            this.PluginTabControl.SelectedTab = SettingsTab;
        }
        private void AutoScroll_Click(object sender, EventArgs e)
        {
            if (!AutoLogScroll)
            {
                AutoScrollBtn.Text = "Auto Scroll ON";
                AutoScrollBtn.BackColor = EnableColorPicker.BackColor;
                AutoLogScroll = true;
            }
            else
            {
                AutoScrollBtn.Text = "Auto Scroll OFF";
                AutoScrollBtn.BackColor = DisableColorPicker.BackColor;
                AutoLogScroll = false;
            }
        }
        #endregion

        #region Out Of Combat Logs Tab Controlls - Tab1
        private void RegexOOCSearchBar_CheckedChanged(object sender, EventArgs e)
        {
            if (!OOC_Regex)
            {
                RegexOOCSearchBar.Text = "Regex ON";
                RegexOOCSearchBar.BackColor = EnabledRegexColorPicker.BackColor;
                OOC_Regex = true;

                OOC_SearchTextBox.BackColor = Color.LightGreen;
            }
            else if (OOC_Regex)
            {
                RegexOOCSearchBar.Text = "Regex OFF";
                RegexOOCSearchBar.BackColor = DisabledRegexColorPicker.BackColor;
                OOC_Regex = false;

                OOC_SearchTextBox.BackColor = SystemColors.Window;
            }
        }
        private void OOC_Timestamp_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_OOCTimestamp)
            {
                OOC_Timestamp.BackColor = DisableColorPicker.BackColor;
                OOC_Timestamp.Text = "Timestamp OFF";
                CB_OOCTimestamp = false;
                OOC_Logs_ListView.VirtualListSize = 0;
                OOC_Logs_ListView.VirtualListSize = PlugInstance.ACTFFLogsOOC.Count;
            }
            else
            {
                OOC_Timestamp.BackColor = EnableColorPicker.BackColor;
                OOC_Timestamp.Text = "Timestamp ON";
                CB_OOCTimestamp = true;
                OOC_Logs_ListView.VirtualListSize = 0;
                OOC_Logs_ListView.VirtualListSize = PlugInstance.ACTFFLogsOOC.Count;
            }
        }
        private void OOCLog_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_OOCLog)
            {
                OOCLog.Text = "Log OFF";
                OOCLog.BackColor = DisableColorPicker.BackColor;
                CB_OOCLog = false;
            }

            else if (!CB_OOCLog)
            {
                OOCLog.Text = "Log ON";
                OOCLog.BackColor = EnableColorPicker.BackColor;
                CB_OOCLog = true;

                // add a way to stop updating the list, but will probably need to "update it" back when log back in ? < Added in the Timer_tick event
            }
        }
        private void CombatToggle_Click(object sender, EventArgs e)
        {
            if (IsInCombat)
                ActGlobals.oFormActMain.EndCombat(export: true);
        }
        private void ClearOOCLogButton_Click(object sender, EventArgs e)
        {
            // This clears the WHOLE list. Be careful when using it.
            PlugInstance.ACTFFLogsOOC.Clear();
            OOC_Logs_ListView.VirtualListSize = PlugInstance.ACTFFLogsOOC.Count;
        }

        // Help wanted for searchbar with virtual listview
        #region OOC Searchbar
        private void OOC_SearchTextBox_KeyDown(object sender, KeyEventArgs e) // Needs fixing to work with listview
        {
            if (e.KeyCode == Keys.Enter)
            {
                OOC_Logs_ListView.FindItemWithText(OOC_SearchTextBox.Text);
            }
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
        private void OOC_Logs_ListView_SearchForVirtualItem(object sender, SearchForVirtualItemEventArgs e)
        {
            for (int i = 0; i < OOC_Logs_ListView.Items.Count; i++)
            {
                if (Regex.IsMatch(i.ToString(), e.ToString()))
                {
                    OOC_Logs_ListView.Items[i].Selected = true;
                    OOC_Logs_ListView.Items[i].Checked = true;
                    MessageBox.Show(OOC_Logs_ListView.Items[i].ToString());
                }
            }
        }
        #endregion

        private void OOC_Logs_ListView_KeyDown(object sender, KeyEventArgs e)
        {
            // This allows the user to use CTRL+C to copy the selected lines.
            if (e.Control == true && e.KeyCode == Keys.C)
            {
                try
                {
                    var data = new StringBuilder();
                    for (int i = 0; i < OOC_Logs_ListView.Items.Count; i++)
                    {
                        if (OOC_Logs_ListView.Items[i].Selected)
                        {
                            data.AppendLine(OOC_Logs_ListView.Items[i].Text);
                            continue;
                        }
                    }
                    Clipboard.SetData(DataFormats.Text, data.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion

        #region Encounter Logs Tab Controls - Tab2
        private void RegexEncSearchBar_CheckedChanged(object sender, EventArgs e)
        {
            if (!Enc_Regex)
            {
                RegexEncSearchBar.Text = "Regex ON";
                RegexEncSearchBar.BackColor = Color.Blue;
                Enc_Regex = true;

                Enc_SearchTextBox.BackColor = Color.LightGreen;
            }
            else if (Enc_Regex)
            {
                RegexEncSearchBar.Text = "Regex OFF";
                RegexEncSearchBar.BackColor = Color.Gray;
                Enc_Regex = false;

                Enc_SearchTextBox.BackColor = SystemColors.Window;
            }
        }
        private void Enc_Timestamp_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_EncTimestamp)
            {
                Enc_Timestamp.BackColor = DisableColorPicker.BackColor;
                Enc_Timestamp.Text = "Timestamp OFF";
                CB_EncTimestamp = false;
                Enc_Logs_ListView.VirtualListSize = 0;
                Enc_Logs_ListView.VirtualListSize = PlugInstance.ACTFFLogsEnc.Count;
            }
            else
            {
                Enc_Timestamp.BackColor = EnableColorPicker.BackColor;
                Enc_Timestamp.Text = "Timestamp ON";
                CB_EncTimestamp = true;
                Enc_Logs_ListView.VirtualListSize = 0;
                Enc_Logs_ListView.VirtualListSize = PlugInstance.ACTFFLogsEnc.Count;
            }
        }
        private void Enc_Logs_ListView_KeyDown(object sender, KeyEventArgs e)
        {
            // This allows the user to use CTRL+C to copy the selected lines.
            if (e.Control == true && e.KeyCode == Keys.C)
            {
                try
                {
                    var data = new StringBuilder();
                    for (int i = 0; i < Enc_Logs_ListView.Items.Count; i++)
                    {
                        if (Enc_Logs_ListView.Items[i].Selected)
                        {
                            data.AppendLine(Enc_Logs_ListView.Items[i].Text);
                            continue;
                        }
                    }
                    Clipboard.SetData(DataFormats.Text, data.ToString());
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
        private void FindMyStringEnc(string searchString) // to fix with listview
        {
            /*if (!string.IsNullOrEmpty(searchString))
            {
                Enc_Logs_ListView.ClearSelected();
                for (int i = 0; i < Enc_Logs_ListView.Items.Count; i++)
                {
                    if (Enc_Regex)
                    {
                        if (Regex.IsMatch(Enc_Logs_ListView.Items[i].ToString(), searchString))
                        {
                            Enc_Logs_ListView.SetSelected(i, true);
                            Enc_Logs_ListView.Focus();
                        }
                    }
                    else if (Enc_Logs_ListView.Items[i].ToString().Contains(searchString))
                    {
                        Enc_Logs_ListView.SetSelected(i, true);
                        Enc_Logs_ListView.Focus();
                    }
                }
            }
            else
                Enc_Logs_ListView.ClearSelected();*/
        }
        #endregion

        #endregion

        #region Tab3 Controls
        #endregion

        #region Tab4 Controls
        #endregion

        #region Tab5 - RegexMaker
        #endregion

        #region Tab6 Controls - Settings
        private void CB_LogNetworkSetting_CheckedChanged(object sender, EventArgs e)
        {
            if (!CB_NetworkLogSetting)
            {
                CB_LogNetworkSetting.BackColor = EnableColorPicker.BackColor;
                CB_NetworkLogSetting = true;
            }
            else if (CB_NetworkLogSetting)
            {
                CB_LogNetworkSetting.BackColor = DisableColorPicker.BackColor;
                CB_NetworkLogSetting = false;
            }
        }
        private void CB_LogRawSetting_CheckedChanged(object sender, EventArgs e)
        {
            if (!CB_RawLogSetting)
            {
                CB_LogRawSetting.BackColor = EnableColorPicker.BackColor;
                CB_RawLogSetting = true;
            }
            else if (CB_RawLogSetting)
            {
                CB_LogRawSetting.BackColor = DisableColorPicker.BackColor;
                CB_RawLogSetting = false;
            }
        }
        private void DevModeCB_CheckedChanged(object sender, EventArgs e)
        {
            if (DevModeCB.Checked)
                ReloadPluginButton.Visible = true;
            else
                ReloadPluginButton.Visible = false;
        }
        private void ClearLogEnableCB_CheckedChanged(object sender, EventArgs e)
        {
            if (ClearLogEnableCB.Checked)
                ClearOOCLogButton.Visible = true;
            else
                ClearOOCLogButton.Visible = false;
        }
        private void EnableColorPicker_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog
            {
                AllowFullOpen = false,
                Color = EnableColorPicker.BackColor
            };
            if (MyDialog.ShowDialog() == DialogResult.OK)
                EnableColorPicker.BackColor = MyDialog.Color;
        }
        private void DisableColorPicker_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog
            {
                AllowFullOpen = false,
                Color = DisableColorPicker.BackColor
            };
            if (MyDialog.ShowDialog() == DialogResult.OK)
                DisableColorPicker.BackColor = MyDialog.Color;
        }

        private void EnabledRegexColorPicker_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog
            {
                AllowFullOpen = false,
                Color = EnabledRegexColorPicker.BackColor
            };
            if (MyDialog.ShowDialog() == DialogResult.OK)
                EnabledRegexColorPicker.BackColor = MyDialog.Color;
        }

        private void DisabledRegexColorPicker_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog
            {
                AllowFullOpen = false,
                Color = DisabledRegexColorPicker.BackColor
            };
            if (MyDialog.ShowDialog() == DialogResult.OK)
                DisabledRegexColorPicker.BackColor = MyDialog.Color;
        }

        private void LogsTimerTrackBarSet_Scroll(object sender, EventArgs e) // NYI - To do
        {
            PlugInstance.LogsTimer.Interval = LogsTimerTrackBarSet.Value * 1000;
            TrackbarValue.Text = "" + LogsTimerTrackBarSet.Value;
        }

        readonly Color Black = Color.Black;
        readonly Color White = Color.White;
        readonly Color Control = SystemColors.Control;
        readonly Color ControlText = SystemColors.ControlText;
        readonly Color Window = SystemColors.Window;
        private void CB_DarkMode_CheckedChanged(object sender, EventArgs e) // To Add UI Elements
        {
            if (CB_DarkMode.Checked)
            {
                this.BackColor = Black;
                ToolStrip.BackColor = Black;
                ToolStripSettingsButton.ForeColor = White;
                ReloadPluginButton.BackColor = Black;
                ReloadPluginButton.ForeColor = White;
                tabPage1.BackColor = Black;
                tabPage2.BackColor = Black;
                tabPage3.BackColor = Black;
                tabPage4.BackColor = Black;
                EncounterListTreeView.BackColor = Black;
                EncounterListTreeView.ForeColor = White;
                OOC_Logs_ListView.BackColor = Black;
                OOC_Logs_ListView.ForeColor = White;
                StatusStrip.BackColor = Black;
            }
            else
            {
                this.BackColor = Control;
                ToolStrip.BackColor = Control;
                ToolStripSettingsButton.ForeColor = ControlText;
                ReloadPluginButton.BackColor = Control;
                ReloadPluginButton.ForeColor = ControlText;
                tabPage1.BackColor = Color.Transparent;
                tabPage2.BackColor = Color.Transparent;
                tabPage3.BackColor = Color.Transparent;
                tabPage4.BackColor = Color.Transparent;
                EncounterListTreeView.BackColor = Window;
                EncounterListTreeView.ForeColor = ControlText;
                OOC_Logs_ListView.BackColor = Window;
                OOC_Logs_ListView.ForeColor = ControlText;
                StatusStrip.BackColor = Control;
            }
        }
        #endregion

        #region StatusStrip Controls
        #endregion

        #region Auto Resize ListView
        private bool OOCResizing = false;
        private void OOC_Logs_ListView_SizeChanged(object sender, EventArgs e)
        {
            if (!OOCResizing)
            {
                OOCResizing = true;
                if (sender is ListView listView)
                {
                    listView.Columns[0].Width = listView.ClientRectangle.Width;
                }
            }
            OOCResizing = false;
        }
        private bool EncResizing = false;
        private void Enc_Logs_ListView_SizeChanged(object sender, EventArgs e)
        {
            if (!EncResizing)
            {
                EncResizing = true;
                if (sender is ListView listView)
                {
                    listView.Columns[0].Width = listView.ClientRectangle.Width;
                }
            }
            EncResizing = false;
        }

        #endregion

    }

    class MyRenderer : ToolStripProfessionalRenderer // to fix with the DisableColorPicker.BackColor
    {
        // This whole thing is to remove the highlight on the toolstrip button Parse >.>
        protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
        {
            if (!e.Item.Selected)
                base.OnRenderButtonBackground(e);

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