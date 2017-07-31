/*
 * Design a message display application. Allow users to enter their name and
 * favorite saying in a single method that gets invoked two times. First call 
 * the method asking for the person's name. Send a string argument indicating 
 * what value should be entered. Invoke the method a second time to retreive the 
 * favorite saying. Return the string values back to the Main() method. Call 
 * another method, sending the name and saying. From the method, display the 
 * message showing the person's name and their saying surrounded by rows of 
 * greater than/lesss than symbols(<><><>).
 */

using System;

namespace FavouriteSaying
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Message("name");
            string phrase = Message("favorite saying");

            DisplayOutput(name, phrase);

        }

        public static string Message(string msg)
        {
            Console.WriteLine("Please enter your {0}: ", msg);
            return Console.ReadLine();
        }

        public static void DisplayOutput(string name, string phrase)
        {
            Console.WriteLine("\n<><><><><><><><><><><><><><><><><><><><><><><><>"); 
            Console.WriteLine("Your name is {0}", name);
            Console.WriteLine("Your favorite saying is {0}", phrase);
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><>\n");
		}
    }
}
