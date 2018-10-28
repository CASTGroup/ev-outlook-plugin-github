using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EisenVaultOutlookPlugin.Data.Modul;
using EisenVaultOutlookPlugin.Data.Entity;
using System.Threading;
using System.Globalization;

namespace EisenVaultOutlookPlugin.Forms
{
    public partial class FormLogin : Form
    {
        public string Username
        {
            get { return txtUsername.Text; }
            set { txtUsername.Text = value; }
        }
        public string Password
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }
        public string Server
        {
            get { return txtServer.Text; }
            set { txtServer.Text = value; }
        }
        public string Error
        {
            get { return txtError.Text; }
            set { txtError.Text = value; }
        }

        public bool IsValid()
        {
            bool result = true;
            if (string.IsNullOrEmpty(Username) ||
                string.IsNullOrEmpty(Password) ||
                string.IsNullOrEmpty(Server)
            )
            {
                Error = UserInterfaceStrings.LoginReFill;
                result = false;
            }

            if (Uri.IsWellFormedUriString(Server, UriKind.RelativeOrAbsolute)==false)
            {
                Error = UserInterfaceStrings.LoginCorrectUrl;
                result = false;
            }

            return result;
        }

        public FormLogin()
        {
            InitializeComponent();
            LocaliseInterface();
            imgLoad.Visible = false;

            ConfigureLocalisationIfRemembered();

            var info = Globals.ThisAddIn.TempUserInfo;
            if (info != null)
            {
                Username = info.UserName;
                Password = info.Password;
                Server = info.Server;
            }
        }

        private const String REG_KEY = "EisenVaultOutlookPlugin";
        private const String LOCAL_REG_KEY = "localisation";

        // copy these into FormConfig.Designer.InitializeComponent if you want locale in designer
        // If you do the localisation in the designer the localisation is then built into the designer; 
        // I prefer satelite resource files because it is easier to verify missing translations
        // https://msdn.microsoft.com/en-us/library/y99d1cd3%28v=vs.85%29.aspx
        private void LocaliseInterface()
        {
            this.label1.Text = UserInterfaceStrings.label1UserName;
            this.label3.Text = UserInterfaceStrings.label3url;
            this.groupBox1.Text = UserInterfaceStrings.groupbox1UserInfo;
        }
		
        private void ConfigureLocalisationIfRemembered()
        {
            try
            { 
                Microsoft.Win32.RegistryKey registryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(REG_KEY);
                if (registryKey != null)
                {
                    String loc = (String)registryKey.GetValue("localisation");
                    if (loc != null)
                    {
                        switch (loc)
                        {
                            case "it":
                                int index = comboBoxAvailableLanguages.FindString("Italian");
                                comboBoxAvailableLanguages.SelectedIndex = index;
                                break;
                            default:
                                comboBoxAvailableLanguages.SelectedIndex = 1;
                                break;
                        }

                        Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(loc);
                    }
                    registryKey.Close();
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                imgLoad.Visible = true;
                btnLogin.Enabled = false;
                if (!Server.EndsWith("/"))
                    Server= Server+"/";
                Account account = new Account();
                if (await account.Loign(Server, Username, Password))
                {
                    Option.Read();
                    Globals.ThisAddIn.TempUserInfo = null;
                    this.Close();
                }
                else
                {
                    if(string.IsNullOrEmpty(account.Error))
                        Error = UserInterfaceStrings.LoginError;
                    else 
                    Error = account.Error;
                }

                imgLoad.Visible = false;
                btnLogin.Enabled = true;
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            ReloadSettings();
        }

        private void ReloadSettings()
        {
            Option.Read();

            LabelSettings labelSettings = Option.GetLabelSettings();
            if (labelSettings != null)
            {
                if (labelSettings.LoginExampleInstanceUrl != null)
                {
                    lblExampleUrl.Text = labelSettings.LoginExampleInstanceUrl;
                }
            }

            ImageSettings imageSettings = Option.GetimageSettings();
            if (imageSettings != null)
            {
                if (!String.IsNullOrWhiteSpace(imageSettings.Logo))
                {
                    System.Drawing.Image img = System.Drawing.Image.FromFile(imageSettings.Logo);
                    if (img.Width > 570 || img.Height > 90)
                    {
                        pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        pictureBoxLogo.SizeMode = PictureBoxSizeMode.CenterImage;
                    }


                    pictureBoxLogo.ImageLocation = imageSettings.Logo;
                }

                if (!String.IsNullOrWhiteSpace(imageSettings.Icon))
                {
                    this.Icon = new Icon(imageSettings.Icon);
                }
                //else
                //{
                //    this.Icon = new Icon("Resources/alfresco.ico");
                //}

            }
        }

        private void comboBoxAvailableLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            String preferredLocale = "en";

            if (comboBoxAvailableLanguages.SelectedItem.ToString() == "Default")
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.InstalledUICulture;
            }
            else if (comboBoxAvailableLanguages.SelectedItem.ToString() == "English")
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en");
            }
            else if (comboBoxAvailableLanguages.SelectedItem.ToString() == "Italian")
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("it");
                preferredLocale = "it";
            }
            LocaliseInterface();

            RememberLocalisation(preferredLocale);
        }

        private static void RememberLocalisation(string preferredLocale)
        {
            try
            {
                Microsoft.Win32.RegistryKey registryKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(REG_KEY);
                if (registryKey != null)
                {
                    registryKey.SetValue(LOCAL_REG_KEY, preferredLocale);
                    registryKey.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
