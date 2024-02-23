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
            this.lbl_ID = new System.Windows.Forms.Label();
            this.ucInfo_Student = new Thuchanh1.UCInformation();
            this.btnChangeTeacherForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(123, 20);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(0, 13);
            this.lbl_ID.TabIndex = 16;
            // 
            // ucInfo_Student
            // 
            this.ucInfo_Student.Location = new System.Drawing.Point(13, 13);
            this.ucInfo_Student.Name = "ucInfo_Student";
            this.ucInfo_Student.Size = new System.Drawing.Size(1002, 444);
            this.ucInfo_Student.TabIndex = 17;
            this.ucInfo_Student.Load += new System.EventHandler(this.ucInfo_Student_Load);
            // 
            // btnChangeTeacherForm
            // 
            this.btnChangeTeacherForm.Location = new System.Drawing.Point(689, 356);
            this.btnChangeTeacherForm.Name = "btnChangeTeacherForm";
            this.btnChangeTeacherForm.Size = new System.Drawing.Size(139, 69);
            this.btnChangeTeacherForm.TabIndex = 18;
            this.btnChangeTeacherForm.Text = "Teacher Form";
            this.btnChangeTeacherForm.UseVisualStyleBackColor = true;
            this.btnChangeTeacherForm.Click += new System.EventHandler(this.BtnChangeTeacherForm_Click);
            // 
            // FStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1027, 469);
            this.Controls.Add(this.btnChangeTeacherForm);
            this.Controls.Add(this.ucInfo_Student);
            this.Controls.Add(this.lbl_ID);
            this.Name = "FStudent";
            this.Text = "Student management";
            this.Load += new System.EventHandler(this.FStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label lbl_ID;
        private UCInformation ucInfo_Student;
        private System.Windows.Forms.Button btnChangeTeacherForm;
    }
}

