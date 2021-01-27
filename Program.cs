using System;

namespace MethodExercise2a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first number?");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your second number to add?");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is {sum}");

            Console.WriteLine("What is your first number?");
            int x1 = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your second number to multiply?");
            int y1 = int.Parse(Console.ReadLine());

            int product = Multiply(x1, y1);
            Console.WriteLine($"The product is {product}");
        }

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int x1, int y1)
        {
            return x1 * y1;
        }
    }
}
