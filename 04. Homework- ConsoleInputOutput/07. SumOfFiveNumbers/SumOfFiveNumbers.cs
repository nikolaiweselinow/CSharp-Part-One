using System;

//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

class SumOfFiveNumbers
{
    static void Main()
    {
        Console.Title = "Problem 7. Sum of 5 Numbers";

        Console.Write("Enters a 5 numbers separated by a space: ");
        string[] numbers = Console.ReadLine().Split(' ');    // use array
        double a = double.Parse(numbers[0]);
        double b = double.Parse(numbers[1]);
        double c = double.Parse(numbers[2]);
        double d = double.Parse(numbers[3]);
        double e = double.Parse(numbers[4]);

        Console.WriteLine("The sum of {0}+{1}+{2}+{3}+{4}= {5}", a, b, c, d, e, a + b + c + d + e);
    }
}
