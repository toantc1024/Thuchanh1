using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Thuchanh1
{
    public class Person
    {
        public int a;
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


        public void Validator()
        {
            if(!(governmentId.Length > 0 || address.Length > 0 || fullName.Length > 0 || phoneNumber.Length > 0 || email.Length > 0 || sex.Length > 0))
            {
                throw new Exception("We couldn't update your data with blank field!");
            }
            if(getAge() < 18)
            {
                throw new Exception("Under 18 year old");
            }
            if (!IsValidPhoneNumber())
            {
                throw new Exception("The number phone isn't valid (VN Format)");
            }
            if(!IsValidEmail())
            {
                throw new Exception("Email isn't valid format");
            }
        }
        private bool IsValidPhoneNumber()
        {
            string regex = @"^0[12356789]\d{8}$";
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
