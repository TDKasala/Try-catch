using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(Calculate());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            Console.Read();
        }
        public static int Calculate()
        {
            //Console.WriteLine("NB! Only numbers allowed");
            Console.WriteLine("Enter your first number:");
            string number1 = Console.ReadLine();

            Console.WriteLine("Enter your second number: ");
            string number2 = Console.ReadLine();

            int num1, num2;
            try
            {
                num1 = int.Parse(number1);
                num2 = int.Parse(number2);
            }
            catch (FormatException e)
            {
                throw new FormatException("Invalid input format. Please enter valid numbers.", e);
            }

            int result = num1 + num2;
            return result;
        }
    }
}
