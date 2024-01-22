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
            this.lblFullName.Location = new System.Drawing.Point(13, 50);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(55, 13);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Full name:";
            // 
            // lblIdentity
            // 
            this.lblIdentity.AutoSize = true;
            this.lblIdentity.Location = new System.Drawing.Point(12, 106);
            this.lblIdentity.Name = "lblIdentity";
            this.lblIdentity.Size = new System.Drawing.Size(82, 13);
            this.lblIdentity.TabIndex = 1;
            this.lblIdentity.Text = "Government ID:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(13, 80);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Address:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(126, 47);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(254, 20);
            this.txtFullName.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(125, 73);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(254, 20);
            this.txtAddress.TabIndex = 5;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(124, 99);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(254, 20);
            this.txtID.TabIndex = 6;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(16, 130);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(52, 13);
            this.lblBirthDate.TabIndex = 7;
            this.lblBirthDate.Text = "Birthdate:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 353);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(59, 35);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(141, 353);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(58, 35);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(77, 353);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(58, 35);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.CustomFormat = "dd/MM/yyyy";
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthDate.Location = new System.Drawing.Point(126, 125);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(254, 20);
            this.dtpBirthDate.TabIndex = 11;
            // 
            // gvStudents
            // 
            this.gvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStudents.Location = new System.Drawing.Point(402, 12);
            this.gvStudents.Name = "gvStudents";
            this.gvStudents.RowHeadersWidth = 51;
            this.gvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvStudents.Size = new System.Drawing.Size(499, 292);
            this.gvStudents.TabIndex = 12;
            this.gvStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GvStudents_CellContentClick);
            this.gvStudents.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GvStudents_CellContentClick);
            // 
            // lbl_UUID
            // 
            this.lbl_UUID.AutoSize = true;
            this.lbl_UUID.Location = new System.Drawing.Point(14, 20);
            this.lbl_UUID.Name = "lbl_UUID";
            this.lbl_UUID.Size = new System.Drawing.Size(34, 13);
            this.lbl_UUID.TabIndex = 15;
            this.lbl_UUID.Text = "UUID";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(123, 20);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(0, 13);
            this.lbl_ID.TabIndex = 16;
            // 
            // btnChangeTeacherForm
            // 
            this.btnChangeTeacherForm.Location = new System.Drawing.Point(723, 326);
            this.btnChangeTeacherForm.Name = "btnChangeTeacherForm";
            this.btnChangeTeacherForm.Size = new System.Drawing.Size(178, 62);
            this.btnChangeTeacherForm.TabIndex = 17;
            this.btnChangeTeacherForm.Text = "Change to Teacher Form";
            this.btnChangeTeacherForm.UseVisualStyleBackColor = true;
            this.btnChangeTeacherForm.Click += new System.EventHandler(this.BtnChangeTeacherForm_Click);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(126, 150);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(255, 20);
            this.txtPhoneNumber.TabIndex = 37;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(17, 155);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(79, 13);
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
            this.cboSex.Location = new System.Drawing.Point(126, 201);
            this.cboSex.Name = "cboSex";
            this.cboSex.Size = new System.Drawing.Size(252, 21);
            this.cboSex.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Sex: ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(125, 174);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(255, 20);
            this.txtEmail.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Email:";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(19, 231);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(36, 13);
            this.lblGrade.TabIndex = 48;
            this.lblGrade.Text = "Grade";
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(124, 231);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(255, 20);
            this.txtGrade.TabIndex = 49;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(295, 40);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(66, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtLowerGrade
            // 
            this.txtLowerGrade.Location = new System.Drawing.Point(13, 40);
            this.txtLowerGrade.Name = "txtLowerGrade";
            this.txtLowerGrade.Size = new System.Drawing.Size(129, 20);
            this.txtLowerGrade.TabIndex = 50;
            // 
            // txtUpperGrade
            // 
            this.txtUpperGrade.Location = new System.Drawing.Point(148, 40);
            this.txtUpperGrade.Name = "txtUpperGrade";
            this.txtUpperGrade.Size = new System.Drawing.Size(144, 20);
            this.txtUpperGrade.TabIndex = 51;
            // 
            // lblGreaterThan
            // 
            this.lblGreaterThan.AutoSize = true;
            this.lblGreaterThan.Location = new System.Drawing.Point(10, 24);
            this.lblGreaterThan.Name = "lblGreaterThan";
            this.lblGreaterThan.Size = new System.Drawing.Size(66, 13);
            this.lblGreaterThan.TabIndex = 52;
            this.lblGreaterThan.Text = "Greater than";
            // 
            // lblLessThan
            // 
            this.lblLessThan.AutoSize = true;
            this.lblLessThan.Location = new System.Drawing.Point(145, 24);
            this.lblLessThan.Name = "lblLessThan";
            this.lblLessThan.Size = new System.Drawing.Size(53, 13);
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
            this.gbFilterByGrade.Location = new System.Drawing.Point(11, 257);
            this.gbFilterByGrade.Name = "gbFilterByGrade";
            this.gbFilterByGrade.Size = new System.Drawing.Size(367, 79);
            this.gbFilterByGrade.TabIndex = 54;
            this.gbFilterByGrade.TabStop = false;
            this.gbFilterByGrade.Text = "Filter by grade";
            // 
            // FStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(913, 400);
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

