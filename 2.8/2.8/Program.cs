//Вычислить сумму квадратов всех целых чисел, попадающих в интервал [ln(x); ex], при х=1.
using static System.Math;

class Programm
{
    static void Main(string[] args)
    {
        double left = Log(1);
        double right = Pow(E, 1);
        int counter = 0;

        for (int i = Convert.ToInt32(Ceiling(left)); i >= left && i <= right; i++)
        {
            counter += i*i;
        }

        Console.WriteLine(counter);
    }
}