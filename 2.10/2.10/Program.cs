class sigma
{
    public int N;

    public sigma(int n)
    {
        N = n;
    }

    public double suma()
    {
        double rezult = 0;

        for (int n = 1; n <= N; n++)
        {
            rezult += 1.0 / (n * (n + 1) * (n + 2));
        }

        return rezult;
    }
}

class Programm
{
    static void Main(string[] args)
    {
        sigma N = new sigma(10);
        Console.WriteLine(N.suma());
    }
}