//Написать консольное приложение для решения задачи. Даны три числа a, b, c. Найти корни биквадратного уравнения с такими коэффициентами.

using System.Runtime.Intrinsics.X86;
using static System.Math;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("введите кофиценты для би квадратного уравнения (+-ax^4 +- bx^2 +- c");
        Console.Write("число a: ");
        float a = float.Parse(Console.ReadLine());

        Console.Write("число b: ");
        float b = float.Parse(Console.ReadLine());

        Console.Write("число c: ");
        float c = float.Parse(Console.ReadLine());

        Console.WriteLine($"ваше вырахение: {a}x^4+({b})x^2+({c}) = 0");

        double D = Sqrt((b * b - 4 * a * c));
        double t1 = ((-1 * b) + D) / (2.0 * a);
        double t2 = ((-1 * b) - D) / (2.0 * a);

        double x1 = t1 >= 0 ? Pow(t1, (1.0/2.0)) : -1;
        double x2 = t1 >= 0 ? Pow(t2, (1.0/2.0)) : -1;

        Console.WriteLine("Корни выражения:");

        string rez = "";
        
        if (x1 >= 0)
        {
            rez += ($"x = -{x1}, x = +{x1}, ");
        }
        if (x2 >= 0)
        {
            rez += ($" x = -{x2}, x = +{x2}");
        }

        if (rez == "")
        {
            Console.WriteLine("Нет корней");
        }
        else
        {
            Console.WriteLine(rez);
        }
    }
}