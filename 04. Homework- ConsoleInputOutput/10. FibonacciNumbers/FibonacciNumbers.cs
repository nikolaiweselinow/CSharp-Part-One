using System;
//ite a program that reads a number n and prlongs on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
class FibonacciNumbers
{
    static void Main()
    {
        Console.Title = "Problem 10. Fibonacci Numbers";

        Console.Write("Enter a positive longeger: ");
        long n = long.Parse(Console.ReadLine());
        long fibNumber;
        long firstNumber = -1;
        long secondNumber = 1;
        if (n < 0)
        {
            Console.WriteLine("Plese input positive longeger");
        }
        Console.Write("Fibonacci Numbers: ");
        for (long i = 0; i < n; i++)
        {
            fibNumber = firstNumber + secondNumber;

            Console.Write("{0}, ", fibNumber);
            firstNumber = secondNumber;
            secondNumber = fibNumber;
        }
        Console.WriteLine("\b\b;");
    }
}

