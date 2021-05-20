using System;
using System.Diagnostics;

public class dowhileloop
{
	public static void Main()
	{
	    Stopwatch timer = new Stopwatch();
        timer.Start();
        dowhilelooptest();
		timer.Stop();
		Console.Write(timer.ElapsedMilliseconds.ToString());
	}
	
	static void dowhilelooptest()
	{
		long heavyNo = 1000000000;
		long i = 0;
		do
		{
			i++; 
		}
		while(i < heavyNo);
	}
}