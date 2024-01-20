using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thuchanh1
{


    internal class TeacherDAO
    {

        DBConnection dBConnection = new DBConnection(Properties.Settings.Default.connStr);

        public DataTable Load()
        {
            return dBConnection.LoadDataFromTable("Teacher");
        }

        public void Delete(string id)
        {
            string sqlStr = string.Format("DELETE FROM Teacher WHERE id = '{0}'", id);
            dBConnection.QueryCommandExecute(sqlStr);
        }

        public void Edit(Teacher teacher)
        {
            string sqlStr = string.Format("UPDATE Teacher SET fullName = '{0}', address = '{1}', dateOfBirth = '{2}', phoneNumber = {4}, sex = {5} WHERE governmentId = {3}", teacher.fullName, teacher.address, teacher.dateOfBirth.ToString(), teacher.phoneNumber, teacher.sex, teacher.governmentId);
            dBConnection.QueryCommandExecute(sqlStr);
        }

        public void Add(Teacher teacher)
        {
            string sqlStr = string.Format("INSERT INTO Teacher(fullName, address, governmentId, dateOfBirth, phoneNumber, email, sex) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", teacher.fullName.ToString(), teacher.address.ToString(), teacher.governmentId.ToString(), teacher.dateOfBirth.ToString(), teacher.phoneNumber.ToString(), teacher.email.ToString(), teacher.sex);
            dBConnection.QueryCommandExecute(sqlStr);
        }
    }
}
