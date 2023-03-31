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
            Console.WriteLine("which app you want to open");
            Console.WriteLine("Select of the number");
            Console.WriteLine("1. Message Post");
            Console.WriteLine("2. photo Post");
            Console.WriteLine("3. Display all  Posts");


            Console.WriteLine("3.. Please Enter any number");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                postMessage();
            }
            else if (choice == "2")
            {
                postPhoto();
            }
            else
            {
                postAll();
            }
        }
            private void postAll()
            {
                
            }
            private void postPhoto()
            {
                
            }
            private void postMessage()
            {
                
            }



        
        

    }

}

