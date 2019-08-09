using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolProgram
{
   static class Admin
    {
        public static List<Student> AllStudents = new List<Student>();
        public static List<Course> AllCourses = new List<Course>();
        public static List<Teacher> AllTeachers = new List<Teacher>();

        public static Student CreateStudent(string name)
        {
            var student = new Student();
            student.StudentName = name;
            AllStudents.Add(student);

            return student;


        }

       

        public static Teacher CreateTeacher(string name)
        {
            var teacher = new Teacher();
            teacher.TeacherName = name;
            AllTeachers.Add(teacher);

            return teacher;


        }

        public static Course CreateCourse(String name,int id)
        {
            var course = new Course();
            course.CourseName = name;
            course.CourseId = id;
            AllCourses.Add(course);

            return course;

        }


    }
}
