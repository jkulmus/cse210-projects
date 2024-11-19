using System;

class Program
{
    static void Main(string[] args)
    {
        // create fraction instance using default constructor
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString()); // output 1/1
        Console.WriteLine(f1.GetDecimalValue()); // output 1

        // instance using constructor 5/1
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString()); // output 5/1
        Console.WriteLine(f2.GetDecimalValue()); // output 5

        // using two parameters 3/4
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString()); // output 3/4
        Console.WriteLine(f3.GetDecimalValue()); // ouuput .75

        // using two parameters 1/3
        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString()); // output 1/3
        Console.WriteLine(f4.GetDecimalValue()); // output .33333
    }
}