using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProgram
{
    class Student

    {
        
        public static int lastStudentId = 0;

        public String StudentName { get; set; }
        public int StudentId { get; set; }



        
        public Student()
        { 

            StudentId = lastStudentId++;
        }


    }
}
