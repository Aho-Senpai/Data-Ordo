using System;
using System.Windows.Forms;

public class UserInterface
{
	public UserInterfaceMain()
	{
        this.label = new System.Windows.Forms.Label();
        this.checkbox = new System.Windows.Forms.CheckBox();
        this.SuspendLayout();
        // 
        // label
        // 
        this.label.AutoSize = true;
        this.label.Location = new System.Drawing.Point(3, 0);
        this.label.Name = "label";
        this.label.Size = new System.Drawing.Size(434, 13);
        this.label.TabIndex = 0;
        this.label.Text = "This is the user interface that appears as a new tab under the Plugins tab.  [REP" +
"LACE ME]";
        // 
        // checkbox
        // 
        this.checkbox.AutoSize = true;
        this.checkbox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
        this.checkbox.Location = new System.Drawing.Point(583, 0);
        this.checkbox.Name = "checkbox";
        this.checkbox.Size = new System.Drawing.Size(103, 17);
        this.checkbox.TabIndex = 1;
        this.checkbox.Text = "Enablee Parsing";
        // 
        // DataOrdoMain
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.Controls.Add(this.label);
        this.Controls.Add(this.checkbox);
        this.Name = "DataOrdoMain";
        this.Size = new System.Drawing.Size(686, 384);
        this.ResumeLayout(false);
        this.PerformLayout();

    }
    private System.Windows.Forms.Label label;
    private CheckBox checkbox;
    // private System.Windows.Forms.Button button;
}
