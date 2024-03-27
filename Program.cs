using System;

namespace Methods_Bruner_Zach
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enters a whole number 
            Console.WriteLine("Please enter a whole number!");
                int x = Convert.ToInt32(Console.ReadLine());
            // Enters a whole number
            Console.WriteLine("Please enter another whole number!");
            int y = Convert.ToInt32(Console.ReadLine());
            // Multiplys the x number and y number and prints to console
            Console.WriteLine(Multiply(x, y));
            // Ask for a name.
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            // Welcomes the user 
            WelcomeUser(name);
            // Says goodbye to the user
            Goodbye();
        }
        // Multiplys num1 and num2
        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        // Welcomes user with their name and says its nice to meet you.
        static void WelcomeUser(string username)
        {
            Console.WriteLine($"Hello, {username}! It is nice to meet you!");
        } 

        /// <summary>
        /// Prints a goodbye message to the console
        /// </summary>

        static void Goodbye()
        {
            Console.WriteLine("Have a fantastic day!");
        }
    }
}