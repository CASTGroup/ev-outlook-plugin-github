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

namespace EisenVaultOutlookPlugin.Forms
{
    public partial class FormCreateFolder : Form
    {

        private string FolderName
        {
            get { return txtFolderName.Text; }
            set { txtFolderName.Text = value; }
        }

        public FormFolders ParentForm { get; set; }
        public FormConfig ParentFormConfig { get; set; }
        private string FolderId { get; set; }
        public string NodeId { get; set; }
        public string Error
        {
            get { return txtError.Text; }
            set { txtError.Text = value; }
        }
        public FormCreateFolder()
        {
            InitializeComponent(); imgLoad.Visible = false;
        }
        public bool IsValid()
        {
            bool result = true;
            if (string.IsNullOrEmpty(FolderName) ||
                string.IsNullOrEmpty(NodeId))
            {
                Error = "Riempire tutti i campi e riprovare";
                result = false;
            }           

            return result;

        }
        private async void btnCreate_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                imgLoad.Visible = true;
                btnCreate.Enabled = false;

                Nodes nodes = new Nodes();
                FolderId = await nodes.CreateFolder(NodeId, FolderName);
                if (!string.IsNullOrEmpty(FolderId))
                {
                    if (ParentForm != null)
                    {
                        ParentForm.CreatedFolderId = FolderId;
                        ParentForm.CreatedFolderName = FolderName;
                    }
                    if (ParentFormConfig != null)
                    {
                        ParentFormConfig.CreatedFolderId = FolderId;
                        ParentFormConfig.CreatedFolderName = FolderName;
                    }
                    this.Close();
                }
                if (string.IsNullOrEmpty(nodes.Error))
                    Error = "Errore nella creazione della cartella";
                else
                    Error = nodes.Error;
               

                imgLoad.Visible = false;
                btnCreate.Enabled = true;
            }
        }
        private void ReloadSettings()
        {
            Option.Read();
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

        private void FormCreateFolder_Load(object sender, EventArgs e)
        {
            ReloadSettings();
        }
    }
}
