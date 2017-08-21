namespace EisenVaultOutlookPlugin.Forms
{
    partial class FormFolders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFolders));
            this.label1 = new System.Windows.Forms.Label();
            this.treeViewNodes = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnUploadSelectedFolder = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lnkLogOut = new System.Windows.Forms.LinkLabel();
            this.txtLoggedName = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnUploadDefaultFolder = new System.Windows.Forms.Button();
            this.btnUploadLastFolder = new System.Windows.Forms.Button();
            this.txtDefaultFolderName = new System.Windows.Forms.TextBox();
            this.txtLasUsedFolder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.imgLoad = new System.Windows.Forms.PictureBox();
            this.pictureBoxHeadImage = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnltxtDefaultFolder = new System.Windows.Forms.Panel();
            this.pnltxtLastFolder = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeadImage)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnltxtDefaultFolder.SuspendLayout();
            this.pnltxtLastFolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.label1.Location = new System.Drawing.Point(77, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Browse Repositories and Select a Folder to Save Email In";
            // 
            // treeViewNodes
            // 
            this.treeViewNodes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeViewNodes.ImageIndex = 0;
            this.treeViewNodes.ImageList = this.imageList1;
            this.treeViewNodes.Location = new System.Drawing.Point(21, 102);
            this.treeViewNodes.Name = "treeViewNodes";
            this.treeViewNodes.SelectedImageIndex = 0;
            this.treeViewNodes.ShowLines = false;
            this.treeViewNodes.Size = new System.Drawing.Size(480, 321);
            this.treeViewNodes.TabIndex = 12;
            this.treeViewNodes.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewNodes_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Close-Folder-icon.png");
            this.imageList1.Images.SetKeyName(1, "Opened-Folder-icon.png");
            // 
            // btnUploadSelectedFolder
            // 
            this.btnUploadSelectedFolder.BackColor = System.Drawing.Color.Coral;
            this.btnUploadSelectedFolder.Enabled = false;
            this.btnUploadSelectedFolder.FlatAppearance.BorderSize = 0;
            this.btnUploadSelectedFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadSelectedFolder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUploadSelectedFolder.Location = new System.Drawing.Point(3, 78);
            this.btnUploadSelectedFolder.Name = "btnUploadSelectedFolder";
            this.btnUploadSelectedFolder.Size = new System.Drawing.Size(155, 40);
            this.btnUploadSelectedFolder.TabIndex = 13;
            this.btnUploadSelectedFolder.Text = "Save to Selected Folder";
            this.btnUploadSelectedFolder.UseVisualStyleBackColor = false;
            this.btnUploadSelectedFolder.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(77, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(116, 20);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Select Folder";
            // 
            // lnkLogOut
            // 
            this.lnkLogOut.AutoSize = true;
            this.lnkLogOut.Location = new System.Drawing.Point(455, 8);
            this.lnkLogOut.Name = "lnkLogOut";
            this.lnkLogOut.Size = new System.Drawing.Size(46, 13);
            this.lnkLogOut.TabIndex = 16;
            this.lnkLogOut.TabStop = true;
            this.lnkLogOut.Text = "(Logout)";
            this.lnkLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLogOut_LinkClicked);
            // 
            // txtLoggedName
            // 
            this.txtLoggedName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLoggedName.ForeColor = System.Drawing.Color.Red;
            this.txtLoggedName.Location = new System.Drawing.Point(261, 3);
            this.txtLoggedName.Name = "txtLoggedName";
            this.txtLoggedName.Size = new System.Drawing.Size(190, 23);
            this.txtLoggedName.TabIndex = 17;
            this.txtLoggedName.Text = "Logged in as ";
            this.txtLoggedName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Coral;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreate.Location = new System.Drawing.Point(413, 75);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(88, 23);
            this.btnCreate.TabIndex = 18;
            this.btnCreate.Text = "Create Folder";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.Coral;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfig.Location = new System.Drawing.Point(21, 75);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(85, 23);
            this.btnConfig.TabIndex = 19;
            this.btnConfig.Text = "Settings";
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnUploadDefaultFolder
            // 
            this.btnUploadDefaultFolder.BackColor = System.Drawing.Color.Coral;
            this.btnUploadDefaultFolder.Enabled = false;
            this.btnUploadDefaultFolder.FlatAppearance.BorderSize = 0;
            this.btnUploadDefaultFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadDefaultFolder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUploadDefaultFolder.Location = new System.Drawing.Point(164, 78);
            this.btnUploadDefaultFolder.Name = "btnUploadDefaultFolder";
            this.btnUploadDefaultFolder.Size = new System.Drawing.Size(155, 40);
            this.btnUploadDefaultFolder.TabIndex = 20;
            this.btnUploadDefaultFolder.Text = "Save to Default Folder";
            this.btnUploadDefaultFolder.UseVisualStyleBackColor = false;
            this.btnUploadDefaultFolder.Click += new System.EventHandler(this.btnUploadDefaultFolder_Click);
            // 
            // btnUploadLastFolder
            // 
            this.btnUploadLastFolder.BackColor = System.Drawing.Color.Coral;
            this.btnUploadLastFolder.Enabled = false;
            this.btnUploadLastFolder.FlatAppearance.BorderSize = 0;
            this.btnUploadLastFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadLastFolder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUploadLastFolder.Location = new System.Drawing.Point(325, 78);
            this.btnUploadLastFolder.Name = "btnUploadLastFolder";
            this.btnUploadLastFolder.Size = new System.Drawing.Size(155, 40);
            this.btnUploadLastFolder.TabIndex = 21;
            this.btnUploadLastFolder.Text = "Save to Last Used Folder";
            this.btnUploadLastFolder.UseVisualStyleBackColor = false;
            this.btnUploadLastFolder.Click += new System.EventHandler(this.btnUploadLastFolder_Click);
            // 
            // txtDefaultFolderName
            // 
            this.txtDefaultFolderName.BackColor = System.Drawing.SystemColors.Control;
            this.txtDefaultFolderName.Location = new System.Drawing.Point(2, 3);
            this.txtDefaultFolderName.Name = "txtDefaultFolderName";
            this.txtDefaultFolderName.ReadOnly = true;
            this.txtDefaultFolderName.Size = new System.Drawing.Size(358, 20);
            this.txtDefaultFolderName.TabIndex = 24;
            // 
            // txtLasUsedFolder
            // 
            this.txtLasUsedFolder.BackColor = System.Drawing.SystemColors.Control;
            this.txtLasUsedFolder.Location = new System.Drawing.Point(2, 6);
            this.txtLasUsedFolder.Name = "txtLasUsedFolder";
            this.txtLasUsedFolder.ReadOnly = true;
            this.txtLasUsedFolder.Size = new System.Drawing.Size(358, 20);
            this.txtLasUsedFolder.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Default Folder";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Last Used Folder";
            // 
            // imgLoad
            // 
            this.imgLoad.Image = global::EisenVaultOutlookPlugin.Properties.Resources.loading;
            this.imgLoad.Location = new System.Drawing.Point(455, 30);
            this.imgLoad.Name = "imgLoad";
            this.imgLoad.Size = new System.Drawing.Size(45, 37);
            this.imgLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLoad.TabIndex = 15;
            this.imgLoad.TabStop = false;
            // 
            // pictureBoxHeadImage
            // 
            this.pictureBoxHeadImage.Image = global::EisenVaultOutlookPlugin.Properties.Resources.logoalfrescosmall;
            this.pictureBoxHeadImage.Location = new System.Drawing.Point(21, 13);
            this.pictureBoxHeadImage.Name = "pictureBoxHeadImage";
            this.pictureBoxHeadImage.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxHeadImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHeadImage.TabIndex = 10;
            this.pictureBoxHeadImage.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pnltxtDefaultFolder);
            this.flowLayoutPanel1.Controls.Add(this.pnltxtLastFolder);
            this.flowLayoutPanel1.Controls.Add(this.btnUploadSelectedFolder);
            this.flowLayoutPanel1.Controls.Add(this.btnUploadDefaultFolder);
            this.flowLayoutPanel1.Controls.Add(this.btnUploadLastFolder);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(21, 439);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(484, 125);
            this.flowLayoutPanel1.TabIndex = 28;
            // 
            // pnltxtDefaultFolder
            // 
            this.pnltxtDefaultFolder.Controls.Add(this.txtDefaultFolderName);
            this.pnltxtDefaultFolder.Controls.Add(this.label3);
            this.pnltxtDefaultFolder.Location = new System.Drawing.Point(3, 8);
            this.pnltxtDefaultFolder.Name = "pnltxtDefaultFolder";
            this.pnltxtDefaultFolder.Size = new System.Drawing.Size(475, 27);
            this.pnltxtDefaultFolder.TabIndex = 29;
            // 
            // pnltxtLastFolder
            // 
            this.pnltxtLastFolder.Controls.Add(this.txtLasUsedFolder);
            this.pnltxtLastFolder.Controls.Add(this.label4);
            this.pnltxtLastFolder.Location = new System.Drawing.Point(3, 41);
            this.pnltxtLastFolder.Name = "pnltxtLastFolder";
            this.pnltxtLastFolder.Size = new System.Drawing.Size(475, 31);
            this.pnltxtLastFolder.TabIndex = 28;
            // 
            // FormFolders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(517, 571);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtLoggedName);
            this.Controls.Add(this.lnkLogOut);
            this.Controls.Add(this.imgLoad);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.treeViewNodes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxHeadImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFolders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Folders";
            this.Load += new System.EventHandler(this.FormFolders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeadImage)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnltxtDefaultFolder.ResumeLayout(false);
            this.pnltxtDefaultFolder.PerformLayout();
            this.pnltxtLastFolder.ResumeLayout(false);
            this.pnltxtLastFolder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxHeadImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeViewNodes;
        private System.Windows.Forms.Button btnUploadSelectedFolder;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox imgLoad;
        private System.Windows.Forms.LinkLabel lnkLogOut;
        private System.Windows.Forms.Label txtLoggedName;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnUploadDefaultFolder;
        private System.Windows.Forms.Button btnUploadLastFolder;
        private System.Windows.Forms.TextBox txtDefaultFolderName;
        private System.Windows.Forms.TextBox txtLasUsedFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnltxtDefaultFolder;
        private System.Windows.Forms.Panel pnltxtLastFolder;
    }
}