using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Console.Title = "Problem 11.* Numbers in Interval Dividable by Given Number";
        Console.Write("Input a start integer: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Input an end integer: ");
        int end = int.Parse(Console.ReadLine());

        int count = 0;
        if (start < 0 || end < 0 || end < start || start == end)
        {
            Console.WriteLine("Invalid value!");
            return;
        }
        Console.Write("The numbers diveded by 5 and reminder is 0: ");
        for (int i = start; i <= end; i++)
        {
            if (i % 5 == 0)
            {
                Console.Write(i + ", ");
                count++;
            }
        }
        Console.WriteLine("\b\b ");
        Console.WriteLine("Count: {0}", count);       
    }
}
