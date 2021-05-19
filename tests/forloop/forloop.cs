using System;
using System.Diagnostics;
using System.IO;

public class forloop
{
	public static void Main()
	{
	    Stopwatch timer = new Stopwatch();
        timer.Start();
        forlooptest();
		timer.Stop();
		Console.WriteLine(timer.ElapsedMilliseconds.ToString());
	}
	
	static void forlooptest()
	{
		long heavyNo = 100000000;
		for(int i = 0; i < heavyNo; i++)
		{
			 
		}
	}
}