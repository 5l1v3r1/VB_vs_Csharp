using System;
using System.Diagnostics;

public class whileloop
{
	public static void Main()
	{
	    Stopwatch timer = new Stopwatch();
            timer.Start();
            whilelooptest();
	    timer.Stop();
            Console.Write(timer.ElapsedMilliseconds.ToString());
	}
	
	static void whilelooptest()
	{
		long heavyNo = 1000000000;
		long i = 0;
		while(i < heavyNo)
		{
			i++; 
		}
	}
}
