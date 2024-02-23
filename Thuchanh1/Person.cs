using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Thuchanh1
{
    public class Person
    {
        public Person(string fullName, string address, string governmentId, DateTime dt, string phoneNumber, string email, string sex)
        {
            this.governmentId = governmentId;
            this.address = address;
            this.fullName = fullName;
            this.dateOfBirth = dt;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.sex = sex;
            Validator();
        }


        private bool isEmpty(string str)
        {
            string testStr = str.Trim();
            return string.IsNullOrEmpty(testStr);
        }

        public void isBlankValidate()
        {
            PropertyInfo[] properties = this.GetType().GetProperties();
            foreach (PropertyInfo property in properties)
            {
                if (property.PropertyType == typeof(string))
                {
                    string value = (string)property.GetValue(this);
                    if (isEmpty(value))
                    {
                        throw new Exception(property.Name + " is empty");
                    }
                }
            }

        }

        public void Validator()
        {
            // check whether governMentId, address, phoneNumber, ... is not empty string 

            // loop throguh properties of this class
            isBlankValidate();

            if (getAge() < 17)
            {
                throw new Exception("Age must >= 17");
            }
            if (!IsValidPhoneNumber())
            {
                throw new Exception("The number phone isn't valid (xxx-xxxx-xxx) - x is number!");
            }
            if(!IsValidEmail())
            {
                throw new Exception("Email isn't valid format");
            }
        }
        private bool IsValidPhoneNumber()
        {
            string regex = @"^\(?([0-9]{3})\)?[-]([0-9]{4})[-]([0-9]{3})$";
            return Regex.IsMatch(phoneNumber, regex);
        }

        private bool IsValidEmail()
        {
            string regex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            return Regex.IsMatch(email, regex);
        }
        public int getAge()
        {
            int age = (int)Math.Floor((DateTime.Now - dateOfBirth).TotalDays / 365.25D);
            return age;
        }

        public string GetIntroduce()
        {
            return string.Format("'{0}', '{1}', '{2}', '{3}', '{4}'", fullName, address, governmentId, dateOfBirth.ToShortDateString(), phoneNumber);
        }

        public string fullName;
        public string sex;
        public string email;
        public string phoneNumber;
        public DateTime dateOfBirth;
        public string governmentId;
        public string address;                      
    }
}
