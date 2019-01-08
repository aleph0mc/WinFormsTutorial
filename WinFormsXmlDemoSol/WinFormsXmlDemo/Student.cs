using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsXmlDemo
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int TotalMarks { get; set; }

        public static Student[] GetAllStudents()
        {
            var arrStudents = new Student[]
            {
                new Student {Id = 101, Name="Andrew", Gender = "Male", TotalMarks = 800},
                new Student {Id = 102, Name="Moira", Gender = "Female", TotalMarks = 900},
                new Student {Id = 103, Name="Pam", Gender = "Female", TotalMarks = 850},
                new Student {Id = 104, Name="Milko", Gender = "Male", TotalMarks = 950},
            };

            return arrStudents;
        }
    }
}
