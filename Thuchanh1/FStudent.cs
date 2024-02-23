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
            ucInfo_Student.BtnAdd.Click += BtnAdd_Click;
            ucInfo_Student.BtnDelete.Click += BtnDelete_Click;
            ucInfo_Student.BtnEdit.Click += BtnEdit_Click;
            ucInfo_Student.BtnSubmit.Click += btnSubmit_Click;
            //ucInfo_Student.BtnChangeTeacherForm.Click += BtnChangeTeacherForm_Click;
            ucInfo_Student.GvData.CellContentClick += GvStudents_CellContentClick;
            ucInfo_Student.GvData.CellClick += GvStudents_CellContentClick;
        }

        public void LoadDataFromStudentDAO()
        {
            DataTable dtSinhVien = studentDAO.Load();
            ucInfo_Student.GvData.DataSource = dtSinhVien;
        }


        public void LoadDataFromRow(DataGridViewRow row)
        {
            ucInfo_Student.Lbl_ID.Text = row.Cells[0].Value.ToString();
            ucInfo_Student.TxtFullName.Text = row.Cells[1].Value.ToString();
            ucInfo_Student.TxtAddress.Text = row.Cells[2].Value.ToString();
            ucInfo_Student.TxtID.Text = row.Cells[3].Value.ToString();
            ucInfo_Student.TxtPhoneNumber.Text = row.Cells[5].Value.ToString();
            ucInfo_Student.TxtEmail.Text = row.Cells[6].Value.ToString();
            ucInfo_Student.CboSex.Text = row.Cells[7].Value.ToString();
        }

        private void GvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDataFromRow(ucInfo_Student.GvData.SelectedRows[0]);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = new Student(ucInfo_Student.TxtFullName.Text, ucInfo_Student.TxtID.Text, ucInfo_Student.TxtAddress.Text, ucInfo_Student.DtpBirthDate.Value, ucInfo_Student.TxtPhoneNumber.Text, ucInfo_Student.TxtEmail.Text, ucInfo_Student.CboSex.Text, float.Parse(ucInfo_Student.TxtGrade.Text));
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
                string id = ucInfo_Student.Lbl_ID.Text;
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
                Student student = new Student(ucInfo_Student.TxtFullName.Text, ucInfo_Student.TxtID.Text, ucInfo_Student.TxtAddress.Text, ucInfo_Student.DtpBirthDate.Value, ucInfo_Student.TxtPhoneNumber.Text, ucInfo_Student.TxtEmail.Text, ucInfo_Student.CboSex.Text, float.Parse(ucInfo_Student.TxtGrade.Text));
                

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
            ucInfo_Student.TxtAddress.Clear();
            ucInfo_Student.TxtFullName.Clear();
            ucInfo_Student.TxtID.Clear();
            ucInfo_Student.TxtPhoneNumber.Clear();
            ucInfo_Student.Lbl_ID.Text = "";
            ucInfo_Student.TxtEmail.Text = "";
            ucInfo_Student.CboSex.Text = "";
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


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DataTable students = studentDAO.FilterStudentByGrade(ucInfo_Student.TxtLowerGrade.Text, ucInfo_Student.TxtUpperGrade.Text);
            ucInfo_Student.GvData.DataSource = students;

        }

        private void ucInfo_Load(object sender, EventArgs e)
        {

        }

        private void ucInfo_Student_Load(object sender, EventArgs e)
        {

        }
    }
}
