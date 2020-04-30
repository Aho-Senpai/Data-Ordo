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
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Out Of Combat Encounters");
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.autoScrollOOCLog = new System.Windows.Forms.CheckBox();
            this.RegexOOCSearchBar = new System.Windows.Forms.CheckBox();
            this.ClearOOCLogButton = new System.Windows.Forms.Button();
            this.OOC_Timestamp = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.OutOfCombarParsing = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.EncountersParsing = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
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
            this.tabPage1.Controls.Add(this.autoScrollOOCLog);
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
            // autoScrollOOCLog
            // 
            this.autoScrollOOCLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.autoScrollOOCLog.Appearance = System.Windows.Forms.Appearance.Button;
            this.autoScrollOOCLog.BackColor = System.Drawing.Color.Red;
            this.autoScrollOOCLog.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.autoScrollOOCLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.autoScrollOOCLog.ForeColor = System.Drawing.Color.White;
            this.autoScrollOOCLog.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.autoScrollOOCLog.Location = new System.Drawing.Point(1376, 93);
            this.autoScrollOOCLog.Name = "autoScrollOOCLog";
            this.autoScrollOOCLog.Size = new System.Drawing.Size(98, 23);
            this.autoScrollOOCLog.TabIndex = 14;
            this.autoScrollOOCLog.Text = "AutoScroll OFF";
            this.autoScrollOOCLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.autoScrollOOCLog.UseVisualStyleBackColor = false;
            this.autoScrollOOCLog.CheckedChanged += new System.EventHandler(this.AutoScrollOOCLog_CheckedChanged);
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
            this.OOC_Timestamp.Location = new System.Drawing.Point(1376, 64);
            this.OOC_Timestamp.Name = "OOC_Timestamp";
            this.OOC_Timestamp.Size = new System.Drawing.Size(98, 23);
            this.OOC_Timestamp.TabIndex = 11;
            this.OOC_Timestamp.Text = "Timestamp ON";
            this.OOC_Timestamp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OOC_Timestamp.UseVisualStyleBackColor = false;
            this.OOC_Timestamp.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
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
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Panel2.Controls.Add(this.textBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1364, 547);
            this.splitContainer1.SplitterDistance = 300;
            this.splitContainer1.TabIndex = 10;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode4.Name = "Root";
            treeNode4.Text = "Out Of Combat Encounters";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.treeView1.Size = new System.Drawing.Size(300, 547);
            this.treeView1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(1060, 20);
            this.textBox2.TabIndex = 5;
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
            this.tabPage2.Controls.Add(this.splitContainer2);
            this.tabPage2.Controls.Add(this.EncountersParsing);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1480, 559);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Encounters Logs";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.splitContainer2.Panel2.Controls.Add(this.richTextBox2);
            this.splitContainer2.Panel2.Controls.Add(this.textBox1);
            this.splitContainer2.Size = new System.Drawing.Size(1364, 547);
            this.splitContainer2.SplitterDistance = 454;
            this.splitContainer2.TabIndex = 5;
            // 
            // treeView2
            // 
            this.treeView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView2.Location = new System.Drawing.Point(0, 0);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(454, 547);
            this.treeView2.TabIndex = 0;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox2.Location = new System.Drawing.Point(0, 26);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(906, 518);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(906, 20);
            this.textBox1.TabIndex = 0;
            // 
            // EncountersParsing
            // 
            this.EncountersParsing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EncountersParsing.Appearance = System.Windows.Forms.Appearance.Button;
            this.EncountersParsing.BackColor = System.Drawing.Color.Red;
            this.EncountersParsing.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EncountersParsing.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EncountersParsing.ForeColor = System.Drawing.Color.White;
            this.EncountersParsing.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EncountersParsing.Location = new System.Drawing.Point(1376, 6);
            this.EncountersParsing.Name = "EncountersParsing";
            this.EncountersParsing.Size = new System.Drawing.Size(98, 23);
            this.EncountersParsing.TabIndex = 4;
            this.EncountersParsing.Text = "Parsing OFF";
            this.EncountersParsing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EncountersParsing.UseVisualStyleBackColor = false;
            this.EncountersParsing.CheckedChanged += new System.EventHandler(this.EncountersParsing_CheckedChanged);
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
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 26);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1060, 521);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
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
        private System.Windows.Forms.CheckBox EncountersParsing;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.CheckBox OOC_Timestamp;
        public System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Button ClearOOCLogButton;
        private System.Windows.Forms.CheckBox RegexOOCSearchBar;
        private System.Windows.Forms.CheckBox autoScrollOOCLog;
        private System.Windows.Forms.ListView listView1;
    }
}
