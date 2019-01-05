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

        string fullscreen;
        string screenResolution;
        string graphicsQuality;
        string antiAliasing;
        string vSync;
        string consoleMode;
        string keyboardControlsP1;

        public string Fullscreen { get => fullscreen; set => fullscreen = value; }
        public string ScreenResolution { get => screenResolution; set => screenResolution = value; }
        public string GraphicsQuality { get => graphicsQuality; set => graphicsQuality = value; }
        public string AntiAliasing { get => antiAliasing; set => antiAliasing = value; }
        public string VSync { get => vSync; set => vSync = value; }
        public string ConsoleMode { get => consoleMode; set => consoleMode = value; }
        public string KeyboardControlsP1 { get => keyboardControlsP1; set => keyboardControlsP1 = value; }

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
        }

        public void WritePreferenceValue(string file, string prefKeyWithoutSpace, string newPrefVal)
        {
            int lineNumToEdit = 2; // Warning: 1-based indexing!
            string destinationFile = file;
            //TODO rename file to tmpFileName

            // Read the old file.
            string[] lines = File.ReadAllLines(file);

            // Read the appropriate line from the file.
            string lineToWrite = null;
            using (StreamReader reader = new StreamReader(file))
            {
                for (int currentLineNum = 1; currentLineNum <= lines.Length; ++currentLineNum)
                {
                    lineToWrite = reader.ReadLine();
                    if (lineToWrite.Contains(prefKeyWithoutSpace))
                    {
                        lineNumToEdit = currentLineNum;
                        break;
                    }
                }
            }

            if (lineToWrite == null)
                throw new InvalidDataException("Line does not exist in " + file);


            // Write the new file over the old file.
            using (StreamWriter writer = new StreamWriter(destinationFile))
            {
                for (int currentLineNum = 1; currentLineNum <= lines.Length; ++currentLineNum)
                {
                    if (currentLineNum == lineNumToEdit)
                    {
                        writer.WriteLine($"{lineToWrite.Substring(0, lineToWrite.IndexOf(' '))} \"{newPrefVal}\"");
                    }
                    else
                    {
                        writer.WriteLine(lines[currentLineNum - 1]);
                    }
                }
            }
        }

        public string ReadPreferenceValue(string file, string prefKeyWithoutSpace)
        {
            using (StreamReader reader = new StreamReader(file))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains(prefKeyWithoutSpace))
                    {
                        return line.Substring(prefKeyWithoutSpace.Length + 1);
                    }
                }
            }

            return null;
        }
    }
}
