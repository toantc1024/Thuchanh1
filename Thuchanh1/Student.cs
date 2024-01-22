using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Thuchanh1
{
    public class Student : Person
    {
        public float grade;

        public Student(string fullName, string governmentId, string addr, DateTime dt, string phoneNumber, string email, string sex, float grade) : base(fullName, addr, governmentId, dt, phoneNumber,  email, sex)
        {
            this.grade = grade;
        }
     
    }
}