using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.App04;
using ConsoleAppProject.Helpers;




namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// 
    ///
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("    BNU CO453 Applications Programming 2022-2023!" +
                              "     By Shakthy "                                  );
            Console.WriteLine(" =================================================");
            Console.WriteLine();
            Console.Beep();

            StudentGrades Stu = new StudentGrades();


           // BMI calculator = new BMI();
            //calculator.Run();

            StudentGrades student = new StudentGrades();
            student.Run();


            BMI calculator = new BMI();
           // calculator.Run
            DistanceConverter converter = new DistanceConverter();
            converter.Run();

            BMI converter1 = new BMI();
            converter1.Run();
            
          StudentGrades convert = new StudentGrades();
            convert.Run();

           // Post posts = new Post();
           // posts.Run();

            string[] menu = new string[3];
            menu[0] = " Distance Converter";
            menu[1] = " BMI Calculator";
            menu[2] = " Student Grade & Marks";

            int choice = ConsoleHelper.SelectChoice(menu);
            Console.WriteLine();

            if (choice == 1)
            {
                Console.Clear();
                converter.Run();
            }
            else if (choice == 2)
            {
                Console.Clear();
                calculator.Run();
            }
            else if (choice == 3)
            {
                Console.Clear();
                Stu.Run();
            }
            else if (choice == 4)
            {
                Console.Clear();
                //posts.Run();
            }
            else
            {
                Console.WriteLine(" Invalid Choice !");
            }


        }
    }
}
