using System;

namespace Methods_Henderson_Bobby
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a whole number!");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter a whole number!");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Multiply(x,y));

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            WelcomeUser(name);

            Goodbye();
        }

        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        /// <summary>
        /// prints a goodbye message to the console.
        /// </summary>
        static void WelcomeUser(string username)
        {
            Console.WriteLine($"Hello, {username} IT is nice to meet you!");
        }

        static void Goodbye()
        {
            Console.WriteLine("Have a fantastic day");
        }
    }
}
