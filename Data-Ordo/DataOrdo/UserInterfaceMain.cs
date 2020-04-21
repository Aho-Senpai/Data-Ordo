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
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked == false)
            {
                checkBox1.Text = "Is NOT Parsing";
            }
            if (cb.Checked == true)
            {
                checkBox1.Text = "Is Parsing";

            }
        }
    }
}
