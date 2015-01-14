using System;
//Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
//Print the variable values before and after the exchange.
class ExchangeVariableValues
{
    static void Main()
    {          
        int a = 5;
        int b = 10;
        Console.WriteLine("Before exchange\na= {0}\nb= {1}", a, b);
        
        int c = a;
        a = b;
        b = c;
        Console.WriteLine("After exchange\na= {0}\nb= {1}", a, b);

        Console.WriteLine();
        //another way
        int a1 = 5;
        int b1 = 10;
        int c1 = b1;
        b1 = a1;
        Console.WriteLine("Before exchange\na= {0}\nb= {1}", a1, c1);
        Console.WriteLine("After exchange\na= {0}\nb= {1}", c1, a1);
    }
}

