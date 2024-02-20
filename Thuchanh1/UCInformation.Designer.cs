namespace Thuchanh1
{
    partial class UCInformation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblGreaterThan = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtLowerGrade = new System.Windows.Forms.TextBox();
            this.txtUpperGrade = new System.Windows.Forms.TextBox();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.cboSex = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.btnChangeTeacherForm = new System.Windows.Forms.Button();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_UUID = new System.Windows.Forms.Label();
            this.gvStudents = new System.Windows.Forms.DataGridView();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblIdentity = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.lblLessThan = new System.Windows.Forms.Label();
            this.gbFilterByGrade = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudents)).BeginInit();
            this.gbFilterByGrade.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(121, 165);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(255, 20);
            this.txtEmail.TabIndex = 73;
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
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(295, 40);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(66, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
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
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(120, 222);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(255, 20);
            this.txtGrade.TabIndex = 77;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(15, 222);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(36, 13);
            this.lblGrade.TabIndex = 76;
            this.lblGrade.Text = "Grade";
            // 
            // cboSex
            // 
            this.cboSex.FormattingEnabled = true;
            this.cboSex.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cboSex.Location = new System.Drawing.Point(122, 192);
            this.cboSex.Name = "cboSex";
            this.cboSex.Size = new System.Drawing.Size(252, 21);
            this.cboSex.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 74;
            this.label3.Text = "Sex: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 72;
            this.label2.Text = "Email:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(122, 141);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(255, 20);
            this.txtPhoneNumber.TabIndex = 71;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(13, 146);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(79, 13);
            this.lblPhoneNumber.TabIndex = 70;
            this.lblPhoneNumber.Text = "Phone number:";
            // 
            // btnChangeTeacherForm
            // 
            this.btnChangeTeacherForm.Location = new System.Drawing.Point(719, 317);
            this.btnChangeTeacherForm.Name = "btnChangeTeacherForm";
            this.btnChangeTeacherForm.Size = new System.Drawing.Size(178, 62);
            this.btnChangeTeacherForm.TabIndex = 69;
            this.btnChangeTeacherForm.Text = "Change to Teacher Form";
            this.btnChangeTeacherForm.UseVisualStyleBackColor = true;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(119, 11);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(0, 13);
            this.lbl_ID.TabIndex = 68;
            // 
            // lbl_UUID
            // 
            this.lbl_UUID.AutoSize = true;
            this.lbl_UUID.Location = new System.Drawing.Point(10, 11);
            this.lbl_UUID.Name = "lbl_UUID";
            this.lbl_UUID.Size = new System.Drawing.Size(34, 13);
            this.lbl_UUID.TabIndex = 67;
            this.lbl_UUID.Text = "UUID";
            // 
            // gvStudents
            // 
            this.gvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStudents.Location = new System.Drawing.Point(398, 3);
            this.gvStudents.Name = "gvStudents";
            this.gvStudents.RowHeadersWidth = 51;
            this.gvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvStudents.Size = new System.Drawing.Size(499, 292);
            this.gvStudents.TabIndex = 66;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.CustomFormat = "dd/MM/yyyy";
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthDate.Location = new System.Drawing.Point(122, 116);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(254, 20);
            this.dtpBirthDate.TabIndex = 65;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(73, 344);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(58, 35);
            this.btnDelete.TabIndex = 64;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(137, 344);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(58, 35);
            this.btnEdit.TabIndex = 63;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(8, 344);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(59, 35);
            this.btnAdd.TabIndex = 62;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(12, 121);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(52, 13);
            this.lblBirthDate.TabIndex = 61;
            this.lblBirthDate.Text = "Birthdate:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(120, 90);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(254, 20);
            this.txtID.TabIndex = 60;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(121, 64);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(254, 20);
            this.txtAddress.TabIndex = 59;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(122, 38);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(254, 20);
            this.txtFullName.TabIndex = 58;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(9, 71);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 57;
            this.lblAddress.Text = "Address:";
            // 
            // lblIdentity
            // 
            this.lblIdentity.AutoSize = true;
            this.lblIdentity.Location = new System.Drawing.Point(8, 97);
            this.lblIdentity.Name = "lblIdentity";
            this.lblIdentity.Size = new System.Drawing.Size(82, 13);
            this.lblIdentity.TabIndex = 56;
            this.lblIdentity.Text = "Government ID:";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(9, 41);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(55, 13);
            this.lblFullName.TabIndex = 55;
            this.lblFullName.Text = "Full name:";
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
            this.gbFilterByGrade.Location = new System.Drawing.Point(7, 248);
            this.gbFilterByGrade.Name = "gbFilterByGrade";
            this.gbFilterByGrade.Size = new System.Drawing.Size(367, 79);
            this.gbFilterByGrade.TabIndex = 78;
            this.gbFilterByGrade.TabStop = false;
            this.gbFilterByGrade.Text = "Filter by grade";
            // 
            // UCInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.cboSex);
            this.Controls.Add(this.label3);
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
            this.Name = "UCInformation";
            this.Size = new System.Drawing.Size(902, 384);
            this.Load += new System.EventHandler(this.UCInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvStudents)).EndInit();
            this.gbFilterByGrade.ResumeLayout(false);
            this.gbFilterByGrade.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblGreaterThan;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtLowerGrade;
        private System.Windows.Forms.TextBox txtUpperGrade;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.ComboBox cboSex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Button btnChangeTeacherForm;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_UUID;
        private System.Windows.Forms.DataGridView gvStudents;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblIdentity;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label lblLessThan;
        private System.Windows.Forms.GroupBox gbFilterByGrade;
    }
}
