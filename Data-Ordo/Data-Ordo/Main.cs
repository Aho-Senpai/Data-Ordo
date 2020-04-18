using Advanced_Combat_Tracker;
using System;
using System.Windows.Forms;

// using System.Collections.Generic;
// using System.ComponentModel;
// using System.Data;
// using System.Drawing;
// using System.IO;
// using System.Reflection;
// using System.Text;
// using System.Text.RegularExpressions;
// using System.Xml;

[assembly: AssemblyTitle("Data-Ordo")]
[assembly: AssemblyDescription("A Simple Plugin Try")]
[assembly: AssemblyCompany("Aho Senpai")]
[assembly: AssemblyVersion("0.0.0.2")]

namespace Data_Ordo
{
    public class Main : UserControl, IActPluginV1
    {
		public Data_Ordo()
		{
			InitializeComponent();
		}


		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(434, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "This is the user interface that appears as a new tab under the Plugins tab.  [REP" +
				"LACE ME]";
			this.textBox1.Location = new System.Drawing.Point(6, 16);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(431, 20);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "Sample TextBox that has its value stored to the settings file automatically.";
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Name = "PluginSample";
			this.Size = new System.Drawing.Size(686, 384);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		public void InitPlugin(TabPage pluginScreenSpace, Label pluginStatusText)
		{
			lblStatus = pluginStatusText;   // Hand the status label's reference to our local var
			pluginScreenSpace.Controls.Add(this);   // Add this UserControl to the tab ACT provides
			this.Dock = DockStyle.Fill; // Expand the UserControl to fill the tab's client space
			xmlSettings = new SettingsSerializer(this); // Create a new settings serializer and pass it this instance
			LoadSettings();

			ActGlobals.oFormActMain.AfterCombatAction += new CombatActionDelegate(oFormActMain_AfterCombatAction);

			lblStatus.Text = "Plugin Started";
		}
		public void DeInitPlugin()
		{
			// Unsubscribe from any events you listen to when exiting!
			ActGlobals.oFormActMain.AfterCombatAction -= oFormActMain_AfterCombatAction;

			SaveSettings();
			lblStatus.Text = "Plugin Exited";
		}
	}
}