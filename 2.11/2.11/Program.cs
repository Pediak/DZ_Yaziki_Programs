using static System.Math;

class sigma
{
    public int n {  get; set; }
    public double x { get; set; }

    public sigma(int N, double X)
    {
        n = N;
        x = X;
    }

    public double rez()
    {
        double rezult = 0.0;
        int fact = 1;

        for (int i = 1; i <= n; i++)
        {
            fact *= i;

            rezult += Pow((-1), i) * ((Pow(x, i + 1) + Pow(x, 3 * i)) / (fact + 1)); // nfact = ifact = fact
        }

        rezult = rezult * (1.0 / fact);

        return rezult;
    }
}


class Programm
{
    static void Main(string[] args)
    {
        sigma N = new sigma(2, 0.5);
        Console.WriteLine(N.rez());
    }
}