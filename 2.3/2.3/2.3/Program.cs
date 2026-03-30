using System;
using System.Reflection;
using static System.Math;

class Programm()
{
    static void Main(string[] args)
    {
            Console.WriteLine("Введите разные числа");

            Console.Write("x = ");

        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Black;

            float x = float.Parse(Console.ReadLine());

        Console.ResetColor();


            Console.Write("y = ");

        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Black;

            float y = float.Parse(Console.ReadLine());

        Console.ResetColor();


            Console.Write("z = ");

        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Black;

            float z = float.Parse(Console.ReadLine());


        if (Abs(x - y) < 0.001 || Abs(y - z) < 0.001 || Abs(z - x) < 0.001)
        {
            Console.WriteLine("числа равны, не подходит под условие");
            Console.ResetColor();
        }

        else
        {
            float Min = x < y ? (x < z ? x : z) : (y < z ? y : z);
            float Max = x > y ? (x > z ? x : z) : (y > z ? y : z);

            float Middle = x + y + z - Min - Max;

            float Sr = (x + y + z) / 3;
            float SumKv = x*x + y*y + z*z;

            Console.WriteLine("\nИсходные числа: x = {0}, y = {1}, z = {2}\n", x, y, z);
            Console.WriteLine("Min = {0}, Middle = {1}, Max = {2}\n", Min, Middle, Max);

            x = x == Min ? SumKv : (x == Max ? Sr : x);
            y = y == Min ? SumKv : (y == Max ? Sr : y);
            z = z == Min ? SumKv : (z == Max ? Sr : z);

            Console.WriteLine("Результат: x = {0}, y = {1}, z = {2}\n", x, y, z);
            Console.ResetColor();
        }
    }
}