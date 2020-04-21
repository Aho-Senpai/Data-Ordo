using Advanced_Combat_Tracker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;

namespace DataOrdo
{
    public class MainPlugin : IActPluginV1
    {
        public void InitPlugin(TabPage pluginScreenSpace, Label pluginStatusText)
        {
            LoadSettings();
        }

        public void DeInitPlugin()
        {
            SaveSettings();
        }

        private void LoadSettings()
        {

        }

        private void SaveSettings()
        {

        }
    }
}