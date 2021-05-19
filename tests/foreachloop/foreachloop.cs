using System;
using System.Diagnostics;
using System.IO;

public class foreachloop
{
	public static void Main()
	{
	    Stopwatch timer = new Stopwatch();
        timer.Start();
        foreachlooptest();
		timer.Stop();
		Console.WriteLine(timer.ElapsedMilliseconds.ToString());
	}
	
	static void foreachlooptest()
	{
{
    string[] heavycars = new string[] { "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Volvo", "BMW", "Ford", "Mazda", "Mazda", "Volvo" };
    foreach (string car in heavycars)
    {
    }
    foreach (string car in heavycars)
    {
    }
    foreach (string car in heavycars)
    {
    }
    foreach (string car in heavycars)
    {
    }
    foreach (string car in heavycars)
    {
    }
}

	}
}