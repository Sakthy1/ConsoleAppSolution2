using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App04
{
    public class NetworkApp
    {
        private NewsFeed news = new NewsFeed();

        
        public void Run()
        {
            string[] choices = new string[]
            {
                "Add Message Post",
                "Add photo post",
                "Display",
                "quit"
            };
            //int choice = ConsoleHelper.selectChoice(choices);
            //switch(choice)
            bool quit = false;
            while (quit != true)
            {
                int choice = ConsoleHelper.SelectChoice(choices);

                switch (choice)
                {
                    case 1:  break;
                    case 2: break;
                    case 3: break;
                    case 4: break;
                    case 5: quit = true; break;
                }
            }
        }

    }

}

