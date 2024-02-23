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


    internal class StudentDAO : PersonDAO
    {

        public StudentDAO():base(objectName: "Student")
        {
               
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
            return base.DBConnection.QueryAdapterExecute(sqlStr);
        }
       

    }
}
