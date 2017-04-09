namespace StudentInfoSystem
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlNav = new System.Windows.Forms.Panel();
            this.lblLoginName = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.picBoxUserImage = new System.Windows.Forms.PictureBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnOverview = new System.Windows.Forms.Button();
            this.tabStudents = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listView = new System.Windows.Forms.ListView();
            this.lstID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstDOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstContact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstAdmissionDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tabOverview = new System.Windows.Forms.TabPage();
            this.tabCtrlContent = new System.Windows.Forms.TabControl();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.lblSettingsUsrImageSupportText = new System.Windows.Forms.Label();
            this.lblSettingsUserImage = new System.Windows.Forms.Label();
            this.btnSettingsBrowseImage = new System.Windows.Forms.Button();
            this.btnSettingsSave = new System.Windows.Forms.Button();
            this.txtSettingsName = new System.Windows.Forms.TextBox();
            this.lblSettingsName = new System.Windows.Forms.Label();
            this.picBoxSettingsUserImage = new System.Windows.Forms.PictureBox();
            this.pnlNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUserImage)).BeginInit();
            this.tabStudents.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabCtrlContent.SuspendLayout();
            this.tabSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSettingsUserImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNav
            // 
            this.pnlNav.AutoSize = true;
            this.pnlNav.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.pnlNav.Controls.Add(this.lblLoginName);
            this.pnlNav.Controls.Add(this.btnLogout);
            this.pnlNav.Controls.Add(this.picBoxUserImage);
            this.pnlNav.Controls.Add(this.btnSettings);
            this.pnlNav.Controls.Add(this.btnStudents);
            this.pnlNav.Controls.Add(this.btnOverview);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNav.ForeColor = System.Drawing.Color.White;
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(251, 647);
            this.pnlNav.TabIndex = 0;
            // 
            // lblLoginName
            // 
            this.lblLoginName.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginName.ForeColor = System.Drawing.Color.White;
            this.lblLoginName.Location = new System.Drawing.Point(31, 172);
            this.lblLoginName.Name = "lblLoginName";
            this.lblLoginName.Size = new System.Drawing.Size(186, 59);
            this.lblLoginName.TabIndex = 4;
            this.lblLoginName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(61)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(2, 447);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(246, 51);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "           Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // picBoxUserImage
            // 
            this.picBoxUserImage.Location = new System.Drawing.Point(72, 61);
            this.picBoxUserImage.Name = "picBoxUserImage";
            this.picBoxUserImage.Size = new System.Drawing.Size(100, 100);
            this.picBoxUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxUserImage.TabIndex = 3;
            this.picBoxUserImage.TabStop = false;
            // 
            // btnSettings
            // 
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(61)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 351);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(246, 51);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "           Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudents.FlatAppearance.BorderSize = 0;
            this.btnStudents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(61)))));
            this.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudents.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudents.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStudents.Image = ((System.Drawing.Image)(resources.GetObject("btnStudents.Image")));
            this.btnStudents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudents.Location = new System.Drawing.Point(0, 297);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(246, 51);
            this.btnStudents.TabIndex = 1;
            this.btnStudents.Text = "           Students";
            this.btnStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnOverview
            // 
            this.btnOverview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOverview.FlatAppearance.BorderSize = 0;
            this.btnOverview.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(61)))));
            this.btnOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOverview.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOverview.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOverview.Image = ((System.Drawing.Image)(resources.GetObject("btnOverview.Image")));
            this.btnOverview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOverview.Location = new System.Drawing.Point(0, 243);
            this.btnOverview.Name = "btnOverview";
            this.btnOverview.Size = new System.Drawing.Size(246, 51);
            this.btnOverview.TabIndex = 0;
            this.btnOverview.Text = "           Overview";
            this.btnOverview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOverview.UseVisualStyleBackColor = true;
            this.btnOverview.Visible = false;
            this.btnOverview.Click += new System.EventHandler(this.btnOverview_Click);
            // 
            // tabStudents
            // 
            this.tabStudents.AutoScroll = true;
            this.tabStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.tabStudents.Controls.Add(this.panel3);
            this.tabStudents.Controls.Add(this.panel2);
            this.tabStudents.Location = new System.Drawing.Point(4, 20);
            this.tabStudents.Margin = new System.Windows.Forms.Padding(0);
            this.tabStudents.Name = "tabStudents";
            this.tabStudents.Size = new System.Drawing.Size(968, 623);
            this.tabStudents.TabIndex = 0;
            this.tabStudents.Text = "Students";
            // 
            // panel3
            // 
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Controls.Add(this.listView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 127);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(968, 496);
            this.panel3.TabIndex = 1;
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lstID,
            this.lstName,
            this.lstAddress,
            this.lstDOB,
            this.lstContact,
            this.lstAdmissionDate});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(968, 496);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // lstID
            // 
            this.lstID.Text = "ID";
            this.lstID.Width = 45;
            // 
            // lstName
            // 
            this.lstName.Text = "Name";
            this.lstName.Width = 209;
            // 
            // lstAddress
            // 
            this.lstAddress.Text = "Address";
            this.lstAddress.Width = 164;
            // 
            // lstDOB
            // 
            this.lstDOB.Text = "Date of Birth";
            this.lstDOB.Width = 160;
            // 
            // lstContact
            // 
            this.lstContact.Text = "Contact Number";
            this.lstContact.Width = 181;
            // 
            // lstAdmissionDate
            // 
            this.lstAdmissionDate.Text = "Admission Date";
            this.lstAdmissionDate.Width = 185;
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.lblUsername);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(968, 127);
            this.panel2.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(23, 57);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(466, 33);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(18, 25);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(159, 26);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Search by Name";
            // 
            // tabOverview
            // 
            this.tabOverview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.tabOverview.Location = new System.Drawing.Point(4, 20);
            this.tabOverview.Name = "tabOverview";
            this.tabOverview.Padding = new System.Windows.Forms.Padding(3);
            this.tabOverview.Size = new System.Drawing.Size(968, 623);
            this.tabOverview.TabIndex = 1;
            this.tabOverview.Text = "Overview";
            // 
            // tabCtrlContent
            // 
            this.tabCtrlContent.Controls.Add(this.tabStudents);
            this.tabCtrlContent.Controls.Add(this.tabSettings);
            this.tabCtrlContent.Controls.Add(this.tabOverview);
            this.tabCtrlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrlContent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabCtrlContent.Location = new System.Drawing.Point(251, 0);
            this.tabCtrlContent.Margin = new System.Windows.Forms.Padding(10);
            this.tabCtrlContent.Name = "tabCtrlContent";
            this.tabCtrlContent.Padding = new System.Drawing.Point(25, 0);
            this.tabCtrlContent.SelectedIndex = 0;
            this.tabCtrlContent.Size = new System.Drawing.Size(976, 647);
            this.tabCtrlContent.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabCtrlContent.TabIndex = 1;
            // 
            // tabSettings
            // 
            this.tabSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.tabSettings.Controls.Add(this.lblSettingsUsrImageSupportText);
            this.tabSettings.Controls.Add(this.lblSettingsUserImage);
            this.tabSettings.Controls.Add(this.btnSettingsBrowseImage);
            this.tabSettings.Controls.Add(this.btnSettingsSave);
            this.tabSettings.Controls.Add(this.txtSettingsName);
            this.tabSettings.Controls.Add(this.lblSettingsName);
            this.tabSettings.Controls.Add(this.picBoxSettingsUserImage);
            this.tabSettings.Location = new System.Drawing.Point(4, 20);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(968, 623);
            this.tabSettings.TabIndex = 2;
            this.tabSettings.Text = "Settings";
            // 
            // lblSettingsUsrImageSupportText
            // 
            this.lblSettingsUsrImageSupportText.AutoSize = true;
            this.lblSettingsUsrImageSupportText.Font = new System.Drawing.Font("Open Sans", 9F);
            this.lblSettingsUsrImageSupportText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSettingsUsrImageSupportText.Location = new System.Drawing.Point(40, 384);
            this.lblSettingsUsrImageSupportText.Name = "lblSettingsUsrImageSupportText";
            this.lblSettingsUsrImageSupportText.Size = new System.Drawing.Size(127, 17);
            this.lblSettingsUsrImageSupportText.TabIndex = 22;
            this.lblSettingsUsrImageSupportText.Text = "Use square an image";
            // 
            // lblSettingsUserImage
            // 
            this.lblSettingsUserImage.AutoSize = true;
            this.lblSettingsUserImage.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettingsUserImage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSettingsUserImage.Location = new System.Drawing.Point(39, 144);
            this.lblSettingsUserImage.Name = "lblSettingsUserImage";
            this.lblSettingsUserImage.Size = new System.Drawing.Size(114, 26);
            this.lblSettingsUserImage.TabIndex = 21;
            this.lblSettingsUserImage.Text = "User Image";
            // 
            // btnSettingsBrowseImage
            // 
            this.btnSettingsBrowseImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.btnSettingsBrowseImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettingsBrowseImage.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.btnSettingsBrowseImage.Font = new System.Drawing.Font("Open Sans", 9F);
            this.btnSettingsBrowseImage.ForeColor = System.Drawing.Color.White;
            this.btnSettingsBrowseImage.Location = new System.Drawing.Point(44, 339);
            this.btnSettingsBrowseImage.Name = "btnSettingsBrowseImage";
            this.btnSettingsBrowseImage.Size = new System.Drawing.Size(200, 38);
            this.btnSettingsBrowseImage.TabIndex = 20;
            this.btnSettingsBrowseImage.Text = "Change profile picture";
            this.btnSettingsBrowseImage.UseVisualStyleBackColor = false;
            this.btnSettingsBrowseImage.Click += new System.EventHandler(this.btnSettingsBrowseImage_Click);
            // 
            // btnSettingsSave
            // 
            this.btnSettingsSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.btnSettingsSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettingsSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSettingsSave.FlatAppearance.BorderSize = 3;
            this.btnSettingsSave.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettingsSave.ForeColor = System.Drawing.Color.White;
            this.btnSettingsSave.Location = new System.Drawing.Point(44, 465);
            this.btnSettingsSave.Name = "btnSettingsSave";
            this.btnSettingsSave.Size = new System.Drawing.Size(105, 38);
            this.btnSettingsSave.TabIndex = 19;
            this.btnSettingsSave.Text = "SAVE";
            this.btnSettingsSave.UseVisualStyleBackColor = false;
            this.btnSettingsSave.Click += new System.EventHandler(this.btnSettingsSave_Click);
            // 
            // txtSettingsName
            // 
            this.txtSettingsName.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSettingsName.Location = new System.Drawing.Point(44, 79);
            this.txtSettingsName.Name = "txtSettingsName";
            this.txtSettingsName.Size = new System.Drawing.Size(466, 33);
            this.txtSettingsName.TabIndex = 18;
            // 
            // lblSettingsName
            // 
            this.lblSettingsName.AutoSize = true;
            this.lblSettingsName.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettingsName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSettingsName.Location = new System.Drawing.Point(39, 47);
            this.lblSettingsName.Name = "lblSettingsName";
            this.lblSettingsName.Size = new System.Drawing.Size(137, 26);
            this.lblSettingsName.TabIndex = 17;
            this.lblSettingsName.Text = "Display Name";
            // 
            // picBoxSettingsUserImage
            // 
            this.picBoxSettingsUserImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxSettingsUserImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBoxSettingsUserImage.InitialImage")));
            this.picBoxSettingsUserImage.Location = new System.Drawing.Point(44, 177);
            this.picBoxSettingsUserImage.Name = "picBoxSettingsUserImage";
            this.picBoxSettingsUserImage.Size = new System.Drawing.Size(200, 200);
            this.picBoxSettingsUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxSettingsUserImage.TabIndex = 4;
            this.picBoxSettingsUserImage.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1227, 647);
            this.Controls.Add(this.tabCtrlContent);
            this.Controls.Add(this.pnlNav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Information System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_Closed);
            this.pnlNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUserImage)).EndInit();
            this.tabStudents.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabCtrlContent.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSettingsUserImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnOverview;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.TabPage tabStudents;
        private System.Windows.Forms.TabPage tabOverview;
        private System.Windows.Forms.TabControl tabCtrlContent;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ColumnHeader lstName;
        private System.Windows.Forms.ColumnHeader lstAddress;
        private System.Windows.Forms.PictureBox picBoxUserImage;
        private System.Windows.Forms.Label lblLoginName;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.ColumnHeader lstDOB;
        private System.Windows.Forms.ColumnHeader lstContact;
        private System.Windows.Forms.ColumnHeader lstAdmissionDate;
        private System.Windows.Forms.ColumnHeader lstID;
        private System.Windows.Forms.PictureBox picBoxSettingsUserImage;
        private System.Windows.Forms.Button btnSettingsBrowseImage;
        private System.Windows.Forms.Button btnSettingsSave;
        private System.Windows.Forms.TextBox txtSettingsName;
        private System.Windows.Forms.Label lblSettingsName;
        private System.Windows.Forms.Label lblSettingsUserImage;
        private System.Windows.Forms.Label lblSettingsUsrImageSupportText;
    }
}