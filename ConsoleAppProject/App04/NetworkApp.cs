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

        private void addPosts()
        {
            MessagePost post1 = new MessagePost("Name", "Hello world");
            PhotoPost post2 = new PhotoPost("Name", "myDog.png", "Photo of Roger");

            news.AddPhotoPost(post2);
            news.AddMessagePost(post1);
        }

        public void Run()
        {
            addPosts();
            DisplayMenu();
        }

        public void DisplayMenu()
        {
            ConsoleHelper.OutputHeading("App04 Social Network");

            Console.WriteLine("which app you want to open");
            
            Console.WriteLine("1. Add Message Post");
            Console.WriteLine("2. Add Photo Post");
            Console.WriteLine("3. Display all  Posts");
            Console.WriteLine("4. Quit");

            Console.Write(".. Please Enter any number");

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
            news.Display();

            DisplayMenu();
        }

        private void PostPhoto()
        {
            ConsoleHelper.OutputTitle("Add Photo Post");
            
            //todo Ask  the user for their name, image and caption
            //  use news class

            DisplayMenu();
        }

        private void PostMessage()
        {
            ConsoleHelper.OutputTitle("Add Photo Post");

            //todo Ask  the user for their name and message
            //  use news class

            DisplayMenu();
        }

        private void Quit()
        {

        }
    }

}

