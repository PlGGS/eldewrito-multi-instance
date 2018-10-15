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
        SettingsManager settingsManager;

        public string CurrentDir = Path.GetDirectoryName(Application.ExecutablePath);
        public List<int> Instances { get; set; } = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
        public List<string> Profiles { get; set; } = new List<string>();

        public ProfilesManager()
        {
            InitializeProfiles();
        }

        private void InitializeProfiles()
        {
            //TODO fill profilesManager.Profiles with profiles based off of all dewrito_prefs files in dir
            //TODO fill cbxProfile with profiles from profilesManager.Profiles
            /*foreach (File prefsFile in ProfilesManager.PrefsFiles)
            {
                
            }
            */

            //load option values for cbxProfile[0]
            if (Profiles.Count > 0)
            {
                settingsManager.InitializeAllSettings(Profiles[0]);
            }
            else
            {
                //messagebox for loading a new copy of main dewrito_prefs file with _[profileName] at the end
            }
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

        public void GetProfileFromFile(string profileName = "")
        {
            if (File.Exists($"{CurrentDir}\\dewrito_prefs_{profileName}.cfg"))
            {

            }
        }
    }
}
