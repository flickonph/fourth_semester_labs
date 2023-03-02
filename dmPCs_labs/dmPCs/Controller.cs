namespace dmPCs;

internal static class Program
{
	internal static int Main()
	{
		int i = Convert.ToInt32(Console.ReadLine());
		switch (i)
		{
			case 1:
				Lab1.Lab1Main();
				break;
			case 2:
				Lab2.Lab2Main();
				break;
			default:
				Console.WriteLine("Doesn't exist");
				break;
		}
		return 0;
	}
}