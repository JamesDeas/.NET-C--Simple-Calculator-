using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator");
            Console.Write("Please enter an integer: ");
            Int32 x = Int32.Parse(Console.ReadLine());
            Console.Write("Please enter a second integer: ");
            Int32 y = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");

            Console.WriteLine($"{x} + {y} = {x + y}");
            Console.WriteLine($"{x} - {y} = {x - y}");
            Console.WriteLine($"{x} * {y} = {x * y}");
            Console.WriteLine($"{x} / {y} = {x / y}");

            Console.WriteLine($"{x} < {y} ? {x < y}");
            Console.WriteLine($"{x} <= {y} ? {x <= y}");
            Console.WriteLine($"{x} == {y} ? {x == y}");
            Console.WriteLine($"{x} >= {y} ? {x >= y}");
            Console.WriteLine($"{x} > {y} ? {x > y}");
            Console.WriteLine($"{x} != {y} ? {x != y}");

            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
