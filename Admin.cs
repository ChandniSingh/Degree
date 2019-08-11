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

        public static Student CreateStudent(string firstname, string lastname, String birthdate,
            string addressline1, string addressline2, string city, int zip, string country)
        {
            var student = new Student();
            student.StudentFirstName=firstname;
            student.StudentLastName = lastname;
            student.StudentBithdate = birthdate;
            student.SAddressLine1 = addressline1;
            student.SAddressLine2 = addressline2;
            student.StudentCity = city;
            student.StudentZip = zip;
            student.SCountry = country;

            AllStudents.Add(student);

            return student;
        }

        public static Teacher CreateTeacher(string firstname,string lastname,string birthdate,
            string addressline1,string addressline2,string city,int zip,string country)
        {
            var teacher = new Teacher();
            teacher.TeacherFirstName = firstname;
            teacher.TeacherLastName = lastname;
            teacher.TeacherBithdate = birthdate;
            teacher.TAddressLine1 = addressline1;
            teacher.TAddressLine2 = addressline2;
            teacher.TeacherCity = city;
            teacher.TeacherZip = zip;
            teacher.TCountry = country;
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
