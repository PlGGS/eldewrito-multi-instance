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
