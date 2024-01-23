namespace Thuchanh1
{
    partial class FStudent
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
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblIdentity = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.gvStudents = new System.Windows.Forms.DataGridView();
            this.lbl_UUID = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.btnChangeTeacherForm = new System.Windows.Forms.Button();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.cboSex = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtLowerGrade = new System.Windows.Forms.TextBox();
            this.txtUpperGrade = new System.Windows.Forms.TextBox();
            this.lblGreaterThan = new System.Windows.Forms.Label();
            this.lblLessThan = new System.Windows.Forms.Label();
            this.gbFilterByGrade = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudents)).BeginInit();
            this.gbFilterByGrade.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(17, 62);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(68, 16);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Full name:";
            // 
            // lblIdentity
            // 
            this.lblIdentity.AutoSize = true;
            this.lblIdentity.Location = new System.Drawing.Point(16, 130);
            this.lblIdentity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdentity.Name = "lblIdentity";
            this.lblIdentity.Size = new System.Drawing.Size(99, 16);
            this.lblIdentity.TabIndex = 1;
            this.lblIdentity.Text = "Government ID:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(17, 98);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(61, 16);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Address:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(168, 58);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(337, 22);
            this.txtFullName.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(167, 90);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(337, 22);
            this.txtAddress.TabIndex = 5;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(165, 122);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(337, 22);
            this.txtID.TabIndex = 6;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(21, 160);
            this.lblBirthDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(63, 16);
            this.lblBirthDate.TabIndex = 7;
            this.lblBirthDate.Text = "Birthdate:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 434);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 43);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(188, 434);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(77, 43);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(103, 434);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(77, 43);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.CustomFormat = "dd/MM/yyyy";
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthDate.Location = new System.Drawing.Point(168, 154);
            this.dtpBirthDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(337, 22);
            this.dtpBirthDate.TabIndex = 11;
            // 
            // gvStudents
            // 
            this.gvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStudents.Location = new System.Drawing.Point(536, 15);
            this.gvStudents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gvStudents.Name = "gvStudents";
            this.gvStudents.RowHeadersWidth = 51;
            this.gvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvStudents.Size = new System.Drawing.Size(665, 359);
            this.gvStudents.TabIndex = 12;
            this.gvStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GvStudents_CellContentClick);
            this.gvStudents.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GvStudents_CellContentClick);
            // 
            // lbl_UUID
            // 
            this.lbl_UUID.AutoSize = true;
            this.lbl_UUID.Location = new System.Drawing.Point(19, 25);
            this.lbl_UUID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_UUID.Name = "lbl_UUID";
            this.lbl_UUID.Size = new System.Drawing.Size(40, 16);
            this.lbl_UUID.TabIndex = 15;
            this.lbl_UUID.Text = "UUID";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(164, 25);
            this.lbl_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(0, 16);
            this.lbl_ID.TabIndex = 16;
            // 
            // btnChangeTeacherForm
            // 
            this.btnChangeTeacherForm.Location = new System.Drawing.Point(964, 401);
            this.btnChangeTeacherForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChangeTeacherForm.Name = "btnChangeTeacherForm";
            this.btnChangeTeacherForm.Size = new System.Drawing.Size(237, 76);
            this.btnChangeTeacherForm.TabIndex = 17;
            this.btnChangeTeacherForm.Text = "Change to Teacher Form";
            this.btnChangeTeacherForm.UseVisualStyleBackColor = true;
            this.btnChangeTeacherForm.Click += new System.EventHandler(this.BtnChangeTeacherForm_Click);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(168, 185);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(339, 22);
            this.txtPhoneNumber.TabIndex = 37;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(23, 191);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(97, 16);
            this.lblPhoneNumber.TabIndex = 36;
            this.lblPhoneNumber.Text = "Phone number:";
            // 
            // cboSex
            // 
            this.cboSex.FormattingEnabled = true;
            this.cboSex.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cboSex.Location = new System.Drawing.Point(168, 247);
            this.cboSex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboSex.Name = "cboSex";
            this.cboSex.Size = new System.Drawing.Size(335, 24);
            this.cboSex.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "Sex: ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(167, 214);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(339, 22);
            this.txtEmail.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "Email:";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(25, 284);
            this.lblGrade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(45, 16);
            this.lblGrade.TabIndex = 48;
            this.lblGrade.Text = "Grade";
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(165, 284);
            this.txtGrade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(339, 22);
            this.txtGrade.TabIndex = 49;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(393, 49);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(88, 28);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtLowerGrade
            // 
            this.txtLowerGrade.Location = new System.Drawing.Point(17, 49);
            this.txtLowerGrade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLowerGrade.Name = "txtLowerGrade";
            this.txtLowerGrade.Size = new System.Drawing.Size(171, 22);
            this.txtLowerGrade.TabIndex = 50;
            // 
            // txtUpperGrade
            // 
            this.txtUpperGrade.Location = new System.Drawing.Point(197, 49);
            this.txtUpperGrade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUpperGrade.Name = "txtUpperGrade";
            this.txtUpperGrade.Size = new System.Drawing.Size(191, 22);
            this.txtUpperGrade.TabIndex = 51;
            // 
            // lblGreaterThan
            // 
            this.lblGreaterThan.AutoSize = true;
            this.lblGreaterThan.Location = new System.Drawing.Point(13, 30);
            this.lblGreaterThan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGreaterThan.Name = "lblGreaterThan";
            this.lblGreaterThan.Size = new System.Drawing.Size(80, 16);
            this.lblGreaterThan.TabIndex = 52;
            this.lblGreaterThan.Text = "Greater than";
            // 
            // lblLessThan
            // 
            this.lblLessThan.AutoSize = true;
            this.lblLessThan.Location = new System.Drawing.Point(193, 30);
            this.lblLessThan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLessThan.Name = "lblLessThan";
            this.lblLessThan.Size = new System.Drawing.Size(64, 16);
            this.lblLessThan.TabIndex = 53;
            this.lblLessThan.Text = "Less than";
            // 
            // gbFilterByGrade
            // 
            this.gbFilterByGrade.Controls.Add(this.lblGreaterThan);
            this.gbFilterByGrade.Controls.Add(this.lblLessThan);
            this.gbFilterByGrade.Controls.Add(this.btnSubmit);
            this.gbFilterByGrade.Controls.Add(this.txtLowerGrade);
            this.gbFilterByGrade.Controls.Add(this.txtUpperGrade);
            this.gbFilterByGrade.Location = new System.Drawing.Point(15, 316);
            this.gbFilterByGrade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbFilterByGrade.Name = "gbFilterByGrade";
            this.gbFilterByGrade.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbFilterByGrade.Size = new System.Drawing.Size(489, 97);
            this.gbFilterByGrade.TabIndex = 54;
            this.gbFilterByGrade.TabStop = false;
            this.gbFilterByGrade.Text = "Filter by grade";
            // 
            // FStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1217, 492);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.cboSex);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.btnChangeTeacherForm);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.lbl_UUID);
            this.Controls.Add(this.gvStudents);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblIdentity);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.gbFilterByGrade);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FStudent";
            this.Text = "Student management";
            this.Load += new System.EventHandler(this.FStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvStudents)).EndInit();
            this.gbFilterByGrade.ResumeLayout(false);
            this.gbFilterByGrade.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblIdentity;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.DataGridView gvStudents;
        private System.Windows.Forms.Label lbl_UUID;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Button btnChangeTeacherForm;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.ComboBox cboSex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtLowerGrade;
        private System.Windows.Forms.TextBox txtUpperGrade;
        private System.Windows.Forms.Label lblGreaterThan;
        private System.Windows.Forms.Label lblLessThan;
        private System.Windows.Forms.GroupBox gbFilterByGrade;
    }
}

