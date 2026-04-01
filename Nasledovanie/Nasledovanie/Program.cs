public class Point
{
    public Double X0 { get; set; }
    public Double Y0 { get; set; }

    public Point(Double x, Double y)
    {
        X0 = x;
        Y0 = y;
    }
}

public class Krug : Point
{
    public Double R { get; set; }

    public Krug(Double x, Double y,  Double r) : base(x, y)
    {
        R = r;
    }

    public double S_Kryg()
    {
        double rezult = 0.0;

        rezult = double.Pi * R * R;

        return rezult;
    }
}

class Har : Krug
{
    public Har(Double x, Double y, double r) : base(x, y, r)
    {

    }

    public double S_Har()
    {
        double rezult = 0.0;

        rezult = 4 * double.Pi * R * R;

        return rezult;
    }
}

public class Priamougl : Point
{
    public double A {  get; set; }
    public double B { get; set; }

    public Priamougl(double x, double y, double a, double b) : base(x, y)
    {
        A = a;
        B = b;
    }

    public double S_Priamougl()
    {
        double rezult = 0.0;

        rezult = A * B;

        return rezult;
    }
}










class Programm 
{ 
    static void Main(string[] args)
    {
        Console.WriteLine(double.Pi);
    }
}

