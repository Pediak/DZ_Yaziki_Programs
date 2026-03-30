// F(x) = ln(2 + sin(x))dx
// h = (b - a) / n 
// x(i) = a + ih
//f(x)dx = h(f(x0) + f(x1) + ... + f(xn-1))

using static System.Math;

class Programm
{
    static void Main(string[] args)
    {
        Console.WriteLine("""
                  Расчет интеграла:
            F(x) = ln(2 + sin(x))dx

            h = (b - a) / n 
            x(i) = a + ih
            f(x)dx = h(f(x0) + f(x1) + ... + f(xn-1))

            """);
                  

        double a;
        double b;
        int n;

        try
        {
            Console.Write("Введите a (начало): ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Введите b (конец): ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Введите n (кол-во отрезков) (не должен быть равен 0): ");
            n = int.Parse(Console.ReadLine());
        }
        catch (Exception)
        {
            Console.WriteLine("нужно вводить числа");
            return;
        }


        if (Abs(a - b) < 0.001)
        {
            double start = a > b ? a : b;
            double end = b > a ? b : a;

            if (n != 0)
            {
                double h = (start - end) / n;
                double Fx = 0;

                for (double i = 0; i < n; i++)
                {
                    double x = start + i * h;
                    Fx += Log(2 + Sin(x));
                }

                Fx = h * Fx;

                Console.WriteLine($"Результат: {Round(Fx, 3)}");
            }
            else
            {
                Console.WriteLine("n не может быть равен 0 т.к h = (b - a) / n деление на 0");
            }

        }
        else
        {
            Console.WriteLine("начало не может быть меньше конца");
        }
    }
}