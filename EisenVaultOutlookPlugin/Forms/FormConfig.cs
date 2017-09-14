using EisenVaultOutlookPlugin.Data.Entity;
using EisenVaultOutlookPlugin.Data.Modul;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EisenVaultOutlookPlugin.Forms
{
    public partial class FormConfig : Form
    {
        public string CreatedFolderId { get; set; }
        public string CreatedFolderName { get; set; }
        private string DefaultFolderTag
        {
            get { return txtDefaultFolderTag.Text; }
            set { txtDefaultFolderTag.Text = value; }
        }
        private string DefaultFolderName
        {
            get { return txtDefaultFolderName.Text; }
            set { txtDefaultFolderName.Text = value; }
        }
        private string LabelLoginExampleInstanceUrl
        {
            get { return txtLabelLoginExampleInstanceUrl.Text; }
            set { txtLabelLoginExampleInstanceUrl.Text = value; }
        }
        private string LabelTitle
        {
            get { return txtTitle.Text; }
            set { txtTitle.Text = value; }
        }
        private string currentlogo = null;
        private string currentImage = null;
        private string currentIcon = null;

        private string FolderId { get; set; }
        public string NodeId { get; set; }

        public FormConfig()
        {
            InitializeComponent();
            imgLoad.Visible = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            TreeNode node = treeViewNodes?.SelectedNode;
            bool isSiteNode = node?.Parent == null && node?.Text?.ToLower() == "sites";
            bool isSiteChild = node?.Parent != null && node?.Parent?.Text?.ToLower() == "sites";

            if (isSiteNode || isSiteChild)
                return;

            CreatedFolderId = "";
            if (node != null)
            {
                FormCreateFolder frm = new FormCreateFolder()
                {
                    NodeId = (node.Tag as NodeTag).Id,
                    ParentFormConfig = this
                };
                frm.ShowDialog(ThisAddIn.OwnerWindow);
                if (string.IsNullOrEmpty(CreatedFolderId) == false)
                {
                    node = node.Nodes.Add(CreatedFolderId, CreatedFolderName);
                    node.Tag = new NodeTag()
                    {
                        Id = CreatedFolderId,
                        IsFolder = true,
                        IsLoaded = false
                    };
                    treeViewNodes.SelectedNode = node;
                    node.TreeView.Focus();
                }

            }
        }

        private async void treeViewNodes_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode tNode = e.Node;
            bool isSiteNode = tNode?.Parent == null && tNode?.Text?.ToLower() == "sites";
            bool isSiteChild = tNode?.Parent != null && tNode?.Parent?.Text?.ToLower() == "sites";


            var tagInfo = e.Node.Tag as NodeTag;
            if (tagInfo != null &&
                tagInfo.IsFolder &&
                tagInfo.IsLoaded == false
                )
            {
                Nodes nodes = new Nodes();
                imgLoad.Visible = true;
                //btnUpload.Enabled = false;
                var list = await nodes.Get(tagInfo.Id);
                foreach (NodeEntry entry in list)
                {
                    if (isSiteChild && entry.name.ToLower() != "documentlibrary")
                    {
                        continue;
                    }
                    e.Node.ImageIndex = e.Node.StateImageIndex = e.Node.SelectedImageIndex = 1;

                    if (entry.isFolder)
                    {
                        var node = e.Node.Nodes.Add(entry.id, entry.name);
                        node.Tag = new NodeTag()
                        {
                            Id = entry.id,
                            IsFolder = entry.isFolder,
                            IsLoaded = false
                        };
                    }
                }
                e.Node.Expand();
                tagInfo.IsLoaded = true;

                imgLoad.Visible = false;
                //btnUpload.Enabled = true;
            }
            if (isSiteNode || isSiteChild)
            {
                if (tNode.Nodes.Count > 0)
                {
                    treeViewNodes.SelectedNode = tNode.Nodes[0];
                }
            }

        }

        private async void FormConfig_Load(object sender, EventArgs e)
        {
            
            Nodes nodes = new Nodes();
            imgLoad.Visible = true;
            //btnUpload.Enabled = false;
            var list = await nodes.Get();
            //List<string> acceptFolders = new List<string>()
            //{
            //    "shared","sites","user homes"
            //};

            foreach (NodeEntry entry in list)
            {
                if (entry.isFolder)
                {
                    var node = treeViewNodes.Nodes.Add(entry.id, entry.name);
                    node.Tag = new NodeTag()
                    {
                        Id = entry.id,
                        IsFolder = entry.isFolder,
                        IsLoaded = false
                    };
                }
            }

            //foreach (NodeEntry entry in list.Where(c => acceptFolders.Any(x => x.Contains(c.name.ToLower()))))
            //{
            //    if (entry.isFolder)
            //    {
            //        var node = treeViewNodes.Nodes.Add(entry.id, entry.name);
            //        node.Tag = new NodeTag()
            //        {
            //            Id = entry.id,
            //            IsFolder = entry.isFolder,
            //            IsLoaded = false
            //        };
            //    }
            //}
            imgLoad.Visible = false;
            //btnUpload.Enabled = true;


            ReloadSettings();
        }

        private void btnSelectDefaultFolder_Click(object sender, EventArgs e)
        {
            Option.Read();

            
            DirectorySettings dirSettings = Option.GetDirectorySettings();

            string lastUsedFolderName = String.Empty;
            string lastUsedFolderTag = String.Empty;

            if (dirSettings != null)
            {
                if (!String.IsNullOrWhiteSpace(dirSettings.LastUsedFolder) && !String.IsNullOrWhiteSpace(dirSettings.LastUsedFolderTag))
                {
                    lastUsedFolderName = dirSettings.LastUsedFolder;
                    lastUsedFolderTag = dirSettings.LastUsedFolderTag;
                }
            }
            TreeNode node = treeViewNodes?.SelectedNode;
            NodeTag tag = node?.Tag as NodeTag;
            if (tag != null && tag.IsFolder)
            {
                DefaultFolderName = node.FullPath;
                DefaultFolderTag = tag.Id;
                DirectorySettings settings = new DirectorySettings();
                settings.DefaultFolder = DefaultFolderName;
                settings.DefaultFolderTag = DefaultFolderTag;
                if (!String.IsNullOrWhiteSpace(lastUsedFolderName) && !String.IsNullOrWhiteSpace(lastUsedFolderTag))
                {
                    settings.LastUsedFolder = lastUsedFolderName;
                    settings.LastUsedFolderTag = lastUsedFolderTag;
                }

                Option.SaveDirectorySettings(settings);

                MessageBox.Show("Default folder changed", "settings", MessageBoxButtons.OK);
            }
        }

        private void btnSaveLabelSettings_Click(object sender, EventArgs e)
        {

            LabelSettings labelSettings = new LabelSettings();
            labelSettings.LoginExampleInstanceUrl = txtLabelLoginExampleInstanceUrl.Text;
            labelSettings.Title = txtTitle.Text;

            Option.SaveLabelSettings(labelSettings);

            MessageBox.Show("Label settings changed", "settings", MessageBoxButtons.OK);
        }

        private void btnSelectImageLogo_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialogImage.ShowDialog();

            if (result == DialogResult.OK) // Test result.
            {
                currentlogo = openFileDialogImage.FileName;
                pictureBoxLogoConfig.Load(currentlogo);
            }

           
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialogImage.ShowDialog();

            if (result == DialogResult.OK) // Test result.
            {
                currentImage = openFileDialogImage.FileName;
                pictureBoxImageConfig.Load(currentImage);
            }
        }

        private void btnSaveImageLogo_Click(object sender, EventArgs e)
        {
            if (currentlogo != null)
            {
                Option.Read();
                ImageSettings imageSettings = Option.GetimageSettings();
                if (imageSettings != null)
                {
                    imageSettings.Logo = currentlogo;
                    imageSettings.Icon = imageSettings.Icon;
                    imageSettings.HeadImage = imageSettings.HeadImage;
                }
                else
                {
                    imageSettings = new ImageSettings();
                    imageSettings.Logo = currentlogo;
                }

                Option.SaveImageSettings(imageSettings);

                ReloadSettings();
            }
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            if (currentImage != null)
            {
                Option.Read();
                ImageSettings imageSettings = Option.GetimageSettings();
                if (imageSettings != null)
                {
                    imageSettings.Logo = imageSettings.Logo;
                    imageSettings.Icon = imageSettings.Icon;
                    imageSettings.HeadImage = currentImage;
                }
                else
                {
                    imageSettings = new ImageSettings();
                    imageSettings.HeadImage = currentImage;
                }

                Option.SaveImageSettings(imageSettings);

                ReloadSettings();
            }
        }

        private void ReloadSettings()
        {
            Option.Read();

            DirectorySettings dirSettings = Option.GetDirectorySettings();
            if (dirSettings != null)
            {
                if (!String.IsNullOrWhiteSpace(dirSettings.DefaultFolderTag) && !String.IsNullOrWhiteSpace(dirSettings.DefaultFolder))
                {
                    DefaultFolderName = dirSettings.DefaultFolder;
                    DefaultFolderTag = dirSettings.DefaultFolderTag;
                }
            }

            LabelSettings labelSettings = Option.GetLabelSettings();
            if (labelSettings != null)
            {
                if (labelSettings.LoginExampleInstanceUrl != null)
                {
                    LabelLoginExampleInstanceUrl = labelSettings.LoginExampleInstanceUrl;                 
                }
                if (labelSettings.Title != null)
                {
                    LabelTitle = labelSettings.Title;
                }
            }

            ActionSettings actionSettings = Option.GetActionSettings();
            if (actionSettings != null)
            {
                chkDisableStandardSaveButton.Checked = actionSettings.DisableStandardSave;
                chkDisableDefaultSaveButton.Checked = actionSettings.DisableDefaultdSave;
                chkDisableLastUsedSaveButton.Checked = actionSettings.DisableLastSave;
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

                    pictureBoxLogoConfig.ImageLocation = imageSettings.Logo;
                    currentlogo = imageSettings.Logo;
                }
                else
                {
                    pictureBoxLogo.Image = Properties.Resources.logoalfresco;
                    pictureBoxLogo.SizeMode = PictureBoxSizeMode.CenterImage;

                    pictureBoxLogoConfig.Image = Properties.Resources.logoalfresco;
                    currentlogo = null;
                }

                if (!String.IsNullOrWhiteSpace(imageSettings.HeadImage))
                {
                    pictureBoxImageConfig.ImageLocation = imageSettings.HeadImage;
                    currentImage = imageSettings.HeadImage;
                }
                else
                {
                    pictureBoxImageConfig.Image = Properties.Resources.logoalfrescosmall;                    
                    currentImage = null;
                }

                if (!String.IsNullOrWhiteSpace(imageSettings.Icon))
                {
                    pictureBoxIconConfig.ImageLocation = imageSettings.Icon;
                    currentIcon = imageSettings.Icon;
                    this.Icon = new Icon(currentIcon);
                }
                else
                {
                    pictureBoxIconConfig.Image = Properties.Resources.alfresco;
                    currentIcon = null;
                    //this.Icon = new Icon("Resources/alfresco.ico");
                }

            }

            
        }

        private void btnSaveActionSettings_Click(object sender, EventArgs e)
        {
            ActionSettings actionSettings = new ActionSettings();
            actionSettings.DisableStandardSave = chkDisableStandardSaveButton.Checked;
            actionSettings.DisableDefaultdSave = chkDisableDefaultSaveButton.Checked;actionSettings.DisableStandardSave = chkDisableStandardSaveButton.Checked;
            actionSettings.DisableLastSave = chkDisableLastUsedSaveButton.Checked;

            Option.SaveActionSettings(actionSettings);

            MessageBox.Show("Action settings changed", "settings", MessageBoxButtons.OK);
        }

        private void btnRestoreImages_Click(object sender, EventArgs e)
        {
            Bitmap logo =  Properties.Resources.logoalfresco;
            Bitmap img = Properties.Resources.logoalfrescosmall;
            Bitmap icon = Properties.Resources.alfresco;

            pictureBoxLogoConfig.Image = logo;
            pictureBoxImageConfig.Image = img;
            pictureBoxIconConfig.Image = icon;

            ImageSettings imageSettings = new ImageSettings();

            imageSettings.Logo = null;
            imageSettings.HeadImage = null;
            imageSettings.Icon = null;

            currentIcon = null;
            currentImage = null;
            currentlogo = null;

            Option.SaveImageSettings(imageSettings);

            MessageBox.Show("Image settings restored", "settings", MessageBoxButtons.OK);

            ReloadSettings();

        }

        private void btnSelectImageIcon_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialogIcon.ShowDialog();

            if (result == DialogResult.OK) 
            {
                currentIcon = openFileDialogIcon.FileName;
                pictureBoxIconConfig.ImageLocation = currentIcon;
            }

            //ReloadSettings();
        }

        private void btnSaveImageIcon_Click(object sender, EventArgs e)
        {
            if (currentIcon != null)
            {
                Option.Read();
                ImageSettings imageSettings = Option.GetimageSettings();
                if (imageSettings != null)
                {
                    imageSettings.Icon = currentIcon;
                    imageSettings.Logo = imageSettings.Logo;
                    imageSettings.HeadImage = imageSettings.HeadImage;
                }
                else
                {
                    imageSettings = new ImageSettings();
                    imageSettings.Icon = currentIcon;
                }

                Option.SaveImageSettings(imageSettings);

                ReloadSettings();
            }
        }
    }

    class NodeTag
    {
        public bool IsLoaded { get; set; }
        public string Id { get; set; }
        public bool IsFolder { get; set; }
    }
}
