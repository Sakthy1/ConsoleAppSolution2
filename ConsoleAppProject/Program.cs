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
 
            DistanceConverter distanceConverter = new DistanceConverter();
 
            BMI bmiConverter = new BMI();
            
            StudentGrades gradesConverter = new StudentGrades();

            NetworkApp app04 = new NetworkApp();

            string[] menu = new string[] 
            {
                "  Distance Converter",
                "  BMI Calculator",
                "  Student Grade & Marks",
                "  Social Network"
            };

            int choice = ConsoleHelper.SelectChoice(menu);

            Console.WriteLine();

            if (choice == 1)
            {
                Console.Clear();
                distanceConverter.Run();
            }
            else if (choice == 2)
            {
                Console.Clear();
                bmiConverter.Run();
            }
            else if (choice == 3)
            {
                Console.Clear();
                gradesConverter.Run();
            }
            else if (choice == 4)
            {
                Console.Clear();
                app04.Run();
            }
            else
            {
                Console.WriteLine(" Invalid Choice !");
            }
        }
    }
}
