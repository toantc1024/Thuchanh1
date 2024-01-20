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


    internal class StudentDAO
    {

        DBConnection dBConnection = new DBConnection(Properties.Settings.Default.connStr);
       
        public DataTable Load()
        {
            return dBConnection.LoadDataFromTable("Student");
        }
        
        public void Delete(string id)
        {
            string sqlStr = string.Format("DELETE FROM Student WHERE id = '{0}'", id);
            dBConnection.QueryCommandExecute(sqlStr);
        }

      
        public void Edit(Student student)
        {
            string sqlStr = string.Format("UPDATE Student SET fullName = '{0}', address = '{1}', dateOfBirth = '{2}', phoneNumber = {4}, sex = {5} WHERE governmentId = {3}", student.fullName, student.address, student.dateOfBirth.ToString(), student.phoneNumber, student.sex, student.governmentId);
            dBConnection.QueryCommandExecute(sqlStr);
        }

        public void Add(Student student)
        {
           string sqlStr = string.Format("INSERT INTO Student(fullName, address, governmentId, dateOfBirth, phoneNumber, email, sex) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", student.fullName.ToString(), student.address.ToString(), student.governmentId.ToString(), student.dateOfBirth.ToString(), student.phoneNumber.ToString(), student.email.ToString(), student.sex);
            dBConnection.QueryCommandExecute(sqlStr);
        }
    }
}
