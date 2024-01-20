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

namespace Thuchanh1
{
    public partial class FTeacher : Form
    {
        TeacherDAO teacherDAO = new TeacherDAO();


        public void LoadDataFromServer()
        {
            gvTeachers.DataSource = teacherDAO.Load();
        }

        public FTeacher()
        {
            InitializeComponent();
        }




        private void FGiaoVien_Load(object sender, EventArgs e)
        {
            LoadDataFromServer();
        }


        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Teacher teacher = new Teacher(txtFullName.Text, txtID.Text, txtAddress.Text, dtpBirthDate.Value, txtPhoneNumber.Text, txtEmail.Text, cboSex.Text);
                teacherDAO.Add(teacher);
                gvTeachers.DataSource = teacherDAO.Load();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string id = lbl_ID.Text;
                if (id.Length == 0)
                {
                    throw new Exception("Could you provide id for me? then I can help you.");
                }
                teacherDAO.Delete(id);
                gvTeachers.DataSource = teacherDAO.Load();
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
                Teacher teacher = new Teacher(txtFullName.Text, txtID.Text, txtAddress.Text, dtpBirthDate.Value, txtPhoneNumber.Text, txtEmail.Text, cboSex.Text);
                gvTeachers.DataSource = teacherDAO.Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        public void LoadDataFromRow(DataGridViewRow row)
        {
            lbl_ID.Text = row.Cells[0].Value.ToString();
            txtFullName.Text = row.Cells[1].Value.ToString();
            txtAddress.Text = row.Cells[2].Value.ToString();
            txtID.Text = row.Cells[3].Value.ToString();
            dtpBirthDate.Value = DateTime.Parse(row.Cells[4].Value.ToString());
            txtPhoneNumber.Text = row.Cells[5].Value.ToString();
            txtEmail.Text = row.Cells[6].Value.ToString();
            cboSex.Text = row.Cells[7].Value.ToString();
        }

        private void GvStudents_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LoadDataFromRow(gvTeachers.SelectedRows[0]);
        }

        private void btnChangeTeacherForm_Click(object sender, EventArgs e)
        {
            FStudent fHocSinh = new FStudent();
            fHocSinh.Show();
            this.Hide();
        }

        private void gvTeachers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDataFromRow(gvTeachers.SelectedRows[0]);
        }
    }
}
