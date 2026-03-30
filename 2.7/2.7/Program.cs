using System.ComponentModel.Design;
using static System.Math;

class Cupe
{
    private int Num;
    public Cupe(int num)
    {
        Num = num;
    }

    public string Bilet()
    {
        string bilet = "";
        if (Num <= 36)
        {
            bilet += Convert.ToString((Num + 4 - 1)/4);
            bilet += "к";

            if(Num % 2 == 0)
            {
                bilet += "в";
            }

            else
            {
                bilet += "н";
            }
        }

        else if (Num > 36 && Num <= 54)
        {
            bilet += Convert.ToString(10 - ((Num - 36 + 2 - 1) / 2));
            bilet += "б";

            if (Num % 2 == 0)
            {
                bilet += "в";
            }

            else
            {
                bilet += "н";
            }
        }

        else
        {
            return "не существующий номер";
        }

        return bilet;
    }
}



class Programm
{
    static void Main(string[] args)
    {
        Console.Write("Введите номер места: ");
        int num = int.Parse(Console.ReadLine());

        Cupe bilet1 = new Cupe(num);
        Console.WriteLine($"билет в формате NBS {bilet1.Bilet()}");
    }
}