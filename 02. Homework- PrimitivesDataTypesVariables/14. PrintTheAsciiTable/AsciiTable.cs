﻿using System;
//Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).
class AsciiTable
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        for (int i = 0; i <= 255; i++)
        {
            Console.Write((char)i + " ");
        }
    }
}

