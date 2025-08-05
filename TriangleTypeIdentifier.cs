using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter side 1: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter side 2: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter side 3: ");
        int c = Convert.ToInt32(Console.ReadLine());

        if (a == b && b == c)
            Console.WriteLine("Equilateral Triangle");
        else if (a == b || b == c || a == c)
            Console.WriteLine("Isosceles Triangle");
        else
            Console.WriteLine("Scalene Triangle");
    }
}
