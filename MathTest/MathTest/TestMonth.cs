/*
 * Create a Month class that has a single data member of month member. Include a 
 * member method that returns the name of the month and another method that returns
 * the number of days in the month. The ToString() method should return the name and
 * number of days. Write a second class to test your Months class. The second class
 * should allow the user to input a month number. Display the name of the month
 * associated with the number entered and the number of days in that months.
 * For this exercise, use 28 for February. If the user inputs an invalid entry, 
 * display an appropriate message.
 * 
 */
using System;

namespace MathTest
{
    class TestMonth
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the month number: ");
            int monthNumber = Convert.ToInt32(Console.ReadLine()); //conver to integer

            Month month = new Month(monthNumber);

            Console.WriteLine(month);
        }
    }
}
