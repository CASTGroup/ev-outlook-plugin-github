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
using EisenVaultOutlookPlugin.Data.Entity;
using EisenVaultOutlookPlugin.Helper;
using EisenVaultOutlookPlugin.Properties;

namespace EisenVaultOutlookPlugin.Forms
{
    public partial class FormFolders : Form
    {
        public Microsoft.Office.Interop.Outlook.MailItem EmailItem = null;
        public bool ShowLogin { get; set; }

        public string Username
        {
            get { return txtLoggedName.Text; }
            set { txtLoggedName.Text = value; }
        }
        public string CreatedFolderId { get; set; }
        public string CreatedFolderName { get; set; }
        private string DefaultFolderName
        {
            get { return txtDefaultFolderName.Text; }
            set { txtDefaultFolderName.Text = value; }
        }
        private string DefaultFolderTag { get; set; }
        private string LastUsedFolder
        {
            get { return txtLasUsedFolder.Text; }
            set { txtLasUsedFolder.Text = value; }
        }
        private string LastUsedFolderTag { get; set; }
        private string LabelTitle
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }
        public FormFolders()
        {
            InitializeComponent();
            imgLoad.Visible = false;

            var info = Option.GetUserInfo();
            Username = $"Logged in as {info?.UserName}";
        }

        private async void FormFolders_Load(object sender, EventArgs e)
        {
            ReloadSettings();

            Nodes nodes = new Nodes();
            imgLoad.Visible = true;
            btnUploadSelectedFolder.Enabled = false;
            var list = await nodes.Get();
            List<string> acceptFolders = new List<string>()
            {
                "shared","sites","user homes"
            };
            foreach (NodeEntry entry in list.Where(c=> acceptFolders.Any(x=> x.Contains(c.name.ToLower()))))
            {
                if (entry.isFolder)
                {
                    var node = treeViewNodes.Nodes.Add(entry.id, entry.name);                    
                    node.Tag = new NodeTag()
                    {
                      Id  = entry.id,
                      IsFolder = entry.isFolder,
                      IsLoaded = false
                    };
                }
            }
            imgLoad.Visible = false;
            btnUploadSelectedFolder.Enabled = true;
        }
       

        private async void treeViewNodes_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode tNode = e.Node;
            bool isSiteNode = tNode?.Parent == null && tNode?.Text?.ToLower() == "sites";
            bool isSiteChild = tNode?.Parent != null && tNode?.Parent?.Text?.ToLower() == "sites";


            var tagInfo = e.Node.Tag as NodeTag;
            if (tagInfo !=null &&
                tagInfo.IsFolder &&
                tagInfo.IsLoaded==false
                )
            {
                Nodes nodes = new Nodes();
                imgLoad.Visible = true;
                btnUploadSelectedFolder.Enabled = false;
                var list =await nodes.Get(tagInfo.Id);                
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
                btnUploadSelectedFolder.Enabled = true;              
            }
            if (isSiteNode || isSiteChild)
            {
                if (tNode.Nodes.Count > 0)
                {
                    treeViewNodes.SelectedNode = tNode.Nodes[0];
                }
            }

        }


        class NodeTag
        {
            public bool IsLoaded { get; set; }
            public string Id { get; set; }
            public bool IsFolder { get; set; }
        }

        private async void btnUpload_Click(object sender, EventArgs e)
        {
            TreeNode node = treeViewNodes?.SelectedNode;            
            NodeTag tag = node?.Tag as NodeTag;            
            if (tag != null)
            {
                imgLoad.Visible = true; btnUploadSelectedFolder.Enabled = false;
                Controller controller= new Controller();
                int? folderCount =  node?.Nodes?.Count;
                bool isUploaded = await controller.UploadEmail(EmailItem, tag.Id, folderCount);
                if (isUploaded)
                {
                    Option.Read();
                    DirectorySettings dirSettings = Option.GetDirectorySettings();
                    LastUsedFolder = node.FullPath;
                    LastUsedFolderTag = tag.Id;
                    dirSettings.LastUsedFolder = LastUsedFolder;
                    dirSettings.LastUsedFolderTag = LastUsedFolderTag;
                    Option.SaveDirectorySettings(dirSettings);

                    MessageBox.Show("File(s) uploaded successfully");
                    this.Close();
                }
                else
                {
                    if (string.IsNullOrEmpty(controller.Error))
                        MessageBox.Show("Error while uploading file, Please try again!!");
                    else
                        MessageBox.Show(controller.Error);
                }
            }
            imgLoad.Visible = false ; btnUploadSelectedFolder.Enabled = true;

        }

        private void lnkLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Globals.ThisAddIn.TempUserInfo = Option.GetUserInfo();
            Option.Clear();
            ShowLogin = true;
            this.Hide();
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
                    ParentForm = this
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

        private void btnConfig_Click(object sender, EventArgs e)
        {
            FormConfig frm = new FormConfig();
            frm.ShowDialog(ThisAddIn.OwnerWindow);

            ReloadSettings();


            //Option.Read();
            //DirectorySettings dirSettings = Option.GetDirectorySettings();
            //if (dirSettings != null)
            //{
            //    DefaultFolderName = dirSettings.DefaultFolder;
            //    DefaultFolderTag = dirSettings.DefaultFolderTag;

            //    txtDefaultFolderName.Text = DefaultFolderName;
            //}
            
        }

        private async void btnUploadDefaultFolder_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrWhiteSpace(DefaultFolderTag))
            {
                imgLoad.Visible = true;
                btnUploadDefaultFolder.Enabled = false;

                Controller controller = new Controller();
                bool isUploaded = await controller.UploadEmail(EmailItem, DefaultFolderTag, 0);

                if (isUploaded)
                {
                    Option.Read();
                    DirectorySettings dirSettings = Option.GetDirectorySettings();
                    LastUsedFolder = DefaultFolderName;
                    LastUsedFolderTag = DefaultFolderTag;
                    dirSettings.LastUsedFolder = LastUsedFolder;
                    dirSettings.LastUsedFolderTag = LastUsedFolderTag;
                    Option.SaveDirectorySettings(dirSettings);

                    MessageBox.Show("File(s) uploaded successfully");
                    this.Close();
                }
                else
                {
                    if (string.IsNullOrEmpty(controller.Error))
                        MessageBox.Show("Error while uploading file, Please try again!!");
                    else
                        MessageBox.Show(controller.Error);
                }

                imgLoad.Visible = false;
                btnUploadDefaultFolder.Enabled = true;
            }
        }
        private async void btnUploadLastFolder_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(LastUsedFolderTag))
            {
                imgLoad.Visible = true;
                btnUploadDefaultFolder.Enabled = false;

                Controller controller = new Controller();
                bool isUploaded = await controller.UploadEmail(EmailItem, LastUsedFolderTag, 0);

                if (isUploaded)
                {
                    //Option.Read();
                    //DirectorySettings dirSettings = Option.GetDirectorySettings();
                    //LastUsedFolder = DefaultFolderName;
                    //LastUsedFolderTag = DefaultFolderTag;
                    //dirSettings.LastUsedFolder = LastUsedFolder;
                    //dirSettings.LastUsedFolderTag = LastUsedFolderTag;
                    //Option.SaveDirectorySettings(dirSettings);

                    MessageBox.Show("File(s) uploaded successfully");
                    this.Close();
                }
                else
                {
                    if (string.IsNullOrEmpty(controller.Error))
                        MessageBox.Show("Error while uploading file, Please try again!!");
                    else
                        MessageBox.Show(controller.Error);
                }

                imgLoad.Visible = false;
                btnUploadDefaultFolder.Enabled = true;
            }
        }

        private void ReloadSettings()
        {
            Option.Read();

            LabelSettings labelSettings = Option.GetLabelSettings();
            if (labelSettings != null)
            {
                if (labelSettings.Title != null)
                {
                    LabelTitle = labelSettings.Title;
                }
            }

            ActionSettings actionSettings = Option.GetActionSettings();
            if (actionSettings != null)
            {
                btnUploadSelectedFolder.Visible = !actionSettings.DisableStandardSave;
                btnUploadDefaultFolder.Visible = !actionSettings.DisableDefaultdSave;
                btnUploadLastFolder.Visible = !actionSettings.DisableLastSave;
                pnltxtDefaultFolder.Visible = !actionSettings.DisableDefaultdSave;
                pnltxtLastFolder.Visible = !actionSettings.DisableLastSave;
            }

           
            DirectorySettings dirSettings = Option.GetDirectorySettings();
            if (dirSettings != null)
            {
                DefaultFolderTag = dirSettings.DefaultFolderTag;
                DefaultFolderName = dirSettings.DefaultFolder;

                if (!String.IsNullOrWhiteSpace(DefaultFolderTag))
                {
                    btnUploadDefaultFolder.Enabled = true;
                    
                }
                else
                {
                    btnUploadDefaultFolder.Enabled = false;
                }

                LastUsedFolder = dirSettings.LastUsedFolder;
                LastUsedFolderTag = dirSettings.LastUsedFolderTag;

                if (!String.IsNullOrWhiteSpace(LastUsedFolderTag))
                {
                    btnUploadLastFolder.Enabled = true;
                    
                }
                else
                {
                    btnUploadLastFolder.Enabled = false;
                }
            }


            ImageSettings imageSettings = Option.GetimageSettings();
            if (imageSettings != null)
            {
                if (!String.IsNullOrWhiteSpace(imageSettings.HeadImage))
                {
                    pictureBoxHeadImage.ImageLocation = imageSettings.HeadImage;
                }
                else
                {
                    pictureBoxHeadImage.Image = Properties.Resources.logoalfrescosmall;
                }
                try
                {
                    if (!String.IsNullOrWhiteSpace(imageSettings.Icon))
                    {
                        this.Icon = new Icon(imageSettings.Icon);
                    }
                }
                catch (Exception ex)
                {
                   
                }
                
            }
        }
    }
}
