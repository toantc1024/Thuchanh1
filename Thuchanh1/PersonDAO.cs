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


    internal class PersonDAO
    {
        private string objectName;
        
        public string ObjectName
        {
            get { return objectName; }
            set { objectName = value; }
        }

        public DBConnection DBConnection
        {
            get { return dBConnection; }
            set { dBConnection = value; }
        }

        public PersonDAO(string objectName)
        {
            ObjectName=objectName;

        }

        DBConnection dBConnection = new DBConnection(Properties.Settings.Default.connStr);

        public DataTable Load()
        {
            return dBConnection.LoadDataFromTable(ObjectName);
        }

        public void Delete(string id)
        {
            string sqlStr = $"DELETE FROM {ObjectName} WHERE id = '{id}'";
            dBConnection.QueryCommandExecute(sqlStr);
        }


        public void Edit(Person person)
        {

            // apply oop to parse data from student


            string sqlStr = string.Format($"UPDATE ${ObjectName} SET fullName = '{person.fullName}', address = '{person.address}', dateOfBirth = '{person.dateOfBirth.ToString()}', phoneNumber = {person.phoneNumber}, sex = {person.sex}, grade = 10, email = {person.email} WHERE governmentId = {person.governmentId}");
            dBConnection.QueryCommandExecute(sqlStr);
        }

        public void Add(Person person)
        {
            string sqlStr = string.Format($"INSERT INTO {ObjectName}(fullName, address, governmentId, dateOfBirth, phoneNumber, email, sex, grade) VALUES ('{person.fullName}', '{person.address}', '{person.governmentId}', '{person.dateOfBirth.ToString()}', '{person.phoneNumber}', '{person.email}', '{person.sex}', '10')");
            dBConnection.QueryCommandExecute(sqlStr);
        }

      
       

    }
}
