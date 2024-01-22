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
            string sqlStr = string.Format("UPDATE Student SET fullName = '{0}', address = '{1}', dateOfBirth = '{2}', phoneNumber = {3}, sex = {4}, grade = {5}, email = {6} WHERE governmentId = {7}", student.fullName, student.address, student.dateOfBirth.ToString(), student.phoneNumber, student.sex,  student.grade, student.email, student.governmentId);
            dBConnection.QueryCommandExecute(sqlStr);
        }

        public void Add(Student student)
        {
           string sqlStr = string.Format("INSERT INTO Student(fullName, address, governmentId, dateOfBirth, phoneNumber, email, sex, grade) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", student.fullName.ToString(), student.address.ToString(), student.governmentId.ToString(), student.dateOfBirth.ToString(), student.phoneNumber.ToString(), student.email.ToString(), student.sex, student.grade);
            dBConnection.QueryCommandExecute(sqlStr);
        }

        public float TryParseFloat(string str, float defaultValue)
        {
            float result = defaultValue;
            try
            {
                result = float.Parse(str);
            }
            catch
            {
                return defaultValue;
            }
            return result;
        }

        public DataTable FilterStudentByGrade(string min, string max)
        {
            float lowerGrade = TryParseFloat(min, 0.0f);
            float upperGrade = TryParseFloat(max, 10.0f);
            string sqlStr = string.Format("SELECT * FROM Student WHERE grade >= {0} AND grade <= {1}", lowerGrade, upperGrade);
            return dBConnection.QueryAdapterExecute(sqlStr);
        }
       

    }
}
