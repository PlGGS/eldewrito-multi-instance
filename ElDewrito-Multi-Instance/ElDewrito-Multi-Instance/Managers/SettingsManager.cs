using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElDewrito_Multi_Instance
{
    public class SettingsManager
    {
        string executableDirectoryPath;

        public SettingsManager(string executableDirectoryPath)
        {
            this.executableDirectoryPath = executableDirectoryPath;

            InitializeSettings();
        }

        public void InitializeSettings()
        {
            //TODO set settings fields to Properties.Settings.____
        }
    }
}
