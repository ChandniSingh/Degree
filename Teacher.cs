using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProgram
{
    class Teacher
    {
        public static int lastTeacherId = 0;

        public String TeacherName { get; set; }
        public int TeacherId { get; set; }




        public Teacher()
        {

            TeacherId = lastTeacherId++;
        }
    }
}
