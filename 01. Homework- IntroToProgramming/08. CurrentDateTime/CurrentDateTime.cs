﻿using System;
//Create a console application that prints the current date and time. Find out how in Internet.
class CurrentDateTime
{
    static void Main()
    {
        Console.WriteLine(DateTime.Now);

        //another way with variable
        DateTime nowDatetime = DateTime.Now;
        Console.WriteLine(nowDatetime);
    }
}

