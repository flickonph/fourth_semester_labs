namespace dmPCs;

internal static class Lab2
{
	private static double T;
	private const double R = 8.314;
	private static readonly double[] Ai = {
		2.45041896E+00, 2.99807749E-02, 2.82471382E-05, -6.00704031E-08, 2.66264111E-11, -1.71521009E+04, 1.84229851E+01
	};
	internal static void Lab2Main()
	{
		T = 250;
		Console.WriteLine("variant: 59\n" +
		                  "C3H7NO2 (Nitropro)\n" +
		                  $"first task res: {FirstTask()}\n");
		T = 298;
		Console.WriteLine("variant: 17\n" +
		                  "02(1)|Ar(3)\n" +
		                  $"second task res: {SecondTask()}");
	}

	private static double FirstTask()
	{
		// S = klnW (Boltzmann)
		// S0(T) = R*(a0lnT+a1T+(a2/2*T^2)+(a3/3*T^3)+(a4/4*T^4)+a6)
		return (Ai[0]*Math.Log(T) +
		        (Ai[1] * T) +
		        (Ai[2] / 2) * Math.Pow(T, 2) +
		        (Ai[3] / 3) * Math.Pow(T, 3) +
		        (Ai[4] / 4) * Math.Pow(T, 4) +
		        (Ai[6] / T))*R;
	}

	private static double SecondTask()
	{
		// PV = nRT
		// dS = -R*(na*ln(na/(na+nb)) + nb*ln(nb/(na+nb)))
		double p = 1.01 * Math.Pow(10, 5);
		double va= 1 * Math.Pow(10, -4);
		double vb = 3 * Math.Pow(10, -4);
		double na = (p * va) / (R * T);
		double nb = (p * vb) / (R * T);
		return -R * (na * Math.Log(na / (na + nb)) + nb * Math.Log(nb / (na + nb)));
	}
}