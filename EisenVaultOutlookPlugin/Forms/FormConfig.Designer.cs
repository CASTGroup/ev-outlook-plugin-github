namespace EisenVaultOutlookPlugin.Forms
{
    partial class FormConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfig));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabImage = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnSelectImageIcon = new System.Windows.Forms.Button();
            this.pictureBoxIconConfig = new System.Windows.Forms.PictureBox();
            this.btnSaveImageIcon = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBoxImageConfig = new System.Windows.Forms.PictureBox();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxLogoConfig = new System.Windows.Forms.PictureBox();
            this.btnSelectImageLogo = new System.Windows.Forms.Button();
            this.btnSaveImageLogo = new System.Windows.Forms.Button();
            this.btnRestoreImages = new System.Windows.Forms.Button();
            this.tabDefaultFolder = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDefaultFolderName = new System.Windows.Forms.TextBox();
            this.btnSelectDefaultFolder = new System.Windows.Forms.Button();
            this.txtDefaultFolderTag = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.imgLoad = new System.Windows.Forms.PictureBox();
            this.treeViewNodes = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tabLabels = new System.Windows.Forms.TabPage();
            this.btnSaveLabelSettings = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtLabelLoginExampleInstanceUrl = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabActions = new System.Windows.Forms.TabPage();
            this.btnSaveActionSettings = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkDisableLastUsedSaveButton = new System.Windows.Forms.CheckBox();
            this.chkDisableDefaultSaveButton = new System.Windows.Forms.CheckBox();
            this.chkDisableStandardSaveButton = new System.Windows.Forms.CheckBox();
            this.openFileDialogImage = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogIcon = new System.Windows.Forms.OpenFileDialog();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabImage.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconConfig)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageConfig)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoConfig)).BeginInit();
            this.tabDefaultFolder.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoad)).BeginInit();
            this.tabLabels.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabActions.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(16, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 429);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configurazione";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabImage);
            this.tabControl1.Controls.Add(this.tabDefaultFolder);
            this.tabControl1.Controls.Add(this.tabLabels);
            this.tabControl1.Controls.Add(this.tabActions);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(558, 410);
            this.tabControl1.TabIndex = 0;
            // 
            // tabImage
            // 
            this.tabImage.Controls.Add(this.groupBox6);
            this.tabImage.Controls.Add(this.groupBox5);
            this.tabImage.Controls.Add(this.groupBox4);
            this.tabImage.Controls.Add(this.btnRestoreImages);
            this.tabImage.Location = new System.Drawing.Point(4, 22);
            this.tabImage.Name = "tabImage";
            this.tabImage.Padding = new System.Windows.Forms.Padding(3);
            this.tabImage.Size = new System.Drawing.Size(550, 384);
            this.tabImage.TabIndex = 0;
            this.tabImage.Text = "Immagini";
            this.tabImage.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnSelectImageIcon);
            this.groupBox6.Controls.Add(this.pictureBoxIconConfig);
            this.groupBox6.Controls.Add(this.btnSaveImageIcon);
            this.groupBox6.Location = new System.Drawing.Point(6, 197);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(538, 77);
            this.groupBox6.TabIndex = 34;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Icona";
            // 
            // btnSelectImageIcon
            // 
            this.btnSelectImageIcon.BackColor = System.Drawing.Color.Coral;
            this.btnSelectImageIcon.FlatAppearance.BorderSize = 0;
            this.btnSelectImageIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectImageIcon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSelectImageIcon.Location = new System.Drawing.Point(356, 43);
            this.btnSelectImageIcon.Name = "btnSelectImageIcon";
            this.btnSelectImageIcon.Size = new System.Drawing.Size(85, 23);
            this.btnSelectImageIcon.TabIndex = 30;
            this.btnSelectImageIcon.Text = "Seleziona";
            this.btnSelectImageIcon.UseVisualStyleBackColor = false;
            this.btnSelectImageIcon.Click += new System.EventHandler(this.btnSelectImageIcon_Click);
            // 
            // pictureBoxIconConfig
            // 
            this.pictureBoxIconConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxIconConfig.Image = global::EisenVaultOutlookPlugin.Properties.Resources.alfresco;
            this.pictureBoxIconConfig.InitialImage = null;
            this.pictureBoxIconConfig.Location = new System.Drawing.Point(160, 43);
            this.pictureBoxIconConfig.Name = "pictureBoxIconConfig";
            this.pictureBoxIconConfig.Size = new System.Drawing.Size(25, 23);
            this.pictureBoxIconConfig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIconConfig.TabIndex = 28;
            this.pictureBoxIconConfig.TabStop = false;
            // 
            // btnSaveImageIcon
            // 
            this.btnSaveImageIcon.BackColor = System.Drawing.Color.Coral;
            this.btnSaveImageIcon.FlatAppearance.BorderSize = 0;
            this.btnSaveImageIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveImageIcon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveImageIcon.Location = new System.Drawing.Point(447, 43);
            this.btnSaveImageIcon.Name = "btnSaveImageIcon";
            this.btnSaveImageIcon.Size = new System.Drawing.Size(85, 23);
            this.btnSaveImageIcon.TabIndex = 31;
            this.btnSaveImageIcon.Text = "Salva";
            this.btnSaveImageIcon.UseVisualStyleBackColor = false;
            this.btnSaveImageIcon.Click += new System.EventHandler(this.btnSaveImageIcon_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.pictureBoxImageConfig);
            this.groupBox5.Controls.Add(this.btnSelectImage);
            this.groupBox5.Controls.Add(this.btnSaveImage);
            this.groupBox5.Location = new System.Drawing.Point(6, 111);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(538, 80);
            this.groupBox5.TabIndex = 33;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Immagine";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(347, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Dimensione raccomandata: 50 x 50";
            // 
            // pictureBoxImageConfig
            // 
            this.pictureBoxImageConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImageConfig.Image = global::EisenVaultOutlookPlugin.Properties.Resources.logoalfrescosmall;
            this.pictureBoxImageConfig.InitialImage = null;
            this.pictureBoxImageConfig.Location = new System.Drawing.Point(145, 19);
            this.pictureBoxImageConfig.Name = "pictureBoxImageConfig";
            this.pictureBoxImageConfig.Size = new System.Drawing.Size(54, 52);
            this.pictureBoxImageConfig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImageConfig.TabIndex = 22;
            this.pictureBoxImageConfig.TabStop = false;
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.BackColor = System.Drawing.Color.Coral;
            this.btnSelectImage.FlatAppearance.BorderSize = 0;
            this.btnSelectImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectImage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSelectImage.Location = new System.Drawing.Point(356, 48);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(85, 23);
            this.btnSelectImage.TabIndex = 25;
            this.btnSelectImage.Text = "Seleziona";
            this.btnSelectImage.UseVisualStyleBackColor = false;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.BackColor = System.Drawing.Color.Coral;
            this.btnSaveImage.FlatAppearance.BorderSize = 0;
            this.btnSaveImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveImage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveImage.Location = new System.Drawing.Point(447, 48);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(85, 23);
            this.btnSaveImage.TabIndex = 26;
            this.btnSaveImage.Text = "Salva";
            this.btnSaveImage.UseVisualStyleBackColor = false;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.pictureBoxLogoConfig);
            this.groupBox4.Controls.Add(this.btnSelectImageLogo);
            this.groupBox4.Controls.Add(this.btnSaveImageLogo);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(538, 100);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Logo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Dimensione raccomandata: 560 x 81";
            // 
            // pictureBoxLogoConfig
            // 
            this.pictureBoxLogoConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLogoConfig.Image = global::EisenVaultOutlookPlugin.Properties.Resources.logoalfresco;
            this.pictureBoxLogoConfig.InitialImage = null;
            this.pictureBoxLogoConfig.Location = new System.Drawing.Point(78, 19);
            this.pictureBoxLogoConfig.Name = "pictureBoxLogoConfig";
            this.pictureBoxLogoConfig.Size = new System.Drawing.Size(204, 62);
            this.pictureBoxLogoConfig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogoConfig.TabIndex = 0;
            this.pictureBoxLogoConfig.TabStop = false;
            // 
            // btnSelectImageLogo
            // 
            this.btnSelectImageLogo.BackColor = System.Drawing.Color.Coral;
            this.btnSelectImageLogo.FlatAppearance.BorderSize = 0;
            this.btnSelectImageLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectImageLogo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSelectImageLogo.Location = new System.Drawing.Point(356, 71);
            this.btnSelectImageLogo.Name = "btnSelectImageLogo";
            this.btnSelectImageLogo.Size = new System.Drawing.Size(85, 23);
            this.btnSelectImageLogo.TabIndex = 20;
            this.btnSelectImageLogo.Text = "Seleziona";
            this.btnSelectImageLogo.UseVisualStyleBackColor = false;
            this.btnSelectImageLogo.Click += new System.EventHandler(this.btnSelectImageLogo_Click);
            // 
            // btnSaveImageLogo
            // 
            this.btnSaveImageLogo.BackColor = System.Drawing.Color.Coral;
            this.btnSaveImageLogo.FlatAppearance.BorderSize = 0;
            this.btnSaveImageLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveImageLogo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveImageLogo.Location = new System.Drawing.Point(447, 71);
            this.btnSaveImageLogo.Name = "btnSaveImageLogo";
            this.btnSaveImageLogo.Size = new System.Drawing.Size(85, 23);
            this.btnSaveImageLogo.TabIndex = 21;
            this.btnSaveImageLogo.Text = "Salva";
            this.btnSaveImageLogo.UseVisualStyleBackColor = false;
            this.btnSaveImageLogo.Click += new System.EventHandler(this.btnSaveImageLogo_Click);
            // 
            // btnRestoreImages
            // 
            this.btnRestoreImages.BackColor = System.Drawing.Color.Coral;
            this.btnRestoreImages.FlatAppearance.BorderSize = 0;
            this.btnRestoreImages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestoreImages.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRestoreImages.Location = new System.Drawing.Point(362, 347);
            this.btnRestoreImages.Name = "btnRestoreImages";
            this.btnRestoreImages.Size = new System.Drawing.Size(182, 31);
            this.btnRestoreImages.TabIndex = 27;
            this.btnRestoreImages.Text = "Ripristina Immagini di Default";
            this.btnRestoreImages.UseVisualStyleBackColor = false;
            this.btnRestoreImages.Click += new System.EventHandler(this.btnRestoreImages_Click);
            // 
            // tabDefaultFolder
            // 
            this.tabDefaultFolder.Controls.Add(this.panel1);
            this.tabDefaultFolder.Location = new System.Drawing.Point(4, 22);
            this.tabDefaultFolder.Name = "tabDefaultFolder";
            this.tabDefaultFolder.Padding = new System.Windows.Forms.Padding(3);
            this.tabDefaultFolder.Size = new System.Drawing.Size(550, 384);
            this.tabDefaultFolder.TabIndex = 1;
            this.tabDefaultFolder.Text = "Cartella di Default";
            this.tabDefaultFolder.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDefaultFolderName);
            this.panel1.Controls.Add(this.btnSelectDefaultFolder);
            this.panel1.Controls.Add(this.txtDefaultFolderTag);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.imgLoad);
            this.panel1.Controls.Add(this.treeViewNodes);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 378);
            this.panel1.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Nome del nodo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tag del nodo";
            // 
            // txtDefaultFolderName
            // 
            this.txtDefaultFolderName.BackColor = System.Drawing.SystemColors.Control;
            this.txtDefaultFolderName.Location = new System.Drawing.Point(6, 96);
            this.txtDefaultFolderName.Name = "txtDefaultFolderName";
            this.txtDefaultFolderName.ReadOnly = true;
            this.txtDefaultFolderName.Size = new System.Drawing.Size(371, 20);
            this.txtDefaultFolderName.TabIndex = 23;
            // 
            // btnSelectDefaultFolder
            // 
            this.btnSelectDefaultFolder.BackColor = System.Drawing.Color.Coral;
            this.btnSelectDefaultFolder.FlatAppearance.BorderSize = 0;
            this.btnSelectDefaultFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectDefaultFolder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSelectDefaultFolder.Location = new System.Drawing.Point(399, 344);
            this.btnSelectDefaultFolder.Name = "btnSelectDefaultFolder";
            this.btnSelectDefaultFolder.Size = new System.Drawing.Size(142, 31);
            this.btnSelectDefaultFolder.TabIndex = 22;
            this.btnSelectDefaultFolder.Text = "Salva Cartella di default";
            this.btnSelectDefaultFolder.UseVisualStyleBackColor = false;
            this.btnSelectDefaultFolder.Click += new System.EventHandler(this.btnSelectDefaultFolder_Click);
            // 
            // txtDefaultFolderTag
            // 
            this.txtDefaultFolderTag.BackColor = System.Drawing.SystemColors.Control;
            this.txtDefaultFolderTag.Location = new System.Drawing.Point(6, 54);
            this.txtDefaultFolderTag.Name = "txtDefaultFolderTag";
            this.txtDefaultFolderTag.ReadOnly = true;
            this.txtDefaultFolderTag.Size = new System.Drawing.Size(371, 20);
            this.txtDefaultFolderTag.TabIndex = 21;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Coral;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreate.Location = new System.Drawing.Point(456, 93);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(85, 23);
            this.btnCreate.TabIndex = 19;
            this.btnCreate.Text = "Crea Cartella";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // imgLoad
            // 
            this.imgLoad.Image = global::EisenVaultOutlookPlugin.Properties.Resources.loading;
            this.imgLoad.Location = new System.Drawing.Point(386, 91);
            this.imgLoad.Name = "imgLoad";
            this.imgLoad.Size = new System.Drawing.Size(49, 27);
            this.imgLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLoad.TabIndex = 20;
            this.imgLoad.TabStop = false;
            // 
            // treeViewNodes
            // 
            this.treeViewNodes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeViewNodes.ImageIndex = 0;
            this.treeViewNodes.ImageList = this.imageList1;
            this.treeViewNodes.Location = new System.Drawing.Point(6, 122);
            this.treeViewNodes.Name = "treeViewNodes";
            this.treeViewNodes.SelectedImageIndex = 0;
            this.treeViewNodes.ShowLines = false;
            this.treeViewNodes.Size = new System.Drawing.Size(535, 202);
            this.treeViewNodes.TabIndex = 13;
            this.treeViewNodes.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewNodes_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Close-Folder-icon.png");
            this.imageList1.Images.SetKeyName(1, "Opened-Folder-icon.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cartella di Default";
            // 
            // tabLabels
            // 
            this.tabLabels.Controls.Add(this.btnSaveLabelSettings);
            this.tabLabels.Controls.Add(this.groupBox2);
            this.tabLabels.Location = new System.Drawing.Point(4, 22);
            this.tabLabels.Name = "tabLabels";
            this.tabLabels.Padding = new System.Windows.Forms.Padding(3);
            this.tabLabels.Size = new System.Drawing.Size(550, 384);
            this.tabLabels.TabIndex = 2;
            this.tabLabels.Text = "Testi";
            this.tabLabels.UseVisualStyleBackColor = true;
            // 
            // btnSaveLabelSettings
            // 
            this.btnSaveLabelSettings.BackColor = System.Drawing.Color.Coral;
            this.btnSaveLabelSettings.FlatAppearance.BorderSize = 0;
            this.btnSaveLabelSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveLabelSettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveLabelSettings.Location = new System.Drawing.Point(429, 347);
            this.btnSaveLabelSettings.Name = "btnSaveLabelSettings";
            this.btnSaveLabelSettings.Size = new System.Drawing.Size(115, 31);
            this.btnSaveLabelSettings.TabIndex = 23;
            this.btnSaveLabelSettings.Text = "Save Label settings";
            this.btnSaveLabelSettings.UseVisualStyleBackColor = false;
            this.btnSaveLabelSettings.Click += new System.EventHandler(this.btnSaveLabelSettings_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTitle);
            this.groupBox2.Controls.Add(this.txtLabelLoginExampleInstanceUrl);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(3, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(541, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configurazione testi";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(122, 21);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(266, 20);
            this.txtTitle.TabIndex = 3;
            this.txtTitle.Text = "Select Folder";
            // 
            // txtLabelLoginExampleInstanceUrl
            // 
            this.txtLabelLoginExampleInstanceUrl.Location = new System.Drawing.Point(122, 47);
            this.txtLabelLoginExampleInstanceUrl.Name = "txtLabelLoginExampleInstanceUrl";
            this.txtLabelLoginExampleInstanceUrl.Size = new System.Drawing.Size(266, 20);
            this.txtLabelLoginExampleInstanceUrl.TabIndex = 1;
            this.txtLabelLoginExampleInstanceUrl.Text = "(Example: http://srvalfresco:8080)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Titolo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Indirizzo di esempio";
            // 
            // tabActions
            // 
            this.tabActions.Controls.Add(this.btnSaveActionSettings);
            this.tabActions.Controls.Add(this.groupBox3);
            this.tabActions.Location = new System.Drawing.Point(4, 22);
            this.tabActions.Name = "tabActions";
            this.tabActions.Padding = new System.Windows.Forms.Padding(3);
            this.tabActions.Size = new System.Drawing.Size(550, 384);
            this.tabActions.TabIndex = 3;
            this.tabActions.Text = "Azioni";
            this.tabActions.UseVisualStyleBackColor = true;
            // 
            // btnSaveActionSettings
            // 
            this.btnSaveActionSettings.BackColor = System.Drawing.Color.Coral;
            this.btnSaveActionSettings.FlatAppearance.BorderSize = 0;
            this.btnSaveActionSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveActionSettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveActionSettings.Location = new System.Drawing.Point(429, 347);
            this.btnSaveActionSettings.Name = "btnSaveActionSettings";
            this.btnSaveActionSettings.Size = new System.Drawing.Size(115, 31);
            this.btnSaveActionSettings.TabIndex = 24;
            this.btnSaveActionSettings.Text = "Save Action settings";
            this.btnSaveActionSettings.UseVisualStyleBackColor = false;
            this.btnSaveActionSettings.Click += new System.EventHandler(this.btnSaveActionSettings_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkDisableLastUsedSaveButton);
            this.groupBox3.Controls.Add(this.chkDisableDefaultSaveButton);
            this.groupBox3.Controls.Add(this.chkDisableStandardSaveButton);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(538, 124);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Abilita / Disabilita bottoni";
            // 
            // chkDisableLastUsedSaveButton
            // 
            this.chkDisableLastUsedSaveButton.AutoSize = true;
            this.chkDisableLastUsedSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDisableLastUsedSaveButton.Location = new System.Drawing.Point(22, 74);
            this.chkDisableLastUsedSaveButton.Name = "chkDisableLastUsedSaveButton";
            this.chkDisableLastUsedSaveButton.Size = new System.Drawing.Size(416, 21);
            this.chkDisableLastUsedSaveButton.TabIndex = 3;
            this.chkDisableLastUsedSaveButton.Text = "Disabilita bottone di salvataggio \"ULTIMA CARTELLA USATA\"";
            this.chkDisableLastUsedSaveButton.UseVisualStyleBackColor = true;
            // 
            // chkDisableDefaultSaveButton
            // 
            this.chkDisableDefaultSaveButton.AutoSize = true;
            this.chkDisableDefaultSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDisableDefaultSaveButton.Location = new System.Drawing.Point(22, 51);
            this.chkDisableDefaultSaveButton.Name = "chkDisableDefaultSaveButton";
            this.chkDisableDefaultSaveButton.Size = new System.Drawing.Size(396, 21);
            this.chkDisableDefaultSaveButton.TabIndex = 2;
            this.chkDisableDefaultSaveButton.Text = "Disabilita bottone di salvataggio \"CARTELLA DI DEFAULT\"";
            this.chkDisableDefaultSaveButton.UseVisualStyleBackColor = true;
            // 
            // chkDisableStandardSaveButton
            // 
            this.chkDisableStandardSaveButton.AutoSize = true;
            this.chkDisableStandardSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDisableStandardSaveButton.Location = new System.Drawing.Point(22, 28);
            this.chkDisableStandardSaveButton.Name = "chkDisableStandardSaveButton";
            this.chkDisableStandardSaveButton.Size = new System.Drawing.Size(317, 21);
            this.chkDisableStandardSaveButton.TabIndex = 1;
            this.chkDisableStandardSaveButton.Text = "Disabilita bottone di salvataggio \"STANDARD\"";
            this.chkDisableStandardSaveButton.UseVisualStyleBackColor = true;
            // 
            // openFileDialogImage
            // 
            this.openFileDialogImage.FileName = "image.png";
            this.openFileDialogImage.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            // 
            // openFileDialogIcon
            // 
            this.openFileDialogIcon.FileName = "Icon.ico";
            this.openFileDialogIcon.Filter = "Icon Files|*.ico;";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::EisenVaultOutlookPlugin.Properties.Resources.logoalfresco;
            this.pictureBoxLogo.Location = new System.Drawing.Point(16, 16);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(560, 81);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLogo.TabIndex = 21;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(593, 544);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxLogo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurazione";
            this.Load += new System.EventHandler(this.FormConfig_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabImage.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconConfig)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageConfig)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoConfig)).EndInit();
            this.tabDefaultFolder.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoad)).EndInit();
            this.tabLabels.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabActions.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabImage;
        private System.Windows.Forms.TabPage tabDefaultFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeViewNodes;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.PictureBox imgLoad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDefaultFolderTag;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnSelectDefaultFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDefaultFolderName;
        private System.Windows.Forms.TabPage tabLabels;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtLabelLoginExampleInstanceUrl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSaveLabelSettings;
        private System.Windows.Forms.Button btnSaveImageLogo;
        private System.Windows.Forms.Button btnSelectImageLogo;
        private System.Windows.Forms.PictureBox pictureBoxLogoConfig;
        private System.Windows.Forms.OpenFileDialog openFileDialogImage;
        private System.Windows.Forms.PictureBox pictureBoxImageConfig;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabActions;
        private System.Windows.Forms.Button btnSaveActionSettings;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkDisableLastUsedSaveButton;
        private System.Windows.Forms.CheckBox chkDisableDefaultSaveButton;
        private System.Windows.Forms.CheckBox chkDisableStandardSaveButton;
        private System.Windows.Forms.Button btnRestoreImages;
        private System.Windows.Forms.Button btnSaveImageIcon;
        private System.Windows.Forms.Button btnSelectImageIcon;
        private System.Windows.Forms.PictureBox pictureBoxIconConfig;
        private System.Windows.Forms.OpenFileDialog openFileDialogIcon;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}