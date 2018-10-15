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
        ProfilesManager profilesManager;

        public SettingsManager(ProfilesManager pProfilesManager)
        {
            profilesManager = pProfilesManager;

            if (profilesManager.Profiles.Count > 0)
            {

            }
        }

        public void InitializeAllSettings(string profileName)
        {
            //TODO 
        }

        public string GetSetting(string profileName, string setting)
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

        public void WriteSetting(string profileName, string setting, string value) //TODO think about changing this to object and then using this method to automatically turn object into string like in the read method
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
    }
}
