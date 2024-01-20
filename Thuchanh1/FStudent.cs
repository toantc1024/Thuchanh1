using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Thuchanh1
{
    public partial class FStudent : Form
    {
        StudentDAO studentDAO = new StudentDAO();
        
        public FStudent()
        {
            InitializeComponent();
        }

        public void LoadDataFromStudentDAO()
        {
            DataTable dtSinhVien = studentDAO.Load();
            gvStudents.DataSource = dtSinhVien;
        }


        public void LoadDataFromRow(DataGridViewRow row)
        {
            lbl_ID.Text = row.Cells[0].Value.ToString();
            txtFullName.Text = row.Cells[1].Value.ToString();
            txtAddress.Text = row.Cells[2].Value.ToString();
            txtID.Text = row.Cells[3].Value.ToString();
            txtPhoneNumber.Text = row.Cells[5].Value.ToString();
            txtEmail.Text = row.Cells[6].Value.ToString();
            cboSex.Text = row.Cells[7].Value.ToString();
        }

        private void GvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDataFromRow(gvStudents.SelectedRows[0]);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = new Student(txtFullName.Text, txtID.Text, txtAddress.Text, dtpBirthDate.Value, txtPhoneNumber.Text, txtEmail.Text, cboSex.Text);
                studentDAO.Add(student);
                LoadDataFromStudentDAO();
            } catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string id = lbl_ID.Text;
                if(id.Length == 0)
                {
                    throw new Exception("Could you provide id for me? then I can help you.");
                }
                studentDAO.Delete(id);
                LoadDataFromStudentDAO();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = new Student(txtFullName.Text, txtID.Text, txtAddress.Text, dtpBirthDate.Value, txtPhoneNumber.Text, txtEmail.Text, cboSex.Text);
                studentDAO.Edit(student);
                LoadDataFromStudentDAO();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void ResetForm()
        {
            txtAddress.Clear();
            txtFullName.Clear();
            txtID.Clear();
            txtPhoneNumber.Clear();
            lbl_ID.Text = "";
            txtEmail.Text = "";
            cboSex.Text = "";
        }

        private void BtnChangeTeacherForm_Click(object sender, EventArgs e)
        {
            FTeacher fGiaoVien = new FTeacher();
            fGiaoVien.Show();
            this.Hide();
        }

        private void FStudent_Load(object sender, EventArgs e)
        {
            LoadDataFromStudentDAO();
        }

    }
}
