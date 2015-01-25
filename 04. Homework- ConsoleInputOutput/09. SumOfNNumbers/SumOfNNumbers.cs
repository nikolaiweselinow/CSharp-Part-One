using System;
//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.
class SumOfNNumbers
{
    static void Main()
    {
        Console.Title = "Problem 9. Sum of n Numbers";
        Console.Write("Enter a number n= ");
        double n = double.Parse(Console.ReadLine());
        double sum=0;
        for (int i = 1; i <= n; i++)
        {
            Console.Write("Enter a number #{0}: ",i);
            sum = sum + double.Parse(Console.ReadLine());
        }
        Console.WriteLine("Sum: {0}",sum);
    }
}

