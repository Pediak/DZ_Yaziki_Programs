using System;
using System.Security.Cryptography;
using static System.Math;


public class Treangl
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }


    public double X1 { get; set; }
    public double Y1 { get; set; }
    public double X2 { get; set; }
    public double Y2 { get; set; }
    public double X3 { get; set; }
    public double Y3 { get; set; }


    public Treangl(float a, float b, float c)
    {
        A = a; B = b; C = c;
    }

    public Treangl()
    {
        A = 5;
        B = 5;
        C = 5;
    }

    public Treangl(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        X1 = x1; Y1 = y1;
        X2 = x2; Y2 = y2;
        X3 = x3; Y3 = y3;

        distans();
    }

    private void distans()
    {
        A = Sqrt((X3 - X2) * (X3 - X2) + (Y3 - Y2) * (Y3 - Y2));
        B = Sqrt((X3 - X1) * (X3 - X1) + (Y3 - Y1) * (Y3 - Y1));
        C = Sqrt((X2 - X1) * (X2 - X1) + (Y2 - Y1) * (Y2 - Y1));
    }

    public void Deconstruct(out double a, out double b, out double c) // позволяет удобным образом вытаскивать параметры обьяекта одной строкой var(a, b, c) = Tri; вмето отделього float a = Tri.A; float b = ...
    {
        a = A;  
        b = B;  
        c = C;  
    }

    public void Deconstruct(out string Rez, out double areal)//а так же может сразу вернуть что либо другое например S и rezult как функции
    {
        Rez = TePe();
        areal = S();
    }

    public double S()
    {
        double s = 0;

        double p = (A + B + C) / 2;
        s = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

        return s;
    }
    

    public string TePe()
    {

        String Rezult;
        String Temp;


        if ((A + B > C) && (C + B > A) && (A + C > B))
        {
            Rezult = "Данный треугольник существует";
            Temp = Rezult;

            if (Abs(A - B) < 0.001 && Abs(B - C) < 0.001)
            {
                Rezult += "  Треугольник равносторонний";
            }
            else
            {
                bool PraimnUgl = (Abs(A * A + B * B - C * C) < 0.001) ||
                              (Abs(A * A + C * C - B * B) < 0.001) ||
                              (Abs(B * B + C * C - A * A) < 0.001);

                bool RavnoBedr = (Abs(A - B) < 0.001) ||
                                   (Abs(B - C) < 0.001) ||
                                   (Abs(A - C) < 0.001);

                if (PraimnUgl)
                {
                    Rezult += "  Треугольник прямоугольный";
                }

                if (RavnoBedr)
                {
                    Rezult += "  Треугольник равнобедренный";
                }

                if (Rezult == Temp)
                {
                    Rezult += "  Треугольник разносторонний";
                }
            }
        }
        else
        {
            Rezult = "Треугольник не существует";
        }
        return Rezult;
    }
}


class Programm
{
    static void Main(string[] args)
    {
        Treangl Triyg1 = new Treangl(4, 3, 5);
        Console.WriteLine(Triyg1.TePe());
        Console.WriteLine(Triyg1.S());
        var (a, b, c) = Triyg1;
        var (rez, arel) = Triyg1;
        Console.WriteLine($"стороны {a}{b}{c}");
        Console.WriteLine($"тип триугольника '{rez}' площадь {arel}\n");

        Treangl Triygl2 = new Treangl();
        var (a1, b1, c1) = Triygl2;
        Console.WriteLine($"{a1}{b1}{c1}\n");

        Treangl Triygl3 = new Treangl(1, 3, 4, 5, 1, 4);
        Console.WriteLine(Triygl3.TePe());
    }
}