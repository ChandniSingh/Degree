using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProgram
{
    class Teacher
    {
        public static int lastTeacherId = 0;

        public String TeacherFirstName { get; set; }

        public int TeacherId { get; set; }

        public String TeacherLastName { get; set; }

        public String TeacherBithdate { get; set; }

        public String TAddressLine1 { get; set; }

        public String TAddressLine2 { get; set; }

        public String TeacherCity { get; set; }

        public int TeacherZip { get; set; }

        public String TeacherState { get; set; }

        public String TCountry { get; set; }

        public Teacher()
        {
            TeacherId = lastTeacherId++;
        }
    }
}
