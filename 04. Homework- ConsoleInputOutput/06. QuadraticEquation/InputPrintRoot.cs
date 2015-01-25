using System;
class QuadraticEquation
{
    static void Main()
    {
        Console.Title = "Problem 6. Quadratic Equation";

        Console.Write("a= ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b= ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c= ");
        double c = double.Parse(Console.ReadLine());

        SolveEquation solveQuadraticEquation = new SolveEquation();
        solveQuadraticEquation.SolveQuadratic(a, b, c);

    }
}
