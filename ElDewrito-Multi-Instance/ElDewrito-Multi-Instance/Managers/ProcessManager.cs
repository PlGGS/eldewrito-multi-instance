using IWshRuntimeLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ElDewrito_Multi_Instance
{
    class ProcessManager
    {
        string executableDirectoryPath;
        ProfilesManager profilesManager;
        SettingsManager settingsManager;

        public ProcessManager(string executableDirectoryPath, ProfilesManager profilesManager, SettingsManager settingsManager)
        {
            this.executableDirectoryPath = executableDirectoryPath;
            this.profilesManager = profilesManager;
            this.settingsManager = settingsManager;
        }

        public List<int> Processes { get; set; } = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

        /// <summary>
        /// Checks if a process is running... Duh...
        /// </summary>
        /// <param name="nameSubstring"></param>
        /// <returns></returns>
        public static bool checkIfProcessIsRunning(string nameSubstring)
        {
            return Process.GetProcesses().Any(p => p.ProcessName.Contains(nameSubstring));
        }

        public void Launch(sbyte numberOfInstances)
        {

        }
    }
}
