using IWshRuntimeLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ElDewrito_Multi_Instance
{
    public class ProcessManager
    {
        string executableDirectoryPath;
        ProfileManager profileManager;
        SettingManager settingManager;

        public string Configuration { get; }

        public ProcessManager(string executableDirectoryPath, ProfileManager profileManager, SettingManager settingManager)
        {
            this.executableDirectoryPath = executableDirectoryPath;
            this.profileManager = profileManager;
            this.settingManager = settingManager;
            Configuration = $"{executableDirectoryPath}\\emi.cfg";
        }

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
            using (StreamReader r  = new StreamReader(Configuration))
            {
                for (int i = 0; i < System.IO.File.ReadLines(Configuration).Count(); i++)
                {
                    Process.Start($"{executableDirectoryPath}\\eldorado.exe", $"-instance {r.ReadLine()}");
                }
            }
        }
    }
}
