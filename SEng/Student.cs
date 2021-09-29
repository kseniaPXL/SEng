using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEng
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private string email;
        private string studentNumber;
        private string group;
        public string Group { get; set; }

        public Student(string firstName, string lastName, string email, string studentNumber, string group ):
            this(firstName, lastName, email,studentNumber)
        {
            this.group = group;
        }

        public Student(string firstName, string lastName, string email, string studentNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.studentNumber = studentNumber;
            this.group = null;
        }


    }
}
