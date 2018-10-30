using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElDewrito_Multi_Instance
{
    public class ProfilesManager
    {
        string executableDirectoryPath;
        SettingsManager settingsManager;
        public CheckedListBox clbProfiles;
        
        public Dictionary<string, string> Profiles { get; set; } = new Dictionary<string, string>();

        public ProfilesManager(string executableDirectoryPath, SettingsManager settingsManager, CheckedListBox clbProfiles)
        {
            this.executableDirectoryPath = executableDirectoryPath;
            this.settingsManager = settingsManager;
            this.clbProfiles = clbProfiles;

            InitializeProfiles();
            InitializeClbProfiles();
        }

        private void InitializeProfiles()
        {
            Profiles = new Dictionary<string, string>();
            List<string> configFilesWithPath = Directory.GetFiles(executableDirectoryPath, "*.cfg", SearchOption.TopDirectoryOnly).OfType<string>().ToList();
            List<string> configFiles = new List<string>();
            for (int i = 0; i < configFilesWithPath.Count; i++)
            {
                configFiles.Add(configFilesWithPath[i].Substring(configFilesWithPath[i].LastIndexOf('\\') + 1));
            }

            if (configFilesWithPath.Count == 0)
            {
                MessageBox.Show("Please launch Eldewrito at least once before using Eldewrito Multi Instance!", "Eldewrito Multi Instance");
                //TODO figure out why configFiles is empty and then after it's not do: Environment.Exit(0);
            }

            settingsManager.WritePreferenceValue(configFiles[configFiles.IndexOf("dewrito_prefs.cfg")], "Player.Name", "Blake");
            string playerName = settingsManager.ReadPreferenceValue(configFiles[configFiles.IndexOf("dewrito_prefs.cfg")], "Player.Name");

            //check if _username_in_file.cfg is in the list of files
            if (!configFiles.Contains($"dewrito_prefs_{playerName.Substring(1, playerName.Length - 2)}.cfg"))
            {
                File.Copy(configFilesWithPath[configFiles.IndexOf("dewrito_prefs.cfg")], $"{executableDirectoryPath}dewrito_prefs_{playerName.Substring(1, playerName.Length - 2)}.cfg");
                configFiles.Add($"dewrito_prefs_{playerName.Substring(1, playerName.Length - 2)}.cfg");
            }

            foreach (string file in configFiles)
            {
                if (file.Substring(file.LastIndexOf('\\') + 1) != "dewrito_prefs.cfg")
                {
                    string profileName = file.Substring(file.LastIndexOf('\\') + 15, file.Substring(file.LastIndexOf('\\') + 15).Length - 4);

                    Profiles.Add(profileName, file);
                }
            }

            foreach (var entry in Profiles)
                Console.WriteLine("[{0} {1}]", entry.Key, entry.Value);
        }

        private void InitializeClbProfiles()
        {
            clbProfiles.Items.Clear();

            for (int i = 0; i < Profiles.Count; i++)
            {
                clbProfiles.Items.Add(Profiles.Keys.ToList()[i]);
            }

            //TODO loop through clbProfiles and add profile names
        }

        public void ReloadProfiles()
        {
            InitializeProfiles();
            InitializeClbProfiles();
        }

        public string ReadProfileSetting(string profileName, string setting)
        {
            string sourcePrefsFile = "dewrito_prefs_" + profileName + ".cfg";
            string value = null;

            //Read the appropriate line to get value from the file
            using (StreamReader reader = new StreamReader(sourcePrefsFile))
            {
                for (int i = 1; i <= File.ReadLines(sourcePrefsFile).Count(); i++)
                {
                    string tmp = reader.ReadLine();

                    //If line.ToLower() contains value string then set value variable equal to the file's setting's value
                    if (tmp.ToLower().Contains(setting.ToLower()))
                    {
                        value = tmp.Substring(tmp.IndexOf('\"') + 1, tmp.Length - 2); //TODO make sure this returns value without any "s
                    }
                }
            }

            return value;
        }
        public void WriteProfileSetting(string profileName, string setting, string value) //TODO think about changing this to object and then using this method to automatically turn object into string like in the read method
        {
            int writeLineNum = -1; //Lines start at 1
            string sourcePrefsFile = $"dewrito_prefs_{profileName}.cfg";
            string destinationPrefsFile = $"dewrito_prefs_{profileName}.cfg";
            string tempPrefsFile = $"dewrito_prefs_{profileName}_tmp.cfg";

            //Read the appropriate line from the file
            string lineToWrite = null;
            using (StreamReader reader = new StreamReader(sourcePrefsFile))
            {
                for (int i = 1; i <= File.ReadLines(sourcePrefsFile).Count(); i++)
                {
                    string tmp = reader.ReadLine();

                    //If line.ToLower() contains setting string then set writeLineNum
                    if (tmp.ToLower().Contains(setting.ToLower()))
                    {
                        writeLineNum = i;
                        lineToWrite = tmp;
                    }
                }
            }

            int currentLineNum = 1;
            string line = null;
            if (writeLineNum != -1)
            {
                //TODO see if this changes lineToWrite's setting to value
                lineToWrite = lineToWrite.Substring(0, lineToWrite.IndexOf(' ') + 1) + value;
                using (StreamReader reader = new StreamReader(sourcePrefsFile))
                {
                    using (StreamWriter writer = new StreamWriter(tempPrefsFile))
                    {
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (currentLineNum == writeLineNum)
                            {
                                writer.WriteLine(lineToWrite);
                            }
                            else
                            {
                                writer.WriteLine(line);
                            }
                            currentLineNum++;
                        }
                    }
                }
            }
            else
            {
                //show messagebox saying couldnt find setting to change
                MessageBox.Show($"Failed to locate the setting: {setting} in {sourcePrefsFile}");
            }

            if (profileName.Substring(profileName.Length - 2).ToLower() == "s")
            {
                Console.WriteLine($"Wrote {profileName}' {value} to {setting} at line {line}");
            }
            else
            {
                Console.WriteLine($"Wrote {profileName}'s {value} to {setting} at line {line}");
            }
        }

        public void AddProfile()
        {

        }

        public void RemoveProfile()
        {

        }

        public bool ProfileHasFile(string profile)
        {
            return true;
        }

        bool ProfilesHaveFiles()
        {
            return true;
        }

        public void GetProfilesFromFiles()
        {
            /*foreach (File prefsFile in )
            {

            }*/
        }
    }
}
