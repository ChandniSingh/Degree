using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProgram
{
    class Student
    {
        public static int lastStudentId = 0;

        public String StudentFirstName { get; set; }

        public int StudentId { get; set; }

        public String StudentLastName { get; set; }

        public String StudentBithdate { get; set; }

        public String SAddressLine1 { get; set; }

        public String SAddressLine2 { get; set; }

        public String StudentCity { get; set; }

        public int StudentZip { get; set; }

        public String SCountry { get; set; }

        public Student()
        {
            StudentId = lastStudentId++;
        }

        public bool ValidateBirthdate(string birthdate)
        {
            throw new NotImplementedException("The method has no been implemented yet");
        }
    }
}
