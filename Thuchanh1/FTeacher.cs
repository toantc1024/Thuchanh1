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
            ucInfo_Teacher.GvData.DataSource = teacherDAO.Load();
        }

        public FTeacher()
        {
            InitializeComponent();
            ucInfo_Teacher.BtnAdd.Click += BtnAdd_Click;
            ucInfo_Teacher.BtnDelete.Click += BtnDelete_Click;
            ucInfo_Teacher.BtnEdit.Click += BtnEdit_Click;
            ucInfo_Teacher.GvData.CellContentClick += gvTeachers_CellContentClick;
            ucInfo_Teacher.GvData.CellClick += gvTeachers_CellContentClick;
            
            ucInfo_Teacher.LblGrade.Visible = false;
            ucInfo_Teacher.TxtGrade.Visible = false;

            ucInfo_Teacher.GbFilterByGrade.Visible = false;

        }




        private void FGiaoVien_Load(object sender, EventArgs e)
        {
            LoadDataFromServer();
        }


        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Teacher teacher = new Teacher(ucInfo_Teacher.TxtFullName.Text, ucInfo_Teacher.TxtID.Text, ucInfo_Teacher.TxtAddress.Text, ucInfo_Teacher.DtpBirthDate.Value, ucInfo_Teacher.TxtPhoneNumber.Text, ucInfo_Teacher.TxtEmail.Text, ucInfo_Teacher.CboSex.Text);
                teacherDAO.Add(teacher);
                ucInfo_Teacher.GvData.DataSource = teacherDAO.Load();

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
                string id = ucInfo_Teacher.Lbl_ID.Text;
                if (id.Length == 0)
                {
                    throw new Exception("Could you provide id for me? then I can help you.");
                }
                teacherDAO.Delete(id);
                ucInfo_Teacher.GvData.DataSource = teacherDAO.Load();
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
                Teacher teacher = new Teacher(ucInfo_Teacher.TxtFullName.Text, ucInfo_Teacher.TxtID.Text, ucInfo_Teacher.TxtAddress.Text, ucInfo_Teacher.DtpBirthDate.Value, ucInfo_Teacher.TxtPhoneNumber.Text, ucInfo_Teacher.TxtEmail.Text, ucInfo_Teacher.CboSex.Text);
                ucInfo_Teacher.GvData.DataSource = teacherDAO.Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        public void LoadDataFromRow(DataGridViewRow row)
        {
            ucInfo_Teacher.Lbl_ID.Text = row.Cells[0].Value.ToString();
            ucInfo_Teacher.TxtFullName.Text = row.Cells[1].Value.ToString();
            ucInfo_Teacher.TxtAddress.Text = row.Cells[2].Value.ToString();
            ucInfo_Teacher.TxtID.Text = row.Cells[3].Value.ToString();
            ucInfo_Teacher.DtpBirthDate.Value = DateTime.Parse(row.Cells[4].Value.ToString());
            ucInfo_Teacher.TxtPhoneNumber.Text = row.Cells[5].Value.ToString();
            ucInfo_Teacher.TxtEmail.Text = row.Cells[6].Value.ToString();
            ucInfo_Teacher.CboSex.Text = row.Cells[7].Value.ToString();
        }

        private void GvStudents_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LoadDataFromRow(ucInfo_Teacher.GvData.SelectedRows[0]);
        }

        private void btnChangeTeacherForm_Click(object sender, EventArgs e)
        {
            FStudent fHocSinh = new FStudent();
            fHocSinh.Show();
            this.Hide();
        }

        private void gvTeachers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDataFromRow(ucInfo_Teacher.GvData.SelectedRows[0]);
        }

        private void ucInformation1_Load(object sender, EventArgs e)
        {

        }
    }
}
