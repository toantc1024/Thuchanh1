namespace Thuchanh1
{
    partial class FTeacher
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
            this.btnChangeTeacherForm = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.ucInfo_Teacher = new Thuchanh1.UCInformation();
            this.SuspendLayout();
            // 
            // btnChangeTeacherForm
            // 
            this.btnChangeTeacherForm.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnChangeTeacherForm.Location = new System.Drawing.Point(745, 355);
            this.btnChangeTeacherForm.Name = "btnChangeTeacherForm";
            this.btnChangeTeacherForm.Size = new System.Drawing.Size(178, 35);
            this.btnChangeTeacherForm.TabIndex = 33;
            this.btnChangeTeacherForm.Text = "Change to student form";
            this.btnChangeTeacherForm.UseVisualStyleBackColor = true;
            this.btnChangeTeacherForm.Click += new System.EventHandler(this.btnChangeTeacherForm_Click);
            // 
            // ucInfo_Teacher
            // 
            this.ucInfo_Teacher.Location = new System.Drawing.Point(12, 9);
            this.ucInfo_Teacher.Name = "ucInfo_Teacher";
            this.ucInfo_Teacher.Size = new System.Drawing.Size(947, 391);
            this.ucInfo_Teacher.TabIndex = 34;
            this.ucInfo_Teacher.Load += new System.EventHandler(this.ucInformation1_Load);
            // 
            // FTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(943, 412);
            this.Controls.Add(this.btnChangeTeacherForm);
            this.Controls.Add(this.ucInfo_Teacher);
            this.Name = "FTeacher";
            this.Text = "Teacher management";
            this.Load += new System.EventHandler(this.FGiaoVien_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChangeTeacherForm;
        private System.Windows.Forms.FontDialog fontDialog1;
        private UCInformation ucInfo_Teacher;
    }
}