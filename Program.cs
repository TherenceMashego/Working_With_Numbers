using System;

namespace Working_With_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // You can print out numbers as below 
            Console.WriteLine(5);

            // You can also use operators right in the WriteLine method, i.e., + - * /
            Console.WriteLine(6 + 5);

            // Modulo operator, to get the remainder of division, use %
            Console.WriteLine(5 % 2);

            // BODMAS still applies, 4 + 2 * 3 gets 10, use brackets to change the order
            Console.WriteLine(4 + 2 * 3);

            // Whatever you do just with integers, you get an integer back
            Console.WriteLine(5 / 2); // You get 2, not 2.5!

            // If you use decimal and an integer, you always get a double
            Console.WriteLine(5 / 2.0); // You get 2.5

            // Can also give a number to a variable
            int num = 6;

            // Can increment or decrement by 1
            num++;
            Console.WriteLine("Incremented num: " + num);

            // Calling methods, e.g., the Math method. ABS means Absolute; you will always get the positive number
            Console.WriteLine("Absolute value of -40: " + Math.Abs(-40));

            // To raise to powers
            Console.WriteLine("2 raised to the power of 2: " + Math.Pow(2, 2));

            Console.ReadLine();
        }
    }
}
