﻿using System;
//Write an expression that checks if given integer is odd or even.

class OddOrEven
{
    static void Main()
    {
        Console.Title = "Problem 1. Odd or Even Integers";
        Console.Write("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());
        bool isODD = number % 2 != 0;
        Console.WriteLine("Is odd? - {0}", isODD);

    }
}

