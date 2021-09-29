using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEng
{
    public class Students
    {
        private IList<Student> allStudents = new List<Student>();
        public IList<Student> ListOfStudents { get; }
        public void AddStudent(Student student)
        {
            allStudents.Add(student);
        }
        public IList<Student> GetAllStudentsWhithGroup()
        {
            return null;
        }
        public IList<Student> GetAllStudentsWhitouthGroup()
        {
            return null;
        }
    }
}
