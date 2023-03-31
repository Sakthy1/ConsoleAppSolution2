using System;
using System.Collections.Generic;

namespace ConsoleAppProject.App04
{
  
    public class MessagePost : Post
    {
        private int likes;

        private readonly List<String> comments;


       
        // an arbitrarily long, multi-line message
        public String Message { get; }


        /// <summary>
        /// Constructor for objects of class MessagePost.
        /// </summary>
        /// <param name="author">
        /// The username of the author of this post.
        /// </param>
        /// <param name="text">
        /// The text of this post.
        /// </param>
        public MessagePost(String author, String text): base(author)
        {
            Message = text;
        }

        


        ///<summary>
        /// Display the details of this post.
        /// 
        /// (Currently: Print to the text terminal. This is simulating display 
        /// in a web browser for now.)
        ///</summary>
        public override void Display()
        {
            Console.WriteLine();
            Console.WriteLine($"    Message: {Message}");
            Console.WriteLine();

          
        }

        
    }
}
