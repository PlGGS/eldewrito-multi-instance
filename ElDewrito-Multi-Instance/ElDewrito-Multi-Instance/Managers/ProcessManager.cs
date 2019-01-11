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
        const int gwlStyle = -16;              //hex constant for style changing
        const int wsBorder = 0x00800000;       //window with border
        const int wsCaption = 0x00C00000;      //window with a title bar
        const int wsSysMenu = 0x00080000;      //window with no borders etc.
        const int wsMinimizeBox = 0x00020000;  //window with minimizebox

        [DllImport("USER32.DLL")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        public static extern IntPtr SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int y, int cx, int cy, int wFlags);

        [DllImport("user32.dll")]
        static extern bool DrawMenuBar(IntPtr hWnd);

        string executableDirectoryPath;
        ProfileManager profileManager;
        SettingManager settingManager;
        Screen[] screens = Screen.AllScreens;
        List<Process> processes = new List<Process>() { };

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

        public void Launch(int numberOfInstances)
        {
            using (StreamReader r  = new StreamReader(Configuration))
            {
                string name = r.ReadLine();

                for (int i = 0; i < System.IO.File.ReadLines(Configuration).Count(); i++)
                {
                    if (i == 0)
                    {
                        if (Convert.ToBoolean(Convert.ToInt32(Properties.Settings.Default.KeyboardControlsP1)))
                        {
                            profileManager.WriteProfileSetting(name, "Settings.Gamepad", "0");
                        }
                        else
                        {
                            profileManager.WriteProfileSetting(name, "Settings.Gamepad", "1");
                        }
                    }
                    else
                    {
                        profileManager.WriteProfileSetting(name, "Settings.Gamepad", "1");
                    }

                    try
                    {
                        profileManager.WriteProfileSetting(name, "Settings.Fullscreen", "0");
                        profileManager.WriteProfileSetting(name, "Settings.VSync", Convert.ToInt32(Convert.ToBoolean(Convert.ToInt32(Properties.Settings.Default.VSync))).ToString());
                        profileManager.WriteProfileSetting(name, "Settings.Antialiasing", Convert.ToInt32(Convert.ToBoolean(Convert.ToInt32(Properties.Settings.Default.AntiAliasing))).ToString());
                    }
                    catch (Exception)
                    {
                        
                    }
                    
                    Process proc = new Process();
                    proc.StartInfo = new ProcessStartInfo($"{executableDirectoryPath}\\eldorado.exe", $"-instance {name} -connect {settingManager.ServerIP}");
                    processes.Add(proc);
                    proc.Start();
                    proc.WaitForInputIdle();

                    if (Convert.ToBoolean(Convert.ToInt32(settingManager.Fullscreen)))
                    {
                        if (i < screens.Length)
                        {
                            try
                            {
                                IntPtr window = proc.MainWindowHandle;
                                SetWindowLong(window, gwlStyle, wsSysMenu);
                                SetWindowPos(window, 0, screens[i].Bounds.X, screens[i].Bounds.Y, screens[i].Bounds.Width, screens[i].Bounds.Height, 0x0040);
                                DrawMenuBar(window);
                            }
                            catch
                            {
                                MessageBox.Show($"Failed to properly place {name}'s fullscreen instance.", "Eldewrito Multi Instance");
                            }
                        }
                        else
                        {
                            try
                            {
                                proc.Kill();
                            }
                            catch (Exception)
                            {

                            }

                            MessageBox.Show($"Cannot place {name}'s instance, as there are not enough available screens", "Eldewrito Multi Instance");
                        }
                    }
                    else
                    {
                        if (Convert.ToBoolean(settingManager.ConsoleMode))
                        {
                            //TODO place instance based off of amount of instances and split screen preference
                        }
                    }
                    
                    Console.WriteLine($"Launched {name}");

                    name = r.ReadLine();
                }
            }
        }

        public void CloseInstances()
        {
            for (int i = 0; i < processes.Count; i++)
            {
                //TODO check whether or not instances are still running
                try
                {
                    processes[i].Kill();
                }
                catch (Exception)
                {

                }
            }

            processes.Clear();
        }
    }
}
