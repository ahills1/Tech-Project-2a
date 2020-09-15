// Programmer: Ashley Hills
// Project: Tech Project 2a
// Date: 09/14/2020
// Description: A console program that demonstrates the use of iterative statements
using System;

namespace Tech_Project__2a
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input from user 
            Console.WriteLine("Enter an integer value between 1 and 25: ");
            
            try
            {
                string input = Console.ReadLine();
                int value_of_input = int.Parse(input);

                if ((value_of_input >= 1) && (value_of_input <= 25))
                {
                    Console.WriteLine("Will utilize a For Loop to run the iterative statements seen below");
                    Console.WriteLine("The For Loop will iterate  " + value_of_input.ToString() + "  times.");

                    for (int i = 0; i < value_of_input; i++)
                    {
                        Console.WriteLine("You have entered " + value_of_input.ToString() +"." + "  This is the current integer value in the loop: " + i.ToString());
                    }
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }

                else
                {
                    Console.WriteLine("Please enter an integer between 1 and 25 and try again...");
                    Console.WriteLine("Press any key to exit the program and try again...");
                    Console.ReadKey(true);
                }
            }
            catch
            {
                Console.WriteLine("Please enter an integer value and try again...");
                Console.WriteLine("Press any key to exit the program...");
                Console.ReadKey(true);
            }
        }
    }
}
