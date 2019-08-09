using System;

namespace SchoolProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the University!");

            Console.WriteLine("Please select a Program");

            var p = Enum.GetNames(typeof(UPrograms));
            for (int i = 0; i < p.Length; i++)
            {
                Console.WriteLine($"{i+1}. {p[i]}");
            }
            var option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.WriteLine("Please selesct a degree");

                    var d = Enum.GetNames(typeof(Degrees));
                    for(int i = 0; i < d.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}. {d[i]}");
                    }

                    int option1 = Convert.ToInt32(Console.ReadLine());

                    if (option1==1)
                    {
                        Console.WriteLine("How many courses you want to add in this degree");
                        int option2 = Convert.ToInt32(Console.ReadLine());

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
    }
}
