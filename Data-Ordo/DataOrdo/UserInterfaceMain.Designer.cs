﻿namespace DataOrdo
{
    partial class UserInterfaceMain
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterfaceMain));
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Network Logs");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Raw Logs");
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.ToolStripSettingsButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Parse = new System.Windows.Forms.ToolStripButton();
            this.AutoScrollBtn = new System.Windows.Forms.ToolStripButton();
            this.ReloadPluginButton = new System.Windows.Forms.ToolStripButton();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.PluginTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.OOC_Logs_ListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OOC_SearchTextBox = new System.Windows.Forms.TextBox();
            this.CombatToggle = new System.Windows.Forms.Button();
            this.OOCLog = new System.Windows.Forms.CheckBox();
            this.RegexOOCSearchBar = new System.Windows.Forms.CheckBox();
            this.ClearOOCLogButton = new System.Windows.Forms.Button();
            this.OOC_Timestamp = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Enc_Logs_ListView = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Enc_Timestamp = new System.Windows.Forms.CheckBox();
            this.Enc_SearchTextBox = new System.Windows.Forms.TextBox();
            this.RegexEncSearchBar = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.RegexMaker = new System.Windows.Forms.TabPage();
            this.SettingsTab = new System.Windows.Forms.TabPage();
            this.CB_LogRawSetting = new System.Windows.Forms.CheckBox();
            this.CB_LogNetworkSetting = new System.Windows.Forms.CheckBox();
            this.TrackbarValue = new System.Windows.Forms.TextBox();
            this.CB_DarkMode = new System.Windows.Forms.CheckBox();
            this.LogsTimerTrackBarSet = new System.Windows.Forms.TrackBar();
            this.DisabledRegexColorPicker = new System.Windows.Forms.Button();
            this.EnabledRegexColorPicker = new System.Windows.Forms.Button();
            this.DisableColorPicker = new System.Windows.Forms.Button();
            this.EnableColorPicker = new System.Windows.Forms.Button();
            this.DevModeCB = new System.Windows.Forms.CheckBox();
            this.ClearLogEnableCB = new System.Windows.Forms.CheckBox();
            this.LogsTimerTrackBarToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.EncounterListTreeView = new System.Windows.Forms.TreeView();
            this.ToolStrip.SuspendLayout();
            this.PluginTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SettingsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogsTimerTrackBarSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolStrip
            // 
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripSettingsButton,
            this.toolStripSeparator1,
            this.Parse,
            this.AutoScrollBtn,
            this.ReloadPluginButton});
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(1488, 25);
            this.ToolStrip.TabIndex = 0;
            this.ToolStrip.Text = "toolStrip1";
            // 
            // ToolStripSettingsButton
            // 
            this.ToolStripSettingsButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ToolStripSettingsButton.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripSettingsButton.Image")));
            this.ToolStripSettingsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripSettingsButton.Name = "ToolStripSettingsButton";
            this.ToolStripSettingsButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ToolStripSettingsButton.Size = new System.Drawing.Size(69, 22);
            this.ToolStripSettingsButton.Text = "Settings";
            this.ToolStripSettingsButton.Click += new System.EventHandler(this.ToolStripSettingsButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // Parse
            // 
            this.Parse.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Parse.BackColor = System.Drawing.Color.Red;
            this.Parse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Parse.ForeColor = System.Drawing.Color.White;
            this.Parse.Image = ((System.Drawing.Image)(resources.GetObject("Parse.Image")));
            this.Parse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Parse.Name = "Parse";
            this.Parse.Size = new System.Drawing.Size(63, 22);
            this.Parse.Text = "Parse OFF";
            this.Parse.ToolTipText = " Toggle Parsing - Both for OOC and Enc";
            this.Parse.Click += new System.EventHandler(this.Parse_Click);
            // 
            // AutoScrollBtn
            // 
            this.AutoScrollBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.AutoScrollBtn.BackColor = System.Drawing.Color.Green;
            this.AutoScrollBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AutoScrollBtn.ForeColor = System.Drawing.Color.White;
            this.AutoScrollBtn.Image = ((System.Drawing.Image)(resources.GetObject("AutoScrollBtn.Image")));
            this.AutoScrollBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AutoScrollBtn.Name = "AutoScrollBtn";
            this.AutoScrollBtn.Size = new System.Drawing.Size(90, 22);
            this.AutoScrollBtn.Text = "Auto Scroll ON";
            this.AutoScrollBtn.ToolTipText = " Toggle Parsing - Both for OOC and Enc";
            this.AutoScrollBtn.Click += new System.EventHandler(this.AutoScroll_Click);
            // 
            // ReloadPluginButton
            // 
            this.ReloadPluginButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ReloadPluginButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ReloadPluginButton.Image = ((System.Drawing.Image)(resources.GetObject("ReloadPluginButton.Image")));
            this.ReloadPluginButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ReloadPluginButton.Name = "ReloadPluginButton";
            this.ReloadPluginButton.Size = new System.Drawing.Size(84, 22);
            this.ReloadPluginButton.Text = "Reload Plugin";
            this.ReloadPluginButton.Visible = false;
            this.ReloadPluginButton.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Location = new System.Drawing.Point(0, 610);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(1488, 22);
            this.StatusStrip.TabIndex = 1;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // PluginTabControl
            // 
            this.PluginTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PluginTabControl.Controls.Add(this.tabPage1);
            this.PluginTabControl.Controls.Add(this.tabPage2);
            this.PluginTabControl.Controls.Add(this.tabPage3);
            this.PluginTabControl.Controls.Add(this.tabPage4);
            this.PluginTabControl.Controls.Add(this.RegexMaker);
            this.PluginTabControl.Controls.Add(this.SettingsTab);
            this.PluginTabControl.Location = new System.Drawing.Point(139, 25);
            this.PluginTabControl.Name = "PluginTabControl";
            this.PluginTabControl.SelectedIndex = 0;
            this.PluginTabControl.Size = new System.Drawing.Size(1349, 585);
            this.PluginTabControl.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.OOC_Logs_ListView);
            this.tabPage1.Controls.Add(this.OOC_SearchTextBox);
            this.tabPage1.Controls.Add(this.CombatToggle);
            this.tabPage1.Controls.Add(this.OOCLog);
            this.tabPage1.Controls.Add(this.RegexOOCSearchBar);
            this.tabPage1.Controls.Add(this.ClearOOCLogButton);
            this.tabPage1.Controls.Add(this.OOC_Timestamp);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1341, 559);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Out Of Combat Logs";
            // 
            // OOC_Logs_ListView
            // 
            this.OOC_Logs_ListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OOC_Logs_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.OOC_Logs_ListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.OOC_Logs_ListView.HideSelection = false;
            this.OOC_Logs_ListView.Location = new System.Drawing.Point(3, 29);
            this.OOC_Logs_ListView.Name = "OOC_Logs_ListView";
            this.OOC_Logs_ListView.Size = new System.Drawing.Size(1225, 527);
            this.OOC_Logs_ListView.TabIndex = 6;
            this.OOC_Logs_ListView.UseCompatibleStateImageBehavior = false;
            this.OOC_Logs_ListView.View = System.Windows.Forms.View.Details;
            this.OOC_Logs_ListView.VirtualMode = true;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 1056;
            // 
            // OOC_SearchTextBox
            // 
            this.OOC_SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OOC_SearchTextBox.Location = new System.Drawing.Point(3, 3);
            this.OOC_SearchTextBox.Name = "OOC_SearchTextBox";
            this.OOC_SearchTextBox.Size = new System.Drawing.Size(1225, 20);
            this.OOC_SearchTextBox.TabIndex = 16;
            // 
            // CombatToggle
            // 
            this.CombatToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CombatToggle.BackColor = System.Drawing.Color.Gray;
            this.CombatToggle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CombatToggle.ForeColor = System.Drawing.Color.White;
            this.CombatToggle.Location = new System.Drawing.Point(1234, 64);
            this.CombatToggle.Name = "CombatToggle";
            this.CombatToggle.Size = new System.Drawing.Size(98, 23);
            this.CombatToggle.TabIndex = 13;
            this.CombatToggle.UseVisualStyleBackColor = false;
            this.CombatToggle.Click += new System.EventHandler(this.CombatToggle_Click);
            // 
            // OOCLog
            // 
            this.OOCLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OOCLog.Appearance = System.Windows.Forms.Appearance.Button;
            this.OOCLog.BackColor = System.Drawing.Color.Green;
            this.OOCLog.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OOCLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OOCLog.ForeColor = System.Drawing.Color.White;
            this.OOCLog.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OOCLog.Location = new System.Drawing.Point(1234, 35);
            this.OOCLog.Name = "OOCLog";
            this.OOCLog.Size = new System.Drawing.Size(98, 23);
            this.OOCLog.TabIndex = 15;
            this.OOCLog.Text = "Log ON";
            this.OOCLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OOCLog.UseVisualStyleBackColor = false;
            this.OOCLog.CheckedChanged += new System.EventHandler(this.OOCLog_CheckedChanged);
            // 
            // RegexOOCSearchBar
            // 
            this.RegexOOCSearchBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RegexOOCSearchBar.Appearance = System.Windows.Forms.Appearance.Button;
            this.RegexOOCSearchBar.BackColor = System.Drawing.Color.Gray;
            this.RegexOOCSearchBar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RegexOOCSearchBar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RegexOOCSearchBar.ForeColor = System.Drawing.Color.White;
            this.RegexOOCSearchBar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RegexOOCSearchBar.Location = new System.Drawing.Point(1234, 6);
            this.RegexOOCSearchBar.Name = "RegexOOCSearchBar";
            this.RegexOOCSearchBar.Size = new System.Drawing.Size(98, 23);
            this.RegexOOCSearchBar.TabIndex = 13;
            this.RegexOOCSearchBar.Text = "Regex OFF";
            this.RegexOOCSearchBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RegexOOCSearchBar.UseVisualStyleBackColor = false;
            this.RegexOOCSearchBar.CheckedChanged += new System.EventHandler(this.RegexOOCSearchBar_CheckedChanged);
            // 
            // ClearOOCLogButton
            // 
            this.ClearOOCLogButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearOOCLogButton.BackColor = System.Drawing.Color.Black;
            this.ClearOOCLogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearOOCLogButton.ForeColor = System.Drawing.Color.White;
            this.ClearOOCLogButton.Location = new System.Drawing.Point(1234, 530);
            this.ClearOOCLogButton.Name = "ClearOOCLogButton";
            this.ClearOOCLogButton.Size = new System.Drawing.Size(98, 23);
            this.ClearOOCLogButton.TabIndex = 12;
            this.ClearOOCLogButton.Text = "Clear";
            this.ClearOOCLogButton.UseVisualStyleBackColor = false;
            this.ClearOOCLogButton.Visible = false;
            this.ClearOOCLogButton.Click += new System.EventHandler(this.ClearOOCLogButton_Click);
            // 
            // OOC_Timestamp
            // 
            this.OOC_Timestamp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OOC_Timestamp.Appearance = System.Windows.Forms.Appearance.Button;
            this.OOC_Timestamp.BackColor = System.Drawing.Color.Green;
            this.OOC_Timestamp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OOC_Timestamp.ForeColor = System.Drawing.Color.White;
            this.OOC_Timestamp.Location = new System.Drawing.Point(1234, 93);
            this.OOC_Timestamp.Name = "OOC_Timestamp";
            this.OOC_Timestamp.Size = new System.Drawing.Size(98, 23);
            this.OOC_Timestamp.TabIndex = 11;
            this.OOC_Timestamp.Text = "Timestamp ON";
            this.OOC_Timestamp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OOC_Timestamp.UseVisualStyleBackColor = false;
            this.OOC_Timestamp.CheckedChanged += new System.EventHandler(this.OOC_Timestamp_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Enc_Logs_ListView);
            this.tabPage2.Controls.Add(this.Enc_Timestamp);
            this.tabPage2.Controls.Add(this.Enc_SearchTextBox);
            this.tabPage2.Controls.Add(this.RegexEncSearchBar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1341, 559);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Encounters Logs";
            // 
            // Enc_Logs_ListView
            // 
            this.Enc_Logs_ListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Enc_Logs_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.Enc_Logs_ListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.Enc_Logs_ListView.HideSelection = false;
            this.Enc_Logs_ListView.Location = new System.Drawing.Point(3, 29);
            this.Enc_Logs_ListView.Name = "Enc_Logs_ListView";
            this.Enc_Logs_ListView.Size = new System.Drawing.Size(1225, 527);
            this.Enc_Logs_ListView.TabIndex = 7;
            this.Enc_Logs_ListView.UseCompatibleStateImageBehavior = false;
            this.Enc_Logs_ListView.View = System.Windows.Forms.View.Details;
            this.Enc_Logs_ListView.VirtualMode = true;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "";
            this.columnHeader2.Width = 1056;
            // 
            // Enc_Timestamp
            // 
            this.Enc_Timestamp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Enc_Timestamp.Appearance = System.Windows.Forms.Appearance.Button;
            this.Enc_Timestamp.BackColor = System.Drawing.Color.Green;
            this.Enc_Timestamp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Enc_Timestamp.ForeColor = System.Drawing.Color.White;
            this.Enc_Timestamp.Location = new System.Drawing.Point(1234, 35);
            this.Enc_Timestamp.Name = "Enc_Timestamp";
            this.Enc_Timestamp.Size = new System.Drawing.Size(98, 23);
            this.Enc_Timestamp.TabIndex = 12;
            this.Enc_Timestamp.Text = "Timestamp ON";
            this.Enc_Timestamp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Enc_Timestamp.UseVisualStyleBackColor = false;
            this.Enc_Timestamp.CheckedChanged += new System.EventHandler(this.Enc_Timestamp_CheckedChanged);
            // 
            // Enc_SearchTextBox
            // 
            this.Enc_SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Enc_SearchTextBox.Location = new System.Drawing.Point(3, 3);
            this.Enc_SearchTextBox.Name = "Enc_SearchTextBox";
            this.Enc_SearchTextBox.Size = new System.Drawing.Size(1225, 20);
            this.Enc_SearchTextBox.TabIndex = 0;
            this.Enc_SearchTextBox.TextChanged += new System.EventHandler(this.Enc_SearchTextBox_TextChanged);
            // 
            // RegexEncSearchBar
            // 
            this.RegexEncSearchBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RegexEncSearchBar.Appearance = System.Windows.Forms.Appearance.Button;
            this.RegexEncSearchBar.BackColor = System.Drawing.Color.Gray;
            this.RegexEncSearchBar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RegexEncSearchBar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RegexEncSearchBar.ForeColor = System.Drawing.Color.White;
            this.RegexEncSearchBar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RegexEncSearchBar.Location = new System.Drawing.Point(1234, 6);
            this.RegexEncSearchBar.Name = "RegexEncSearchBar";
            this.RegexEncSearchBar.Size = new System.Drawing.Size(98, 23);
            this.RegexEncSearchBar.TabIndex = 14;
            this.RegexEncSearchBar.Text = "Regex OFF";
            this.RegexEncSearchBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RegexEncSearchBar.UseVisualStyleBackColor = false;
            this.RegexEncSearchBar.CheckedChanged += new System.EventHandler(this.RegexEncSearchBar_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1341, 559);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Raw FFXIV Logs OOC";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1341, 559);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Raw FFXIV Logs Enc";
            // 
            // RegexMaker
            // 
            this.RegexMaker.Location = new System.Drawing.Point(4, 22);
            this.RegexMaker.Name = "RegexMaker";
            this.RegexMaker.Size = new System.Drawing.Size(1341, 559);
            this.RegexMaker.TabIndex = 5;
            this.RegexMaker.Text = "RegexMaker";
            // 
            // SettingsTab
            // 
            this.SettingsTab.Controls.Add(this.CB_LogRawSetting);
            this.SettingsTab.Controls.Add(this.CB_LogNetworkSetting);
            this.SettingsTab.Controls.Add(this.TrackbarValue);
            this.SettingsTab.Controls.Add(this.CB_DarkMode);
            this.SettingsTab.Controls.Add(this.LogsTimerTrackBarSet);
            this.SettingsTab.Controls.Add(this.DisabledRegexColorPicker);
            this.SettingsTab.Controls.Add(this.EnabledRegexColorPicker);
            this.SettingsTab.Controls.Add(this.DisableColorPicker);
            this.SettingsTab.Controls.Add(this.EnableColorPicker);
            this.SettingsTab.Controls.Add(this.DevModeCB);
            this.SettingsTab.Controls.Add(this.ClearLogEnableCB);
            this.SettingsTab.Location = new System.Drawing.Point(4, 22);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.Size = new System.Drawing.Size(1341, 559);
            this.SettingsTab.TabIndex = 4;
            this.SettingsTab.Text = "Settings";
            // 
            // CB_LogRawSetting
            // 
            this.CB_LogRawSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_LogRawSetting.Appearance = System.Windows.Forms.Appearance.Button;
            this.CB_LogRawSetting.BackColor = System.Drawing.Color.Red;
            this.CB_LogRawSetting.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CB_LogRawSetting.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CB_LogRawSetting.ForeColor = System.Drawing.Color.White;
            this.CB_LogRawSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CB_LogRawSetting.Location = new System.Drawing.Point(1239, 32);
            this.CB_LogRawSetting.Name = "CB_LogRawSetting";
            this.CB_LogRawSetting.Size = new System.Drawing.Size(98, 23);
            this.CB_LogRawSetting.TabIndex = 17;
            this.CB_LogRawSetting.Text = "Log Raw";
            this.CB_LogRawSetting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CB_LogRawSetting.UseVisualStyleBackColor = false;
            this.CB_LogRawSetting.CheckedChanged += new System.EventHandler(this.CB_LogRawSetting_CheckedChanged);
            // 
            // CB_LogNetworkSetting
            // 
            this.CB_LogNetworkSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_LogNetworkSetting.Appearance = System.Windows.Forms.Appearance.Button;
            this.CB_LogNetworkSetting.BackColor = System.Drawing.Color.Green;
            this.CB_LogNetworkSetting.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CB_LogNetworkSetting.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CB_LogNetworkSetting.ForeColor = System.Drawing.Color.White;
            this.CB_LogNetworkSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CB_LogNetworkSetting.Location = new System.Drawing.Point(1239, 3);
            this.CB_LogNetworkSetting.Name = "CB_LogNetworkSetting";
            this.CB_LogNetworkSetting.Size = new System.Drawing.Size(98, 23);
            this.CB_LogNetworkSetting.TabIndex = 16;
            this.CB_LogNetworkSetting.Text = "Log Network";
            this.CB_LogNetworkSetting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CB_LogNetworkSetting.UseVisualStyleBackColor = false;
            this.CB_LogNetworkSetting.CheckedChanged += new System.EventHandler(this.CB_LogNetworkSetting_CheckedChanged);
            // 
            // TrackbarValue
            // 
            this.TrackbarValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TrackbarValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrackbarValue.Location = new System.Drawing.Point(160, 511);
            this.TrackbarValue.Multiline = true;
            this.TrackbarValue.Name = "TrackbarValue";
            this.TrackbarValue.ReadOnly = true;
            this.TrackbarValue.Size = new System.Drawing.Size(42, 42);
            this.TrackbarValue.TabIndex = 11;
            this.TrackbarValue.Text = "2";
            this.TrackbarValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CB_DarkMode
            // 
            this.CB_DarkMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_DarkMode.AutoSize = true;
            this.CB_DarkMode.Location = new System.Drawing.Point(1258, 516);
            this.CB_DarkMode.Name = "CB_DarkMode";
            this.CB_DarkMode.Size = new System.Drawing.Size(79, 17);
            this.CB_DarkMode.TabIndex = 10;
            this.CB_DarkMode.Text = "Dark Mode";
            this.CB_DarkMode.UseVisualStyleBackColor = true;
            this.CB_DarkMode.CheckedChanged += new System.EventHandler(this.CB_DarkMode_CheckedChanged);
            // 
            // LogsTimerTrackBarSet
            // 
            this.LogsTimerTrackBarSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LogsTimerTrackBarSet.BackColor = System.Drawing.Color.White;
            this.LogsTimerTrackBarSet.LargeChange = 1;
            this.LogsTimerTrackBarSet.Location = new System.Drawing.Point(3, 511);
            this.LogsTimerTrackBarSet.Minimum = 1;
            this.LogsTimerTrackBarSet.Name = "LogsTimerTrackBarSet";
            this.LogsTimerTrackBarSet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LogsTimerTrackBarSet.Size = new System.Drawing.Size(151, 45);
            this.LogsTimerTrackBarSet.TabIndex = 9;
            this.LogsTimerTrackBarToolTip.SetToolTip(this.LogsTimerTrackBarSet, "Sets the delay at which the UI updates for the Logs\r\n\r\nRange from 1 to 10 - Defau" +
        "lt as 2");
            this.LogsTimerTrackBarSet.Value = 2;
            this.LogsTimerTrackBarSet.Scroll += new System.EventHandler(this.LogsTimerTrackBarSet_Scroll);
            // 
            // DisabledRegexColorPicker
            // 
            this.DisabledRegexColorPicker.AutoSize = true;
            this.DisabledRegexColorPicker.BackColor = System.Drawing.Color.Gray;
            this.DisabledRegexColorPicker.ForeColor = System.Drawing.Color.White;
            this.DisabledRegexColorPicker.Location = new System.Drawing.Point(3, 113);
            this.DisabledRegexColorPicker.Name = "DisabledRegexColorPicker";
            this.DisabledRegexColorPicker.Size = new System.Drawing.Size(153, 23);
            this.DisabledRegexColorPicker.TabIndex = 8;
            this.DisabledRegexColorPicker.Text = "Disabled Regex Button Color";
            this.DisabledRegexColorPicker.UseVisualStyleBackColor = false;
            this.DisabledRegexColorPicker.Click += new System.EventHandler(this.DisabledRegexColorPicker_Click);
            // 
            // EnabledRegexColorPicker
            // 
            this.EnabledRegexColorPicker.AutoSize = true;
            this.EnabledRegexColorPicker.BackColor = System.Drawing.Color.Blue;
            this.EnabledRegexColorPicker.ForeColor = System.Drawing.Color.White;
            this.EnabledRegexColorPicker.Location = new System.Drawing.Point(3, 84);
            this.EnabledRegexColorPicker.Name = "EnabledRegexColorPicker";
            this.EnabledRegexColorPicker.Size = new System.Drawing.Size(151, 23);
            this.EnabledRegexColorPicker.TabIndex = 7;
            this.EnabledRegexColorPicker.Text = "Enabled Regex Button Color";
            this.EnabledRegexColorPicker.UseVisualStyleBackColor = false;
            this.EnabledRegexColorPicker.Click += new System.EventHandler(this.EnabledRegexColorPicker_Click);
            // 
            // DisableColorPicker
            // 
            this.DisableColorPicker.AutoSize = true;
            this.DisableColorPicker.BackColor = System.Drawing.Color.Red;
            this.DisableColorPicker.ForeColor = System.Drawing.Color.White;
            this.DisableColorPicker.Location = new System.Drawing.Point(21, 55);
            this.DisableColorPicker.Name = "DisableColorPicker";
            this.DisableColorPicker.Size = new System.Drawing.Size(119, 23);
            this.DisableColorPicker.TabIndex = 6;
            this.DisableColorPicker.Text = "Disabled Button Color";
            this.DisableColorPicker.UseVisualStyleBackColor = false;
            this.DisableColorPicker.Click += new System.EventHandler(this.DisableColorPicker_Click);
            // 
            // EnableColorPicker
            // 
            this.EnableColorPicker.AutoSize = true;
            this.EnableColorPicker.BackColor = System.Drawing.Color.Green;
            this.EnableColorPicker.ForeColor = System.Drawing.Color.White;
            this.EnableColorPicker.Location = new System.Drawing.Point(21, 26);
            this.EnableColorPicker.Name = "EnableColorPicker";
            this.EnableColorPicker.Size = new System.Drawing.Size(117, 23);
            this.EnableColorPicker.TabIndex = 5;
            this.EnableColorPicker.Text = "Enabled Button Color";
            this.EnableColorPicker.UseVisualStyleBackColor = false;
            this.EnableColorPicker.Click += new System.EventHandler(this.EnableColorPicker_Click);
            // 
            // DevModeCB
            // 
            this.DevModeCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DevModeCB.AutoSize = true;
            this.DevModeCB.Location = new System.Drawing.Point(1258, 539);
            this.DevModeCB.Name = "DevModeCB";
            this.DevModeCB.Size = new System.Drawing.Size(73, 17);
            this.DevModeCB.TabIndex = 4;
            this.DevModeCB.Text = "DevMode";
            this.DevModeCB.UseVisualStyleBackColor = true;
            this.DevModeCB.CheckedChanged += new System.EventHandler(this.DevModeCB_CheckedChanged);
            // 
            // ClearLogEnableCB
            // 
            this.ClearLogEnableCB.AutoSize = true;
            this.ClearLogEnableCB.Location = new System.Drawing.Point(3, 3);
            this.ClearLogEnableCB.Name = "ClearLogEnableCB";
            this.ClearLogEnableCB.Size = new System.Drawing.Size(137, 17);
            this.ClearLogEnableCB.TabIndex = 0;
            this.ClearLogEnableCB.Text = "Clear Log Button (OOC)";
            this.ClearLogEnableCB.UseVisualStyleBackColor = true;
            this.ClearLogEnableCB.CheckedChanged += new System.EventHandler(this.ClearLogEnableCB_CheckedChanged);
            // 
            // EncounterListTreeView
            // 
            this.EncounterListTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.EncounterListTreeView.Location = new System.Drawing.Point(0, 25);
            this.EncounterListTreeView.Name = "EncounterListTreeView";
            treeNode7.Name = "Node0";
            treeNode7.Text = "Network Logs";
            treeNode8.Name = "Node0";
            treeNode8.Text = "Raw Logs";
            this.EncounterListTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            this.EncounterListTreeView.Size = new System.Drawing.Size(140, 581);
            this.EncounterListTreeView.TabIndex = 3;
            // 
            // UserInterfaceMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.EncounterListTreeView);
            this.Controls.Add(this.PluginTabControl);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.ToolStrip);
            this.Name = "UserInterfaceMain";
            this.Size = new System.Drawing.Size(1488, 632);
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.PluginTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.SettingsTab.ResumeLayout(false);
            this.SettingsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogsTimerTrackBarSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox OOC_Timestamp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ReloadPluginButton;
        private System.Windows.Forms.Button ClearOOCLogButton;
        private System.Windows.Forms.CheckBox RegexOOCSearchBar;
        private System.Windows.Forms.CheckBox OOCLog;
        public System.Windows.Forms.Button CombatToggle;
        private System.Windows.Forms.CheckBox RegexEncSearchBar;
        private System.Windows.Forms.CheckBox Enc_Timestamp;
        public System.Windows.Forms.ToolStripButton Parse;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage SettingsTab;
        public System.Windows.Forms.Button EnableColorPicker;
        public System.Windows.Forms.Button DisableColorPicker;
        public System.Windows.Forms.Button EnabledRegexColorPicker;
        public System.Windows.Forms.Button DisabledRegexColorPicker;
        public System.Windows.Forms.TrackBar LogsTimerTrackBarSet;
        private System.Windows.Forms.ToolTip LogsTimerTrackBarToolTip;
        public System.Windows.Forms.ToolStripButton ToolStripSettingsButton;
        public System.Windows.Forms.CheckBox DevModeCB;
        public System.Windows.Forms.CheckBox ClearLogEnableCB;
        public System.Windows.Forms.CheckBox CB_DarkMode;
        public System.Windows.Forms.TabControl PluginTabControl;
        private System.Windows.Forms.TabPage RegexMaker;
        public System.Windows.Forms.ToolStripButton AutoScrollBtn;
        public System.Windows.Forms.TextBox TrackbarValue;
        public System.Windows.Forms.ListView OOC_Logs_ListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox OOC_SearchTextBox;
        public System.Windows.Forms.ListView Enc_Logs_ListView;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox Enc_SearchTextBox;
        public System.Windows.Forms.TreeView EncounterListTreeView;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox CB_LogRawSetting;
        private System.Windows.Forms.CheckBox CB_LogNetworkSetting;
    }
}