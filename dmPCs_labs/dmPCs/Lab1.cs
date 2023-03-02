namespace dmPCs;

internal static class Lab1
{
    private const double R = 8.314;
    private static readonly double[] ASub =
    {
        1.25245480E+01,
        -1.01018826E-02,
        2.21992610E-04,
        -2.84863722E-07,
        1.12410138E-10,
        -2.98434398E+04,
        -1.97109989E+01
    };

    internal static void Lab1Main()
    {
        for(double t = 298; t <= 600; t+=10)
        {
            Console.WriteLine($"{t}\t{Calc(t, ASub)}");
        }
        double realSubC=239.74;
        double abs=Math.Abs(Calc(400, ASub)-realSubC);
        double rel=abs/realSubC*100;
        Console.WriteLine($"T=400K|abs={abs}|rel={rel}");
    }

    private static double Calc(double T, double[] a)
    {
        var c0 = R * (a[0] +
                      a[1] * T +
                      a[2] * Math.Pow(T, 2) +
                      a[3] * Math.Pow(T, 3) +
                      a[4] * Math.Pow(T, 4));
        return c0;
    }
}