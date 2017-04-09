namespace StudentInfoSystem
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.tabCtrlContent = new System.Windows.Forms.TabControl();
            this.tabOverview = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView = new System.Windows.Forms.ListView();
            this.lstID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstDOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstContact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstAdmissionDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tabAddStudent = new System.Windows.Forms.TabPage();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.datePickerAddAdmissionDate = new System.Windows.Forms.DateTimePicker();
            this.datePickerAddDOB = new System.Windows.Forms.DateTimePicker();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.lblAddAdmissionDate = new System.Windows.Forms.Label();
            this.txtAddContact = new System.Windows.Forms.TextBox();
            this.lblAddContact = new System.Windows.Forms.Label();
            this.txtAddAddress = new System.Windows.Forms.TextBox();
            this.lblAddAddress = new System.Windows.Forms.Label();
            this.lblAddDOB = new System.Windows.Forms.Label();
            this.txtAddLastName = new System.Windows.Forms.TextBox();
            this.lblAddLastName = new System.Windows.Forms.Label();
            this.txtAddFirstName = new System.Windows.Forms.TextBox();
            this.lblAddFirstName = new System.Windows.Forms.Label();
            this.tabEditStudent = new System.Windows.Forms.TabPage();
            this.lblEditIDValue = new System.Windows.Forms.Label();
            this.lblEditID = new System.Windows.Forms.Label();
            this.btnEditCancel = new System.Windows.Forms.Button();
            this.datePickerEditAdmissionDate = new System.Windows.Forms.DateTimePicker();
            this.datePickerEditDOB = new System.Windows.Forms.DateTimePicker();
            this.btnEditUpdate = new System.Windows.Forms.Button();
            this.lblEditAdmissionDate = new System.Windows.Forms.Label();
            this.txtEditContact = new System.Windows.Forms.TextBox();
            this.lblEditContact = new System.Windows.Forms.Label();
            this.txtEditAddress = new System.Windows.Forms.TextBox();
            this.lblEditAddress = new System.Windows.Forms.Label();
            this.lEditDOB = new System.Windows.Forms.Label();
            this.txtEditLastName = new System.Windows.Forms.TextBox();
            this.lblEditLastName = new System.Windows.Forms.Label();
            this.txtEditFirstName = new System.Windows.Forms.TextBox();
            this.lblEditFirstName = new System.Windows.Forms.Label();
            this.lblLoginName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblTitleTagLine = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabCtrlContent.SuspendLayout();
            this.tabOverview.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tabAddStudent.SuspendLayout();
            this.tabEditStudent.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtrlContent
            // 
            this.tabCtrlContent.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabCtrlContent.Controls.Add(this.tabOverview);
            this.tabCtrlContent.Controls.Add(this.tabAddStudent);
            this.tabCtrlContent.Controls.Add(this.tabEditStudent);
            this.tabCtrlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrlContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCtrlContent.Location = new System.Drawing.Point(0, 0);
            this.tabCtrlContent.Name = "tabCtrlContent";
            this.tabCtrlContent.SelectedIndex = 0;
            this.tabCtrlContent.Size = new System.Drawing.Size(1145, 701);
            this.tabCtrlContent.TabIndex = 0;
            // 
            // tabOverview
            // 
            this.tabOverview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.tabOverview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabOverview.Controls.Add(this.panel2);
            this.tabOverview.Controls.Add(this.panel1);
            this.tabOverview.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabOverview.Location = new System.Drawing.Point(4, 36);
            this.tabOverview.Name = "tabOverview";
            this.tabOverview.Padding = new System.Windows.Forms.Padding(3);
            this.tabOverview.Size = new System.Drawing.Size(1137, 661);
            this.tabOverview.TabIndex = 0;
            this.tabOverview.Text = "Overview";
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.listView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1129, 484);
            this.panel2.TabIndex = 13;
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
            this.listView.FullRowSelect = true;
            this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(1129, 484);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // lstID
            // 
            this.lstID.Text = "ID";
            // 
            // lstName
            // 
            this.lstName.Text = "Name";
            this.lstName.Width = 225;
            // 
            // lstAddress
            // 
            this.lstAddress.Text = "Address";
            this.lstAddress.Width = 296;
            // 
            // lstDOB
            // 
            this.lstDOB.Text = "Date of Birth";
            this.lstDOB.Width = 150;
            // 
            // lstContact
            // 
            this.lstContact.Text = "Contact Number";
            this.lstContact.Width = 207;
            // 
            // lstAdmissionDate
            // 
            this.lstAdmissionDate.Text = "Admission Date";
            this.lstAdmissionDate.Width = 184;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 169);
            this.panel1.TabIndex = 12;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnNew);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Controls.Add(this.txtSearch);
            this.panel8.Controls.Add(this.btnEdit);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(889, 169);
            this.panel8.TabIndex = 13;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNew.FlatAppearance.BorderSize = 3;
            this.btnNew.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(21, 23);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(101, 39);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "NEW";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Search by Name";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(21, 114);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(466, 33);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEdit.FlatAppearance.BorderSize = 3;
            this.btnEdit.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(134, 23);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(171, 39);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "EDIT SELECTED";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnDelete);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(889, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(240, 169);
            this.panel7.TabIndex = 12;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderSize = 3;
            this.btnDelete.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(29, 26);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(193, 39);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "DELETE SELECTED";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tabAddStudent
            // 
            this.tabAddStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.tabAddStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabAddStudent.Controls.Add(this.btnAddCancel);
            this.tabAddStudent.Controls.Add(this.datePickerAddAdmissionDate);
            this.tabAddStudent.Controls.Add(this.datePickerAddDOB);
            this.tabAddStudent.Controls.Add(this.btnAddStudent);
            this.tabAddStudent.Controls.Add(this.lblAddAdmissionDate);
            this.tabAddStudent.Controls.Add(this.txtAddContact);
            this.tabAddStudent.Controls.Add(this.lblAddContact);
            this.tabAddStudent.Controls.Add(this.txtAddAddress);
            this.tabAddStudent.Controls.Add(this.lblAddAddress);
            this.tabAddStudent.Controls.Add(this.lblAddDOB);
            this.tabAddStudent.Controls.Add(this.txtAddLastName);
            this.tabAddStudent.Controls.Add(this.lblAddLastName);
            this.tabAddStudent.Controls.Add(this.txtAddFirstName);
            this.tabAddStudent.Controls.Add(this.lblAddFirstName);
            this.tabAddStudent.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAddStudent.Location = new System.Drawing.Point(4, 36);
            this.tabAddStudent.Name = "tabAddStudent";
            this.tabAddStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddStudent.Size = new System.Drawing.Size(1137, 661);
            this.tabAddStudent.TabIndex = 1;
            this.tabAddStudent.Text = "Add Student";
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.btnAddCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddCancel.FlatAppearance.BorderSize = 3;
            this.btnAddCancel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCancel.ForeColor = System.Drawing.Color.White;
            this.btnAddCancel.Location = new System.Drawing.Point(144, 510);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(117, 38);
            this.btnAddCancel.TabIndex = 19;
            this.btnAddCancel.Text = "CANCEL";
            this.btnAddCancel.UseVisualStyleBackColor = false;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // datePickerAddAdmissionDate
            // 
            this.datePickerAddAdmissionDate.Location = new System.Drawing.Point(33, 411);
            this.datePickerAddAdmissionDate.Name = "datePickerAddAdmissionDate";
            this.datePickerAddAdmissionDate.Size = new System.Drawing.Size(360, 33);
            this.datePickerAddAdmissionDate.TabIndex = 18;
            // 
            // datePickerAddDOB
            // 
            this.datePickerAddDOB.Location = new System.Drawing.Point(33, 161);
            this.datePickerAddDOB.Name = "datePickerAddDOB";
            this.datePickerAddDOB.Size = new System.Drawing.Size(360, 33);
            this.datePickerAddDOB.TabIndex = 17;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.btnAddStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStudent.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddStudent.FlatAppearance.BorderSize = 3;
            this.btnAddStudent.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.ForeColor = System.Drawing.Color.White;
            this.btnAddStudent.Location = new System.Drawing.Point(33, 510);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(105, 38);
            this.btnAddStudent.TabIndex = 16;
            this.btnAddStudent.Text = "ADD";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // lblAddAdmissionDate
            // 
            this.lblAddAdmissionDate.AutoSize = true;
            this.lblAddAdmissionDate.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAdmissionDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAddAdmissionDate.Location = new System.Drawing.Point(28, 379);
            this.lblAddAdmissionDate.Name = "lblAddAdmissionDate";
            this.lblAddAdmissionDate.Size = new System.Drawing.Size(168, 26);
            this.lblAddAdmissionDate.TabIndex = 14;
            this.lblAddAdmissionDate.Text = "Admission Date *";
            // 
            // txtAddContact
            // 
            this.txtAddContact.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddContact.Location = new System.Drawing.Point(33, 327);
            this.txtAddContact.Name = "txtAddContact";
            this.txtAddContact.Size = new System.Drawing.Size(466, 33);
            this.txtAddContact.TabIndex = 13;
            // 
            // lblAddContact
            // 
            this.lblAddContact.AutoSize = true;
            this.lblAddContact.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddContact.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAddContact.Location = new System.Drawing.Point(28, 295);
            this.lblAddContact.Name = "lblAddContact";
            this.lblAddContact.Size = new System.Drawing.Size(211, 26);
            this.lblAddContact.TabIndex = 12;
            this.lblAddContact.Text = "Telephone/Mobile No.";
            // 
            // txtAddAddress
            // 
            this.txtAddAddress.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddAddress.Location = new System.Drawing.Point(33, 243);
            this.txtAddAddress.Name = "txtAddAddress";
            this.txtAddAddress.Size = new System.Drawing.Size(832, 33);
            this.txtAddAddress.TabIndex = 11;
            // 
            // lblAddAddress
            // 
            this.lblAddAddress.AutoSize = true;
            this.lblAddAddress.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAddress.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAddAddress.Location = new System.Drawing.Point(28, 212);
            this.lblAddAddress.Name = "lblAddAddress";
            this.lblAddAddress.Size = new System.Drawing.Size(100, 26);
            this.lblAddAddress.TabIndex = 10;
            this.lblAddAddress.Text = "Address *";
            // 
            // lblAddDOB
            // 
            this.lblAddDOB.AutoSize = true;
            this.lblAddDOB.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddDOB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAddDOB.Location = new System.Drawing.Point(28, 129);
            this.lblAddDOB.Name = "lblAddDOB";
            this.lblAddDOB.Size = new System.Drawing.Size(141, 26);
            this.lblAddDOB.TabIndex = 8;
            this.lblAddDOB.Text = "Date of Birth *";
            // 
            // txtAddLastName
            // 
            this.txtAddLastName.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddLastName.Location = new System.Drawing.Point(517, 78);
            this.txtAddLastName.Name = "txtAddLastName";
            this.txtAddLastName.Size = new System.Drawing.Size(466, 33);
            this.txtAddLastName.TabIndex = 7;
            // 
            // lblAddLastName
            // 
            this.lblAddLastName.AutoSize = true;
            this.lblAddLastName.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddLastName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAddLastName.Location = new System.Drawing.Point(512, 47);
            this.lblAddLastName.Name = "lblAddLastName";
            this.lblAddLastName.Size = new System.Drawing.Size(108, 26);
            this.lblAddLastName.TabIndex = 6;
            this.lblAddLastName.Text = "Last Name";
            // 
            // txtAddFirstName
            // 
            this.txtAddFirstName.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddFirstName.Location = new System.Drawing.Point(33, 78);
            this.txtAddFirstName.Name = "txtAddFirstName";
            this.txtAddFirstName.Size = new System.Drawing.Size(466, 33);
            this.txtAddFirstName.TabIndex = 5;
            // 
            // lblAddFirstName
            // 
            this.lblAddFirstName.AutoSize = true;
            this.lblAddFirstName.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddFirstName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAddFirstName.Location = new System.Drawing.Point(28, 46);
            this.lblAddFirstName.Name = "lblAddFirstName";
            this.lblAddFirstName.Size = new System.Drawing.Size(125, 26);
            this.lblAddFirstName.TabIndex = 4;
            this.lblAddFirstName.Text = "First Name *";
            // 
            // tabEditStudent
            // 
            this.tabEditStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.tabEditStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabEditStudent.Controls.Add(this.lblEditIDValue);
            this.tabEditStudent.Controls.Add(this.lblEditID);
            this.tabEditStudent.Controls.Add(this.btnEditCancel);
            this.tabEditStudent.Controls.Add(this.datePickerEditAdmissionDate);
            this.tabEditStudent.Controls.Add(this.datePickerEditDOB);
            this.tabEditStudent.Controls.Add(this.btnEditUpdate);
            this.tabEditStudent.Controls.Add(this.lblEditAdmissionDate);
            this.tabEditStudent.Controls.Add(this.txtEditContact);
            this.tabEditStudent.Controls.Add(this.lblEditContact);
            this.tabEditStudent.Controls.Add(this.txtEditAddress);
            this.tabEditStudent.Controls.Add(this.lblEditAddress);
            this.tabEditStudent.Controls.Add(this.lEditDOB);
            this.tabEditStudent.Controls.Add(this.txtEditLastName);
            this.tabEditStudent.Controls.Add(this.lblEditLastName);
            this.tabEditStudent.Controls.Add(this.txtEditFirstName);
            this.tabEditStudent.Controls.Add(this.lblEditFirstName);
            this.tabEditStudent.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEditStudent.Location = new System.Drawing.Point(4, 36);
            this.tabEditStudent.Name = "tabEditStudent";
            this.tabEditStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabEditStudent.Size = new System.Drawing.Size(1137, 661);
            this.tabEditStudent.TabIndex = 3;
            this.tabEditStudent.Text = "Edit Student";
            // 
            // lblEditIDValue
            // 
            this.lblEditIDValue.AutoSize = true;
            this.lblEditIDValue.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditIDValue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEditIDValue.Location = new System.Drawing.Point(71, 32);
            this.lblEditIDValue.Name = "lblEditIDValue";
            this.lblEditIDValue.Size = new System.Drawing.Size(0, 26);
            this.lblEditIDValue.TabIndex = 35;
            // 
            // lblEditID
            // 
            this.lblEditID.AutoSize = true;
            this.lblEditID.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEditID.Location = new System.Drawing.Point(29, 32);
            this.lblEditID.Name = "lblEditID";
            this.lblEditID.Size = new System.Drawing.Size(36, 26);
            this.lblEditID.TabIndex = 34;
            this.lblEditID.Text = "ID:";
            // 
            // btnEditCancel
            // 
            this.btnEditCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.btnEditCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditCancel.FlatAppearance.BorderSize = 3;
            this.btnEditCancel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCancel.ForeColor = System.Drawing.Color.White;
            this.btnEditCancel.Location = new System.Drawing.Point(160, 546);
            this.btnEditCancel.Name = "btnEditCancel";
            this.btnEditCancel.Size = new System.Drawing.Size(118, 38);
            this.btnEditCancel.TabIndex = 33;
            this.btnEditCancel.Text = "CANCEL";
            this.btnEditCancel.UseVisualStyleBackColor = false;
            this.btnEditCancel.Click += new System.EventHandler(this.btnEditCancel_Click);
            // 
            // datePickerEditAdmissionDate
            // 
            this.datePickerEditAdmissionDate.Location = new System.Drawing.Point(33, 447);
            this.datePickerEditAdmissionDate.Name = "datePickerEditAdmissionDate";
            this.datePickerEditAdmissionDate.Size = new System.Drawing.Size(360, 33);
            this.datePickerEditAdmissionDate.TabIndex = 32;
            // 
            // datePickerEditDOB
            // 
            this.datePickerEditDOB.Location = new System.Drawing.Point(33, 197);
            this.datePickerEditDOB.Name = "datePickerEditDOB";
            this.datePickerEditDOB.Size = new System.Drawing.Size(360, 33);
            this.datePickerEditDOB.TabIndex = 31;
            // 
            // btnEditUpdate
            // 
            this.btnEditUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.btnEditUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditUpdate.FlatAppearance.BorderSize = 3;
            this.btnEditUpdate.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUpdate.ForeColor = System.Drawing.Color.White;
            this.btnEditUpdate.Location = new System.Drawing.Point(33, 546);
            this.btnEditUpdate.Name = "btnEditUpdate";
            this.btnEditUpdate.Size = new System.Drawing.Size(121, 38);
            this.btnEditUpdate.TabIndex = 30;
            this.btnEditUpdate.Text = "UPDATE";
            this.btnEditUpdate.UseVisualStyleBackColor = false;
            this.btnEditUpdate.Click += new System.EventHandler(this.btnEditUpdate_Click);
            // 
            // lblEditAdmissionDate
            // 
            this.lblEditAdmissionDate.AutoSize = true;
            this.lblEditAdmissionDate.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditAdmissionDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEditAdmissionDate.Location = new System.Drawing.Point(28, 415);
            this.lblEditAdmissionDate.Name = "lblEditAdmissionDate";
            this.lblEditAdmissionDate.Size = new System.Drawing.Size(153, 26);
            this.lblEditAdmissionDate.TabIndex = 29;
            this.lblEditAdmissionDate.Text = "Admission Date";
            // 
            // txtEditContact
            // 
            this.txtEditContact.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditContact.Location = new System.Drawing.Point(33, 363);
            this.txtEditContact.Name = "txtEditContact";
            this.txtEditContact.Size = new System.Drawing.Size(466, 33);
            this.txtEditContact.TabIndex = 28;
            // 
            // lblEditContact
            // 
            this.lblEditContact.AutoSize = true;
            this.lblEditContact.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditContact.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEditContact.Location = new System.Drawing.Point(28, 331);
            this.lblEditContact.Name = "lblEditContact";
            this.lblEditContact.Size = new System.Drawing.Size(211, 26);
            this.lblEditContact.TabIndex = 27;
            this.lblEditContact.Text = "Telephone/Mobile No.";
            // 
            // txtEditAddress
            // 
            this.txtEditAddress.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditAddress.Location = new System.Drawing.Point(33, 279);
            this.txtEditAddress.Name = "txtEditAddress";
            this.txtEditAddress.Size = new System.Drawing.Size(832, 33);
            this.txtEditAddress.TabIndex = 26;
            // 
            // lblEditAddress
            // 
            this.lblEditAddress.AutoSize = true;
            this.lblEditAddress.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditAddress.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEditAddress.Location = new System.Drawing.Point(28, 248);
            this.lblEditAddress.Name = "lblEditAddress";
            this.lblEditAddress.Size = new System.Drawing.Size(85, 26);
            this.lblEditAddress.TabIndex = 25;
            this.lblEditAddress.Text = "Address";
            // 
            // lEditDOB
            // 
            this.lEditDOB.AutoSize = true;
            this.lEditDOB.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEditDOB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lEditDOB.Location = new System.Drawing.Point(29, 165);
            this.lEditDOB.Name = "lEditDOB";
            this.lEditDOB.Size = new System.Drawing.Size(126, 26);
            this.lEditDOB.TabIndex = 24;
            this.lEditDOB.Text = "Date of Birth";
            // 
            // txtEditLastName
            // 
            this.txtEditLastName.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditLastName.Location = new System.Drawing.Point(517, 114);
            this.txtEditLastName.Name = "txtEditLastName";
            this.txtEditLastName.Size = new System.Drawing.Size(466, 33);
            this.txtEditLastName.TabIndex = 23;
            // 
            // lblEditLastName
            // 
            this.lblEditLastName.AutoSize = true;
            this.lblEditLastName.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditLastName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEditLastName.Location = new System.Drawing.Point(512, 83);
            this.lblEditLastName.Name = "lblEditLastName";
            this.lblEditLastName.Size = new System.Drawing.Size(108, 26);
            this.lblEditLastName.TabIndex = 22;
            this.lblEditLastName.Text = "Last Name";
            // 
            // txtEditFirstName
            // 
            this.txtEditFirstName.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditFirstName.Location = new System.Drawing.Point(33, 114);
            this.txtEditFirstName.Name = "txtEditFirstName";
            this.txtEditFirstName.Size = new System.Drawing.Size(466, 33);
            this.txtEditFirstName.TabIndex = 21;
            // 
            // lblEditFirstName
            // 
            this.lblEditFirstName.AutoSize = true;
            this.lblEditFirstName.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditFirstName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEditFirstName.Location = new System.Drawing.Point(28, 82);
            this.lblEditFirstName.Name = "lblEditFirstName";
            this.lblEditFirstName.Size = new System.Drawing.Size(110, 26);
            this.lblEditFirstName.TabIndex = 20;
            this.lblEditFirstName.Text = "First Name";
            // 
            // lblLoginName
            // 
            this.lblLoginName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoginName.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblLoginName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLoginName.Location = new System.Drawing.Point(9, 38);
            this.lblLoginName.Name = "lblLoginName";
            this.lblLoginName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLoginName.Size = new System.Drawing.Size(273, 26);
            this.lblLoginName.TabIndex = 10;
            this.lblLoginName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(24, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogout.FlatAppearance.BorderSize = 3;
            this.btnLogout.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(285, 30);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(108, 38);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1145, 103);
            this.panel3.TabIndex = 13;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblTitleTagLine);
            this.panel6.Controls.Add(this.lblTitle);
            this.panel6.Controls.Add(this.button1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(726, 103);
            this.panel6.TabIndex = 14;
            // 
            // lblTitleTagLine
            // 
            this.lblTitleTagLine.AutoSize = true;
            this.lblTitleTagLine.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleTagLine.Font = new System.Drawing.Font("Open Sans", 10F);
            this.lblTitleTagLine.ForeColor = System.Drawing.Color.White;
            this.lblTitleTagLine.Location = new System.Drawing.Point(83, 51);
            this.lblTitleTagLine.Name = "lblTitleTagLine";
            this.lblTitleTagLine.Size = new System.Drawing.Size(76, 19);
            this.lblTitleTagLine.TabIndex = 13;
            this.lblTitleTagLine.Text = "for School";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Open Sans", 16F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(82, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(298, 30);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Student Information System";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblLoginName);
            this.panel5.Controls.Add(this.btnLogout);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(726, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(419, 103);
            this.panel5.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.Controls.Add(this.tabCtrlContent);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 103);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1145, 701);
            this.panel4.TabIndex = 14;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1145, 804);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Information System - Admin Portal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAdmin_Closed);
            this.tabCtrlContent.ResumeLayout(false);
            this.tabOverview.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.tabAddStudent.ResumeLayout(false);
            this.tabAddStudent.PerformLayout();
            this.tabEditStudent.ResumeLayout(false);
            this.tabEditStudent.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrlContent;
        private System.Windows.Forms.TabPage tabAddStudent;
        private System.Windows.Forms.Label lblLoginName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox txtAddAddress;
        private System.Windows.Forms.Label lblAddAddress;
        private System.Windows.Forms.Label lblAddDOB;
        private System.Windows.Forms.TextBox txtAddLastName;
        private System.Windows.Forms.Label lblAddLastName;
        private System.Windows.Forms.TextBox txtAddFirstName;
        private System.Windows.Forms.Label lblAddFirstName;
        private System.Windows.Forms.TextBox txtAddContact;
        private System.Windows.Forms.Label lblAddContact;
        private System.Windows.Forms.Label lblAddAdmissionDate;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.DateTimePicker datePickerAddAdmissionDate;
        private System.Windows.Forms.DateTimePicker datePickerAddDOB;
        private System.Windows.Forms.TabPage tabEditStudent;
        private System.Windows.Forms.TabPage tabOverview;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader lstName;
        private System.Windows.Forms.ColumnHeader lstAddress;
        private System.Windows.Forms.ColumnHeader lstDOB;
        private System.Windows.Forms.ColumnHeader lstContact;
        private System.Windows.Forms.ColumnHeader lstAdmissionDate;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.Button btnEditCancel;
        private System.Windows.Forms.DateTimePicker datePickerEditAdmissionDate;
        private System.Windows.Forms.DateTimePicker datePickerEditDOB;
        private System.Windows.Forms.Button btnEditUpdate;
        private System.Windows.Forms.Label lblEditAdmissionDate;
        private System.Windows.Forms.TextBox txtEditContact;
        private System.Windows.Forms.Label lblEditContact;
        private System.Windows.Forms.TextBox txtEditAddress;
        private System.Windows.Forms.Label lblEditAddress;
        private System.Windows.Forms.Label lEditDOB;
        private System.Windows.Forms.TextBox txtEditLastName;
        private System.Windows.Forms.Label lblEditLastName;
        private System.Windows.Forms.TextBox txtEditFirstName;
        private System.Windows.Forms.Label lblEditFirstName;
        private System.Windows.Forms.ColumnHeader lstID;
        private System.Windows.Forms.Label lblEditIDValue;
        private System.Windows.Forms.Label lblEditID;
        private System.Windows.Forms.Label lblTitleTagLine;
        private System.Windows.Forms.Label lblTitle;
    }
}