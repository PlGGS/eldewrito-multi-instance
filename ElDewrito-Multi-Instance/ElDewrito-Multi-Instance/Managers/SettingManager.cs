using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElDewrito_Multi_Instance
{
    public class SettingManager
    {
        string executableDirectoryPath;

        public string Fullscreen { get; set; }
        public string ScreenResolution { get; set; }
        public string GraphicsQuality { get; set; }
        public string AntiAliasing { get; set; }
        public string VSync { get; set; }
        public string ConsoleMode { get; set; }
        public string KeyboardControlsP1 { get; set; }
        public string ServerIP { get; set; }

        public SettingManager(string executableDirectoryPath)
        {
            this.executableDirectoryPath = executableDirectoryPath;

            InitializeSettings();
        }

        public void InitializeSettings()
        {
            Fullscreen = Properties.Settings.Default.Fullscreen;
            ScreenResolution = Properties.Settings.Default.ScreenResolution;
            GraphicsQuality = Properties.Settings.Default.GraphicsQuality;
            AntiAliasing = Properties.Settings.Default.AntiAliasing;
            VSync = Properties.Settings.Default.VSync;
            ConsoleMode = Properties.Settings.Default.ConsoleMode;
            KeyboardControlsP1 = Properties.Settings.Default.KeyboardControlsP1;
            ServerIP = "";
        }
    }
}
