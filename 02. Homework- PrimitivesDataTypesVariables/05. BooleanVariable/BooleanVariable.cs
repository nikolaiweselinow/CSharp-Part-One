using System;
//Declare a Boolean variable called isFemale and assign an appropriate value corresponding to your gender.
//Print it on the console.
class BooleanVariable
{
    static void Main()
    {
        Console.Write("Please enter your gender ( m or f) : ");
        string gender = Console.ReadLine();
        bool isFemale;
        if (gender=="m")
        {
            isFemale = false;
        }
        else
        {
            isFemale = true;
        }
        Console.WriteLine("Are you Female: {0}",isFemale);
    }
}

