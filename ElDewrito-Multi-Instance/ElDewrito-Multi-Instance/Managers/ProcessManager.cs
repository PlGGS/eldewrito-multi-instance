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

        /// <summary>
        /// Creates a new shortcut of a selected program. In this case we use it to create Halo Online shortcuts that don't need to be run by the default launcher.
        /// </summary>
        /// <param name="shortcutName"></param>
        /// <param name="shortcutPath"></param>
        /// <param name="shortcutTargetFileLocation"></param>
        /// <param name="shortcutArguments"></param>
        /// <param name="shortcutStartInDirectory"></param>
        /// <param name="shortcutIconLocation"></param>
        /// <param name="shortcutDescription"></param>
        public static void CreateShortcut(string shortcutName, string shortcutPath, string shortcutTargetFileLocation, string shortcutArguments, string shortcutStartInDirectory, string shortcutIconLocation, string shortcutDescription)
        {

            string shortcutLocation = System.IO.Path.Combine(shortcutPath, shortcutName + ".lnk");
            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutLocation);

            shortcut.Description = shortcutDescription;
            shortcut.IconLocation = shortcutIconLocation;
            shortcut.TargetPath = shortcutTargetFileLocation;
            shortcut.Arguments = shortcutArguments;
            shortcut.WorkingDirectory = shortcutStartInDirectory;
            shortcut.Save();

        }
    }
}
