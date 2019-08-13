using System;

namespace SchoolProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to the University!");
                Console.WriteLine("Select an option from the menu");
                Console.WriteLine("1. Add Degrees in a Program");
                Console.WriteLine("2. Add Student");
                Console.WriteLine("3. Add Teacher");
                Console.WriteLine("4. Validate Student Birthdate");
                Console.WriteLine("5. Exit");

                var option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        AddCourseDetails();
                        break;
                    case "2":
                        AddStudentDetails();
                        break;
                    case "3":
                        AddTeacherDetails();
                        break;
                    case "4":
                        ValidateStudentBirthdate();
                        break;
                    case "5":
                        return;
                    default:
                        break;
                }
            }
        }

        private static void ValidateStudentBirthdate()
        {
            Console.WriteLine("Please enter student id");
            var studentId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the birthdate");
            var birthdate = Console.ReadLine();

            try
            {
                var isValid = Admin.ValidateStudentBirthdate(studentId, birthdate);

                if (isValid)
                {
                    Console.WriteLine("The birthdate is valid");
                }
                else
                {
                    Console.WriteLine("The birthdate is not valid");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An exception occured while validating the birthdate - {ex.Message}");
            }
        }

        private static void AddCourseDetails()
        {
            var p = Enum.GetNames(typeof(UPrograms));
            for (int i = 0; i < p.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {p[i]}");
            }

            var option1 = Console.ReadLine();
            switch (option1)
            {
                case "1":
                    Console.WriteLine("Please selesct a degree");

                    var d = Enum.GetNames(typeof(Degrees));
                    for (int i = 0; i < d.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}. {d[i]}");
                    }

                    int option2 = Convert.ToInt32(Console.ReadLine());

                    if (option2 == 1)
                    {
                        Console.WriteLine("How many courses you want to add in this degree");
                        int option3 = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < option2; i++)
                        {
                            Console.WriteLine("Please enter the course name");
                            var CourseName = Console.ReadLine();

                            Console.WriteLine("Please enter the course Id");
                            int CourseId = Convert.ToInt32(Console.ReadLine());

                            var C = Admin.CreateCourse(CourseName, CourseId);

                            Console.WriteLine($"CourseName=  {C.CourseName}");
                            Console.WriteLine($"CourseId=  {C.CourseId}");
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        private static void AddStudentDetails()
        {
            Console.WriteLine("Please add Student FirstName");
            var FirstName = Console.ReadLine();

            Console.WriteLine("Please add Student LastName");
            var LastName = Console.ReadLine();

            Console.WriteLine("Please add Student Birthdate");
            var Birthdate = Console.ReadLine();

            Console.WriteLine("Please add Student Address Line1");
            var AddressLine1 = Console.ReadLine();

            Console.WriteLine("Please add Student AddressLine2");
            var AddressLine2 = Console.ReadLine();

            Console.WriteLine("Please add Student ZipCode");
            var Zipcode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please add Student City");
            var City = Console.ReadLine();

            Console.WriteLine("Please add Student Country");
            var Country = Console.ReadLine();

            var s = Admin.CreateStudent(FirstName, LastName, Birthdate, AddressLine1, AddressLine2, City, Zipcode, Country);

            Console.WriteLine("(Printing student information");
            Console.WriteLine($"{s.StudentFirstName} {s.StudentLastName} ,{s.StudentId}" +
                $",{s.StudentBithdate}, {s.SAddressLine1}," +
                $" {s.SAddressLine2},{s.StudentCity},{s.StudentZip},{s.SCountry}");
        }

        private static void AddTeacherDetails()
        {
            Console.WriteLine("Please add Teacher FirstName");
            var FirstName = Console.ReadLine();

            Console.WriteLine("Please add Teacher LastName");
            var LastName = Console.ReadLine();

            Console.WriteLine("Please add Teacher Birthdate");
            var Birthdate = Console.ReadLine();

            Console.WriteLine("Please add Teacher Address Line1");
            var AddressLine1 = Console.ReadLine();

            Console.WriteLine("Please add Teacher AddressLine2");
            var AddressLine2 = Console.ReadLine();

            Console.WriteLine("Please add Teacher ZipCode");
            var Zipcode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please add Teacher City");
            var City = Console.ReadLine();

            Console.WriteLine("Please add Teacher Country");
            var Country = Console.ReadLine();

            var t = Admin.CreateTeacher(FirstName, LastName, Birthdate, AddressLine1, AddressLine2, City, Zipcode, Country);

            Console.WriteLine("(Printing teacher information");
            Console.WriteLine($"{t.TeacherFirstName} {t.TeacherLastName} ,{t.TeacherId}" +
                $",{t.TeacherBithdate}, {t.TAddressLine1}," +
                $" {t.TAddressLine2},{t.TeacherCity},{t.TeacherZip},{t.TCountry}");
        }
    }

}