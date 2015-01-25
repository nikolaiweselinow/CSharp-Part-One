using System;
using System.Threading;
using System.Globalization;

//Write a program that reads 3 real numbers from the console and prints their sum.


class SumOfThreeNumbers
{
    static void Main()
    {
        Console.Title = "Problem 1. Sum of 3 Numbers";

        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter a first number: ");
        string firstString = Console.ReadLine();
        firstString = firstString.Replace(",", ".");
        double firstNumber = double.Parse(firstString);
        
        Console.Write("Enter a second number: ");
        string secondString = Console.ReadLine();
        secondString = secondString.Replace(",", ".");
        double secondNumber = double.Parse(secondString);
        
        Console.Write("Enter a third number: ");
        string thirdString = Console.ReadLine();
        thirdString = thirdString.Replace(",", ".");
        double thirdNumber = double.Parse(thirdString);

        double sum = firstNumber + secondNumber + thirdNumber;
        Console.WriteLine("Sum of: {0} + {1} + {2} = {3}",firstNumber,secondNumber,thirdNumber,sum);

    }
}

