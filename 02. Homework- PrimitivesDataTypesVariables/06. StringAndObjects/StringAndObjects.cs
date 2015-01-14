using System;
//Declare two string variables and assign them with Hello and World.
//Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
//Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).
class StringAndObjects
{
    static void Main()
    {
        string firstString = "Hello";
        string secondString = "World";
        object variable = firstString + " " + secondString;
        Console.WriteLine("First string: {0}\nSecond string: {1}\nConcatenation with object variable: {2}",firstString,secondString,variable);

        Console.WriteLine();
        string thirdString = (string)variable;
        Console.WriteLine("Third string with casting object value : {0}",thirdString);
    }
}
