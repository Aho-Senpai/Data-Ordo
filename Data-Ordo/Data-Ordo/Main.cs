using System;
// using System.Collections.Generic;
// using System.ComponentModel;
// using System.Drawing;
// using System.Data;
// using System.Text;
using System.Windows.Forms;
using Advanced_Combat_Tracker;
// using System.IO;
using System.Reflection;
// using System.Xml;
// using System.Text.RegularExpressions;

[assembly: AssemblyTitle("Data-Ordo")]
[assembly: AssemblyDescription("A Simple Plugin Try")]
[assembly: AssemblyCompany("Aho Senpai")]
[assembly: AssemblyVersion("0.0.0.1")]

namespace Data_Ordo
{
    public class Main : UserControl, IActPluginV1
    {

        public void InitPlugin(System.Windows.Forms.TabPage pluginScreenSpace, System.Windows.Forms.Label pluginStatusText)
        {
            throw new NotImplementedException();
        }
        public void DeInitPlugin()
        {
            throw new NotImplementedException();
        }
    }
}