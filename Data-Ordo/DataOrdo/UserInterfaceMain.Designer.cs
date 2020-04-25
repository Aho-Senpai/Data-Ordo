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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.OutOfCombarParsing = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.EncountersParsing = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1488, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1488, 585);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.treeView1);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.OutOfCombarParsing);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1480, 559);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Out Of Combat Logs";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // OutOfCombarParsing
            // 
            this.OutOfCombarParsing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OutOfCombarParsing.AutoSize = true;
            this.OutOfCombarParsing.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OutOfCombarParsing.ForeColor = System.Drawing.Color.Red;
            this.OutOfCombarParsing.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OutOfCombarParsing.Location = new System.Drawing.Point(1376, 6);
            this.OutOfCombarParsing.Name = "OutOfCombarParsing";
            this.OutOfCombarParsing.Size = new System.Drawing.Size(98, 17);
            this.OutOfCombarParsing.TabIndex = 3;
            this.OutOfCombarParsing.Text = "Is NOT Parsing";
            this.OutOfCombarParsing.UseVisualStyleBackColor = true;
            this.OutOfCombarParsing.CheckedChanged += new System.EventHandler(this.OutOfCombarParsing_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.EncountersParsing);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1480, 559);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Encounters Logs";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // EncountersParsing
            // 
            this.EncountersParsing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EncountersParsing.AutoSize = true;
            this.EncountersParsing.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EncountersParsing.ForeColor = System.Drawing.Color.Red;
            this.EncountersParsing.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EncountersParsing.Location = new System.Drawing.Point(1376, 6);
            this.EncountersParsing.Name = "EncountersParsing";
            this.EncountersParsing.Size = new System.Drawing.Size(98, 17);
            this.EncountersParsing.TabIndex = 4;
            this.EncountersParsing.Text = "Is NOT Parsing";
            this.EncountersParsing.UseVisualStyleBackColor = true;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(360, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(950, 20);
            this.textBox2.TabIndex = 5;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(351, 550);
            this.treeView1.TabIndex = 6;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(360, 29);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(950, 524);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "Out Of Combat Logs go There";
            this.richTextBox1.WordWrap = false;
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
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
