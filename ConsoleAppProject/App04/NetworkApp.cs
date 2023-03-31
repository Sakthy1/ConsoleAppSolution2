using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App04
{
    public class NetworkApp
    {
        private NewsFeed news = new NewsFeed();

        public void DisplayMenu()
        {
            ConsoleHelper.OutputHeading("App04 Social Network");

            Console.WriteLine("which app you want to open");
            Console.WriteLine("1. Add Message Post");
            Console.WriteLine("2. Add Photo Post");
            Console.WriteLine("3. Display all  Posts");
            Console.WriteLine("4. Quit");

            Console.WriteLine(".. Please Enter any number");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                PostMessage();
            }
            else if (choice == "2")
            {
                PostPhoto();
            }
            else if (choice == "3")
            {
                DisplayAll();
            }
        }
        private void DisplayAll()
        {
            ConsoleHelper.OutputTitle("Display All Posts");
            DisplayMenu();
        }

        private void PostPhoto()
        {
            ConsoleHelper.OutputTitle("Add Photo Post");
            DisplayMenu();
        }

        private void PostMessage()
        {
            ConsoleHelper.OutputTitle("Add Photo Post");
            DisplayMenu();
        }

        private void Quit()
        {

        }
    }

}

