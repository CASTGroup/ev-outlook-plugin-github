using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EisenVaultOutlookPlugin.Data.DataBase;
using EisenVaultOutlookPlugin.Data.Entity;

namespace EisenVaultOutlookPlugin.Data.Modul
{
    public class Option
    {
        public static string ServerUrl
        {
            get
            {
                if (Optiondb.UserInfo.Count == 0) return null;
                var item = Optiondb.UserInfo[0];
                return item.Server;
            }
        }

        private static DataSet_Config _optiondb;
        public static DataSet_Config Optiondb
        {
            get
            {
                if (_optiondb == null)
                {
                    _optiondb = new DataSet_Config();
                    //Read();
                }
                return _optiondb;
            }
            set { _optiondb = value; }
        }

        public static string PluginFolder
        {
            get
            {
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\EisenVaultOutlook_plugin\\";
                if (Directory.Exists(folder) == false)
                {
                    Directory.CreateDirectory(folder);
                }
                return folder;
            }
        }
        public static string TempFolder
        {
            get
            {
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\EisenVaultOutlook_plugin\\Temp\\";
                if (Directory.Exists(folder) == false)
                {
                    Directory.CreateDirectory(folder);
                }
                return folder;
            }
        }

        private static string OptionPath
        {
            get
            {
                return PluginFolder + "Plugin-option";
            }
        }
        public static void Read()
        {
            try
            {
                Optiondb = new DataSet_Config();
                if (IsExist())
                {
                    Optiondb.ReadXml(OptionPath, XmlReadMode.IgnoreSchema);
                }
            }
            catch (Exception ex)
            {
                LogClass.WriteException(ex.Message, ex.StackTrace, ex.InnerException == null ? "" : ex.InnerException.Message);
            }
        }
        public static void Save()
        {
            try
            {
                Optiondb.WriteXml(OptionPath, XmlWriteMode.IgnoreSchema);
            }
            catch (Exception ex)
            {
                LogClass.WriteException(ex.Message, ex.StackTrace, ex.InnerException == null ? "" : ex.InnerException.Message);
            }
        }
        public static bool IsExist()
        {
            return File.Exists(OptionPath);
        }
        //public static void SaveUserInfo(string server, string userName, string password, string token, string userId)
        //{

        //    if (Optiondb.UserInfo.Count == 0)
        //    {
        //        Optiondb.UserInfo.AddUserInfoRow(Optiondb.UserInfo.NewUserInfoRow());
        //    }
        //    DataSet_Config.UserInfoRow row = Optiondb.UserInfo[0];
        //    row.Server = server;
        //    row.UserName = userName;
        //    row.Password = password;
        //    row.Token = token;
        //    row.UserId = userId;

        //    Save();
        //}
        public static void SaveUserInfo(Settings settings)
        {

            if (Optiondb.UserInfo.Count == 0)
            {
                Optiondb.UserInfo.AddUserInfoRow(Optiondb.UserInfo.NewUserInfoRow());
            }
            DataSet_Config.UserInfoRow row = Optiondb.UserInfo[0];
            row.Server = settings.Server;
            row.UserName = settings.UserName;
            row.Password = settings.Password;
            row.Token = settings.Token;
            row.UserId = settings.UserId;

            Save();
        }

        public static void SaveLabelSettings(LabelSettings settings)
        {
            if (Optiondb.LabelSettings.Count == 0)
            {
                Optiondb.LabelSettings.AddLabelSettingsRow(Optiondb.LabelSettings.NewLabelSettingsRow());
            }
            DataSet_Config.LabelSettingsRow row = Optiondb.LabelSettings[0];
            row.LoginExampleInstanceUrl = settings.LoginExampleInstanceUrl;
            row.Title = settings.Title;
            
            Save();
        }
        public static void SaveActionSettings(ActionSettings settings)
        {
            if (Optiondb.ActionSettings.Count == 0)
            {
                Optiondb.ActionSettings.AddActionSettingsRow(Optiondb.ActionSettings.NewActionSettingsRow());
            }
            DataSet_Config.ActionSettingsRow row = Optiondb.ActionSettings[0];
            row.DisableStandardSave = settings.DisableStandardSave;
            row.DisableDefaultSave = settings.DisableDefaultdSave;
            row.DisableLastSave = settings.DisableLastSave;

            Save();
        }
        public static void SaveImageSettings(ImageSettings settings)
        {
            if (Optiondb.ImageSettings.Count == 0)
            {
                Optiondb.ImageSettings.AddImageSettingsRow(Optiondb.ImageSettings.NewImageSettingsRow());
            }
            DataSet_Config.ImageSettingsRow row = Optiondb.ImageSettings[0];
            row.Logo = settings.Logo;
            row.HeadImage = settings.HeadImage;
            row.Icon = settings.Icon;

            Save();
        }
        public static void SaveDirectorySettings(DirectorySettings settings)
        {
            if (Optiondb.DirectorySettings.Count == 0)
            {
                Optiondb.DirectorySettings.AddDirectorySettingsRow(Optiondb.DirectorySettings.NewDirectorySettingsRow());
            }
            DataSet_Config.DirectorySettingsRow row = Optiondb.DirectorySettings[0];
            row.DefaultFolder = settings.DefaultFolder;
            row.DefaultFolderTag = settings.DefaultFolderTag;
            row.LastUsedFolder = settings.LastUsedFolder;
            row.LastUsedFolderTag = settings.LastUsedFolderTag;
            Save();
        }
        public static PluginUserInfo GetUserInfo()
        {
            if (Optiondb.UserInfo.Count == 0) return null;
            var item = Optiondb.UserInfo[0];


            return new PluginUserInfo()
            {
                UserName = item.IsUserNameNull() ? null : item.UserName,
                Password = item.IsPasswordNull() ? null : item.Password,
                Server = item.IsServerNull() ? null : item.Server,
                Token = item.IsTokenNull() ? null : item.Token,
                UserId = item.IsUserIdNull() ? null : item.UserId,
            };
        }
        public static DirectorySettings GetDirectorySettings()
        {
            if (Optiondb.DirectorySettings.Count == 0) return null;
            var item = Optiondb.DirectorySettings[0];


            return new DirectorySettings()
            {
                DefaultFolder = item.IsDefaultFolderNull() ? null : item.DefaultFolder,
                DefaultFolderTag = item.IsDefaultFolderTagNull() ? null : item.DefaultFolderTag,
                LastUsedFolder = item.IsLastUsedFolderNull() ? null : item.LastUsedFolder,
                LastUsedFolderTag = item.IsLastUsedFolderTagNull() ? null : item.LastUsedFolderTag
            };
        }
        public static ActionSettings GetActionSettings()
        {
            if (Optiondb.ActionSettings.Count == 0) return null;
            var item = Optiondb.ActionSettings[0];

            return new ActionSettings()
            {
                DisableStandardSave = item.IsDisableStandardSaveNull() ? false : item.DisableStandardSave,
                DisableDefaultdSave = item.IsDisableDefaultSaveNull() ? false : item.DisableDefaultSave,
                DisableLastSave = item.IsDisableLastSaveNull() ? false : item.DisableLastSave
            };
        }
        public static LabelSettings GetLabelSettings()
        {
            if (Optiondb.LabelSettings.Count == 0) return null;
            var item = Optiondb.LabelSettings[0];

            return new LabelSettings()
            {
                LoginExampleInstanceUrl = item.IsLoginExampleInstanceUrlNull() ? null : item.LoginExampleInstanceUrl,
                Title = item.IsTitleNull() ? null : item.Title            
            };
        }
        public static ImageSettings GetimageSettings()
        {
            if (Optiondb.ImageSettings.Count == 0) return null;
            var item = Optiondb.ImageSettings[0];

            return new ImageSettings()
            {
                Logo = item.IsLogoNull() ? null : item.Logo,
                HeadImage = item.IsHeadImageNull() ? null : item.HeadImage,
                Icon = item.IsIconNull() ? null : item.Icon
            };
        }
        public static void Clear()
        {
            Optiondb.UserInfo.Clear();
            Save();
        }

    }
}
