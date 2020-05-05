namespace DataOrdo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterfaceMain));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Out Of Combat Encounters");
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CombatToggle = new System.Windows.Forms.Button();
            this.OOCLog = new System.Windows.Forms.CheckBox();
            this.RegexOOCSearchBar = new System.Windows.Forms.CheckBox();
            this.ClearOOCLogButton = new System.Windows.Forms.Button();
            this.OOC_Timestamp = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.OOC_Logs_ListBox = new System.Windows.Forms.ListBox();
            this.OOC_SearchTextBox = new System.Windows.Forms.TextBox();
            this.OutOfCombarParsing = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Enc_Timestamp = new System.Windows.Forms.CheckBox();
            this.RegexEncSearchBar = new System.Windows.Forms.CheckBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.Enc_Logs_ListBox = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripSeparator1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1488, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(78, 22);
            this.toolStripDropDownButton1.Text = "Settings";
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.configToolStripMenuItem.Text = "Config";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(84, 22);
            this.toolStripButton1.Text = "Reload Plugin";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 610);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1488, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1488, 585);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CombatToggle);
            this.tabPage1.Controls.Add(this.OOCLog);
            this.tabPage1.Controls.Add(this.RegexOOCSearchBar);
            this.tabPage1.Controls.Add(this.ClearOOCLogButton);
            this.tabPage1.Controls.Add(this.OOC_Timestamp);
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Controls.Add(this.OutOfCombarParsing);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1480, 559);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Out Of Combat Logs";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CombatToggle
            // 
            this.CombatToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CombatToggle.BackColor = System.Drawing.Color.Gray;
            this.CombatToggle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CombatToggle.ForeColor = System.Drawing.Color.White;
            this.CombatToggle.Location = new System.Drawing.Point(1376, 93);
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
            this.OOCLog.Location = new System.Drawing.Point(1376, 64);
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
            this.RegexOOCSearchBar.Location = new System.Drawing.Point(1376, 6);
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
            this.ClearOOCLogButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearOOCLogButton.ForeColor = System.Drawing.Color.White;
            this.ClearOOCLogButton.Location = new System.Drawing.Point(1376, 530);
            this.ClearOOCLogButton.Name = "ClearOOCLogButton";
            this.ClearOOCLogButton.Size = new System.Drawing.Size(98, 23);
            this.ClearOOCLogButton.TabIndex = 12;
            this.ClearOOCLogButton.Text = "Clear Log";
            this.ClearOOCLogButton.UseVisualStyleBackColor = false;
            this.ClearOOCLogButton.Click += new System.EventHandler(this.ClearOOCLogButton_Click);
            // 
            // OOC_Timestamp
            // 
            this.OOC_Timestamp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OOC_Timestamp.Appearance = System.Windows.Forms.Appearance.Button;
            this.OOC_Timestamp.BackColor = System.Drawing.Color.Green;
            this.OOC_Timestamp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OOC_Timestamp.ForeColor = System.Drawing.Color.White;
            this.OOC_Timestamp.Location = new System.Drawing.Point(1376, 122);
            this.OOC_Timestamp.Name = "OOC_Timestamp";
            this.OOC_Timestamp.Size = new System.Drawing.Size(98, 23);
            this.OOC_Timestamp.TabIndex = 11;
            this.OOC_Timestamp.Text = "Timestamp ON";
            this.OOC_Timestamp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OOC_Timestamp.UseVisualStyleBackColor = false;
            this.OOC_Timestamp.CheckedChanged += new System.EventHandler(this.OOC_Timestamp_CheckedChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(6, 6);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.OOC_Logs_ListBox);
            this.splitContainer1.Panel2.Controls.Add(this.OOC_SearchTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(1364, 547);
            this.splitContainer1.SplitterDistance = 300;
            this.splitContainer1.TabIndex = 10;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Root";
            treeNode1.Text = "Out Of Combat Encounters";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeView1.Size = new System.Drawing.Size(300, 547);
            this.treeView1.TabIndex = 6;
            // 
            // OOC_Logs_ListBox
            // 
            this.OOC_Logs_ListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OOC_Logs_ListBox.FormattingEnabled = true;
            this.OOC_Logs_ListBox.Location = new System.Drawing.Point(0, 23);
            this.OOC_Logs_ListBox.Name = "OOC_Logs_ListBox";
            this.OOC_Logs_ListBox.Size = new System.Drawing.Size(1060, 524);
            this.OOC_Logs_ListBox.TabIndex = 7;
            // 
            // OOC_SearchTextBox
            // 
            this.OOC_SearchTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.OOC_SearchTextBox.Location = new System.Drawing.Point(0, 0);
            this.OOC_SearchTextBox.Name = "OOC_SearchTextBox";
            this.OOC_SearchTextBox.Size = new System.Drawing.Size(1060, 20);
            this.OOC_SearchTextBox.TabIndex = 5;
            this.OOC_SearchTextBox.TextChanged += new System.EventHandler(this.OOC_SearchTextBox_TextChanged);
            // 
            // OutOfCombarParsing
            // 
            this.OutOfCombarParsing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OutOfCombarParsing.Appearance = System.Windows.Forms.Appearance.Button;
            this.OutOfCombarParsing.BackColor = System.Drawing.Color.Red;
            this.OutOfCombarParsing.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OutOfCombarParsing.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OutOfCombarParsing.ForeColor = System.Drawing.Color.White;
            this.OutOfCombarParsing.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OutOfCombarParsing.Location = new System.Drawing.Point(1376, 35);
            this.OutOfCombarParsing.Name = "OutOfCombarParsing";
            this.OutOfCombarParsing.Size = new System.Drawing.Size(98, 23);
            this.OutOfCombarParsing.TabIndex = 3;
            this.OutOfCombarParsing.Text = "Parsing OFF";
            this.OutOfCombarParsing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OutOfCombarParsing.UseVisualStyleBackColor = false;
            this.OutOfCombarParsing.CheckedChanged += new System.EventHandler(this.OutOfCombarParsing_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Enc_Timestamp);
            this.tabPage2.Controls.Add(this.RegexEncSearchBar);
            this.tabPage2.Controls.Add(this.splitContainer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1480, 559);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Encounters Logs";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Enc_Timestamp
            // 
            this.Enc_Timestamp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Enc_Timestamp.Appearance = System.Windows.Forms.Appearance.Button;
            this.Enc_Timestamp.BackColor = System.Drawing.Color.Green;
            this.Enc_Timestamp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Enc_Timestamp.ForeColor = System.Drawing.Color.White;
            this.Enc_Timestamp.Location = new System.Drawing.Point(1376, 35);
            this.Enc_Timestamp.Name = "Enc_Timestamp";
            this.Enc_Timestamp.Size = new System.Drawing.Size(98, 23);
            this.Enc_Timestamp.TabIndex = 12;
            this.Enc_Timestamp.Text = "Timestamp ON";
            this.Enc_Timestamp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Enc_Timestamp.UseVisualStyleBackColor = false;
            this.Enc_Timestamp.CheckedChanged += new System.EventHandler(this.EncTimestamp_CheckedChanged);
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
            this.RegexEncSearchBar.Location = new System.Drawing.Point(1376, 6);
            this.RegexEncSearchBar.Name = "RegexEncSearchBar";
            this.RegexEncSearchBar.Size = new System.Drawing.Size(98, 23);
            this.RegexEncSearchBar.TabIndex = 14;
            this.RegexEncSearchBar.Text = "Regex OFF";
            this.RegexEncSearchBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RegexEncSearchBar.UseVisualStyleBackColor = false;
            this.RegexEncSearchBar.CheckedChanged += new System.EventHandler(this.RegexEncSearchBar_CheckedChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(6, 6);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.treeView2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.Enc_Logs_ListBox);
            this.splitContainer2.Panel2.Controls.Add(this.textBox1);
            this.splitContainer2.Size = new System.Drawing.Size(1364, 547);
            this.splitContainer2.SplitterDistance = 300;
            this.splitContainer2.TabIndex = 5;
            // 
            // treeView2
            // 
            this.treeView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView2.Location = new System.Drawing.Point(0, 0);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(300, 547);
            this.treeView2.TabIndex = 0;
            // 
            // Enc_Logs_ListBox
            // 
            this.Enc_Logs_ListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Enc_Logs_ListBox.FormattingEnabled = true;
            this.Enc_Logs_ListBox.Location = new System.Drawing.Point(0, 23);
            this.Enc_Logs_ListBox.Name = "Enc_Logs_ListBox";
            this.Enc_Logs_ListBox.Size = new System.Drawing.Size(1060, 524);
            this.Enc_Logs_ListBox.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1060, 20);
            this.textBox1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1480, 559);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tab3 (still not sure what)";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // UserInterfaceMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "UserInterfaceMain";
            this.Size = new System.Drawing.Size(1488, 632);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox OutOfCombarParsing;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox OOC_SearchTextBox;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.CheckBox OOC_Timestamp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Button ClearOOCLogButton;
        private System.Windows.Forms.CheckBox RegexOOCSearchBar;
        public System.Windows.Forms.ListBox OOC_Logs_ListBox;
        private System.Windows.Forms.CheckBox OOCLog;
        public System.Windows.Forms.Button CombatToggle;
        private System.Windows.Forms.ListBox Enc_Logs_ListBox;
        private System.Windows.Forms.CheckBox RegexEncSearchBar;
        private System.Windows.Forms.CheckBox Enc_Timestamp;
    }
}
