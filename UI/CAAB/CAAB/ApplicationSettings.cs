using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CAAB.Properties;

namespace CAAB
{
    public class ApplicationSettings
    {
        public static class Strings
        {
            public const string LastCopy = "LastCopy";
            public const string SourceFolderLocation = "SourceFolderLocation";
            public const string DestinationFolderLocation = "DestinationFolderLocation";
        }

        private static ApplicationSettings _instance;

        private ApplicationSettings() { }

        public static ApplicationSettings Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ApplicationSettings();
                }
                return _instance;
            }
        }


        private DateTime? _lastCopy;
        public DateTime LastCopy
        {
            get
            {
                if (!_lastCopy.HasValue)
                {
                    _lastCopy = Settings.Default[Strings.LastCopy] as DateTime?;
                }
                else
                {
                    return _lastCopy.Value;
                }
                return DateTime.MinValue;
            }
            set
            {
                _lastCopy = value;
                Settings.Default[Strings.LastCopy] = _lastCopy;
            }
        }

        private string _sourceFolderLocation;
        public string SourceFolderLocation
        {
            get
            {
                if (String.IsNullOrEmpty(_sourceFolderLocation))
                {
                    _sourceFolderLocation = Settings.Default[Strings.SourceFolderLocation] as String;
                }
                return _sourceFolderLocation;
            }
            set { 
                _sourceFolderLocation = value;
                Settings.Default[Strings.SourceFolderLocation] = _sourceFolderLocation;
            }
        }

        private string _destinationFolderLocation;
        public string DestinationFolderLocation
        {
            get
            {
                if (String.IsNullOrEmpty(_destinationFolderLocation))
                {
                    _destinationFolderLocation = Settings.Default[Strings.DestinationFolderLocation] as String;
                }
                return _destinationFolderLocation;
            }
            set
            {
                _destinationFolderLocation = value;
                Settings.Default[Strings.DestinationFolderLocation] = _destinationFolderLocation;
            }
        }

        public void SaveSettings()
        {
            Settings.Default.Save();
        }
    }
}
