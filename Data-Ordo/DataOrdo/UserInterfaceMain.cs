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
        public UserInterfaceMain()
        {
            this.Dock = DockStyle.Fill;
            InitializeComponent();
        }

        private void OutOfCombarParsing_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked == false)
            {
                OutOfCombarParsing.Text = "Is NOT Parsing";
                OutOfCombarParsing.ForeColor = Color.Red;
            }
            if (cb.Checked == true)
            {
                OutOfCombarParsing.Text = "Is Parsing";
                OutOfCombarParsing.ForeColor = Color.Green;
            }
        }

        private void EncountersParsing_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked == false)
            {
                EncountersParsing.Text = "Is NOT Parsing";
                EncountersParsing.ForeColor = Color.Red;
            }
            if (cb.Checked == true)
            {
                EncountersParsing.Text = "Is Parsing";
                EncountersParsing.ForeColor = Color.Green;
            }
        }
    }
}
