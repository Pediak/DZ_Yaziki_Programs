using System;
using System.Security.Cryptography;
using static System.Math;

class Treugl
{
    private float A ; private float B; private float C;

    public void GetSaid(float a, float b, float c)
    {
        A = a; B = b; C = c;   
    }
    public string TyPe()
    {
         String Rezult;
         String Temp;


        if ((A + B > C) && (C + B > A) && (A + C > B))
        {
            Rezult = "  Данный треугольник существует";
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

                if(Rezult == Temp)
                {
                    Rezult += "  Треугольник разносторонний";
                }
            }
        }
        else
        {
            Rezult = "Треугольник не существует";
        }

        return (Rezult);
    }
}


public class MainClass
{
    static void Main()
    {
        Treugl Tri = new Treugl();

        Tri.GetSaid(3.0f, 4.0f, 5.0f);

        Console.WriteLine(Tri.TyPe());
    }
}