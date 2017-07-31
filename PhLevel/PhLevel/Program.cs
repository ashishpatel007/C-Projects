/*
 * Write an application that will enable you to display an aquarium's pH level.
 * The pH is a meaasure of the aquarium water's alkalinity and is typically given
 * on a 0-14 scale. For most freshwater fish tanks, 7 is neutral. Tanks with a pH
 * lower than 7 are considered acidic. Tanks with a pH higher than 7 are alkaline.
 * Alloww the user to input the pH level number. Display a message indicating the
 * health (i.e., acidic, neutral, or alkaline) of the aquarium.
 * 
 */
using System;

namespace PhLevel
{
    class Program
    {
        static void Main(string[] args)
        {
            int pH;

            //The order of the if statements matter
            Console.WriteLine("Please enter the pH level: ");
            if (int.TryParse(Console.ReadLine(), out pH) == false || pH < 0 || pH > 14)
                Console.WriteLine("Invalid Input");
            else if (pH < 7)
                Console.WriteLine("pH is Acidic");
            else if (pH > 7)
                Console.WriteLine("pH is Alkaline");
            else
                Console.WriteLine("pH is neutral");
        }
    }
}
