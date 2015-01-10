using System;
//Write a program to print the numbers 1, 101 and 1001, each at a separate line.
class PrintNumbers
{
    static void Main()
    {
        Console.WriteLine(1);
        Console.WriteLine(101);
        Console.WriteLine(1001);

        Console.WriteLine();

        //another way with variables and WriteLine with Placeholder
        int firstNumber = 1;
        int secondNumber = 101;
        int thridNumber = 1001;
        Console.WriteLine("{0}\n{1}\n{2}", firstNumber, secondNumber, thridNumber);
    }
}

