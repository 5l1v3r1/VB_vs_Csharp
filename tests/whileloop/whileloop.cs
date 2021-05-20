using System;
using System.Diagnostics;

public class forloop
{
	public static void Main()
	{
	    Stopwatch timer = new Stopwatch();
        timer.Start();
        forlooptest();
		timer.Stop();
		Console.Write(timer.ElapsedMilliseconds.ToString());
	}
	
	static void forlooptest()
	{
		long heavyNo = 1000000000;
		long i = 0;
		while(i < heavyNo)
		{
			i++; 
		}
	}
}