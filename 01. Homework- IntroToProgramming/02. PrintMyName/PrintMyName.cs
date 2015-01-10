using System;
//Modify the previous application to print your name.
class PrintMyName
{
    static void Main()
    {
        Console.WriteLine("Kamba Kambov");

        //another way with placeholder{} and variables
        string firstName = "Kamba";
        string secondName = "Kambov";
        Console.WriteLine("My name is {0} {1}",firstName, secondName);
    }
}

