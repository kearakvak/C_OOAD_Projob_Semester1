namespace ProjectCSharpSQLServer
{
    partial class FormStaff
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
            this.txtNameEN = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtHiredDate = new System.Windows.Forms.DateTimePicker();
            this.txtBirthDate = new System.Windows.Forms.DateTimePicker();
            this.cboStopWork = new System.Windows.Forms.ComboBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.Label11 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.Photo = new System.Windows.Forms.PictureBox();
            this.cboPosition = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.LstStaff = new System.Windows.Forms.ListBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtNameKH = new System.Windows.Forms.TextBox();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNameEN
            // 
            this.txtNameEN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNameEN.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameEN.Location = new System.Drawing.Point(423, 219);
            this.txtNameEN.Name = "txtNameEN";
            this.txtNameEN.Size = new System.Drawing.Size(224, 29);
            this.txtNameEN.TabIndex = 452;
            this.txtNameEN.Tag = "Staff\'s Name English";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(239, 224);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(186, 24);
            this.label13.TabIndex = 480;
            this.label13.Text = "Staff\'s Name English:";
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhone.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(423, 324);
            this.txtPhone.Mask = "(000) 000-0009";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(224, 29);
            this.txtPhone.TabIndex = 455;
            // 
            // txtHiredDate
            // 
            this.txtHiredDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHiredDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHiredDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtHiredDate.Location = new System.Drawing.Point(423, 464);
            this.txtHiredDate.Name = "txtHiredDate";
            this.txtHiredDate.Size = new System.Drawing.Size(428, 29);
            this.txtHiredDate.TabIndex = 459;
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBirthDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtBirthDate.Location = new System.Drawing.Point(423, 289);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(224, 29);
            this.txtBirthDate.TabIndex = 454;
            // 
            // cboStopWork
            // 
            this.cboStopWork.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboStopWork.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStopWork.FormattingEnabled = true;
            this.cboStopWork.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cboStopWork.Location = new System.Drawing.Point(423, 499);
            this.cboStopWork.Name = "cboStopWork";
            this.cboStopWork.Size = new System.Drawing.Size(428, 29);
            this.cboStopWork.TabIndex = 460;
            this.cboStopWork.Tag = "*";
            // 
            // Label12
            // 
            this.Label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(239, 504);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(97, 24);
            this.Label12.TabIndex = 479;
            this.Label12.Text = "StopWork:";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(528, 73);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(119, 40);
            this.btnClose.TabIndex = 478;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(397, 73);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 40);
            this.btnSave.TabIndex = 464;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(267, 73);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(114, 40);
            this.btnNew.TabIndex = 461;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // Label11
            // 
            this.Label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(28, 89);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(103, 24);
            this.Label11.TabIndex = 477;
            this.Label11.Text = "Staff\'s Lists:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(703, 73);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(114, 40);
            this.btnBrowse.TabIndex = 463;
            this.btnBrowse.Text = "&Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // Photo
            // 
            this.Photo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Photo.BackColor = System.Drawing.SystemColors.Highlight;
            this.Photo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Photo.Location = new System.Drawing.Point(667, 141);
            this.Photo.Name = "Photo";
            this.Photo.Size = new System.Drawing.Size(184, 212);
            this.Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Photo.TabIndex = 466;
            this.Photo.TabStop = false;
            // 
            // cboPosition
            // 
            this.cboPosition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboPosition.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPosition.FormattingEnabled = true;
            this.cboPosition.Location = new System.Drawing.Point(423, 394);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(428, 29);
            this.cboPosition.TabIndex = 457;
            this.cboPosition.Tag = "Position";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch.Font = new System.Drawing.Font("Khmer OS Siemreap", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(32, 51);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(201, 37);
            this.txtSearch.TabIndex = 465;
            this.txtSearch.Tag = "*";
            // 
            // Label1
            // 
            this.Label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(28, 24);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(157, 24);
            this.Label1.TabIndex = 476;
            this.Label1.Text = "Search By Name:";
            // 
            // LstStaff
            // 
            this.LstStaff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LstStaff.Font = new System.Drawing.Font("Khmer OS Siemreap", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstStaff.FormattingEnabled = true;
            this.LstStaff.ItemHeight = 34;
            this.LstStaff.Location = new System.Drawing.Point(32, 116);
            this.LstStaff.Name = "LstStaff";
            this.LstStaff.Size = new System.Drawing.Size(201, 412);
            this.LstStaff.TabIndex = 462;
            // 
            // Label10
            // 
            this.Label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(239, 469);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(99, 24);
            this.Label10.TabIndex = 475;
            this.Label10.Text = "HiredDate:";
            // 
            // Label9
            // 
            this.Label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(239, 434);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(66, 24);
            this.Label9.TabIndex = 473;
            this.Label9.Text = "Salary:";
            // 
            // Label8
            // 
            this.Label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(239, 399);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(81, 24);
            this.Label8.TabIndex = 474;
            this.Label8.Text = "Position:";
            // 
            // Label7
            // 
            this.Label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(241, 329);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(71, 24);
            this.Label7.TabIndex = 472;
            this.Label7.Text = "Phone:";
            // 
            // txtSalary
            // 
            this.txtSalary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSalary.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(423, 429);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(428, 29);
            this.txtSalary.TabIndex = 458;
            this.txtSalary.Tag = "Salary";
            // 
            // Label6
            // 
            this.Label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(241, 364);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(85, 24);
            this.Label6.TabIndex = 471;
            this.Label6.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(423, 359);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(428, 29);
            this.txtAddress.TabIndex = 456;
            this.txtAddress.Tag = "Address";
            // 
            // Label5
            // 
            this.Label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(241, 294);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(90, 24);
            this.Label5.TabIndex = 470;
            this.Label5.Text = "BirthDate:";
            // 
            // txtNameKH
            // 
            this.txtNameKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNameKH.Font = new System.Drawing.Font("Khmer OS Siemreap", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameKH.Location = new System.Drawing.Point(423, 176);
            this.txtNameKH.Name = "txtNameKH";
            this.txtNameKH.Size = new System.Drawing.Size(224, 37);
            this.txtNameKH.TabIndex = 451;
            this.txtNameKH.Tag = "Staff\'s Name Khmer";
            // 
            // cboGender
            // 
            this.cboGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboGender.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.cboGender.Location = new System.Drawing.Point(423, 254);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(224, 29);
            this.cboGender.TabIndex = 453;
            this.cboGender.Tag = "Gender";
            // 
            // Label4
            // 
            this.Label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(241, 259);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(79, 24);
            this.Label4.TabIndex = 469;
            this.Label4.Text = "Gender:";
            // 
            // Label3
            // 
            this.Label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(239, 183);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(179, 24);
            this.Label3.TabIndex = 468;
            this.Label3.Text = "Staff\'s Name Khmer:";
            // 
            // Label2
            // 
            this.Label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(239, 146);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(84, 24);
            this.Label2.TabIndex = 467;
            this.Label2.Text = "Staff\'s ID:";
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(423, 141);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(224, 29);
            this.txtID.TabIndex = 450;
            this.txtID.Tag = "Staff\'s ID";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 553);
            this.Controls.Add(this.txtNameEN);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtHiredDate);
            this.Controls.Add(this.txtBirthDate);
            this.Controls.Add(this.cboStopWork);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.Photo);
            this.Controls.Add(this.cboPosition);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.LstStaff);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.txtNameKH);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtID);
            this.Name = "FormStaff";
            this.Text = "Staff\'s Information";
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtNameEN;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.MaskedTextBox txtPhone;
        internal System.Windows.Forms.DateTimePicker txtHiredDate;
        internal System.Windows.Forms.DateTimePicker txtBirthDate;
        internal System.Windows.Forms.ComboBox cboStopWork;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Button btnNew;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Button btnBrowse;
        internal System.Windows.Forms.PictureBox Photo;
        internal System.Windows.Forms.ComboBox cboPosition;
        internal System.Windows.Forms.TextBox txtSearch;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ListBox LstStaff;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtSalary;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtAddress;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtNameKH;
        internal System.Windows.Forms.ComboBox cboGender;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ErrorProvider errorProvider1;



    }
}

