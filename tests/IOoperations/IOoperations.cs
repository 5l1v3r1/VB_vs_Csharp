using System;
using System.Diagnostics;
using System.IO;

public class IOoperations
{
	public static void Main()
	{
	    Stopwatch timer = new Stopwatch();
        timer.Start();
        IOoperationstest();
		timer.Stop();
		Console.Write(timer.ElapsedMilliseconds.ToString());
	}
	
    static void IOoperationstest()
    {
		string data = "wqtg3deiqgtodaugdlsai9q3ye9dwdfasoihfdsdfwqtg3deiqgtodaugdlsai9q3ye9dwdfasoihfdsdfwqtg3deiqgtodaugdlsai9q3ye9dwdfasoihfdsdfwqtg3deiqgtodaugdlsai9q3ye9dwdfasoihfdsdfwqtg3deiqgtodaugdlsai9q3ye9dwdfasoihfdsdfwqtg3deiqgtodaugdlsai9q3ye9dwdfasoihfdsdfwqtg3deiqgtodaugdlsai9q3ye9dwdfasoihfdsdfwqtg3deiqgtodaugdlsai9q3ye9dwdfasoihfdsdfwqtg3deiqgtodaugdlsai9q3ye9dwdfasoihfdsdfwqtg3deiqgtodaugdlsai9q3ye9dwdfasoihfdsdfwqtg3deiqgtodaugdlsai9q3ye9dwdfasoihfdsdfwqtg3deiqgtodaugdlsai9q3ye9dwdfasoihfdsdfwqtg3deiqgtodaugdlsai9q3ye9dwdfasoihfdsdfwqtg3deiqgtodaugdlsai9q3ye9dwdfasoihfdsdfwqtg3deiqgtodaugdlsai9q3ye9dwdfasoihfdsdfwqtg3deiqgtodaugdlsai9q3ye9dwdfasoihfdsdfwqtg3deiqgtodaugdlsai9q3ye9dwdfasoihfdsdfwqtg3deiqgtodaugdlsai9q3ye9dwdfasoihfdsdfwqtg3deiqgtodaugdlsai9q3ye9dwdfasoihfdsdfwqtg3deiqgtodaugdlsai9q3ye9dwdfasoihfdsdfwqtg3deiqgtodaugdlsai9q3ye9dwdfasoihfdsdfwqtg3deiqgtodaugdlsai9q3ye9dwdfasoihfdsdfwqtg3deiqgtodaugdlsai9q3ye9dwdfasoihfdsdfwqtg3deiqgtodaugdlsai9q3ye9dwdfasoihfdsdfwqtg3deiqgtodaugdlsai9q3ye9dwdfasoihfdsdfwqtg3deiqgtodaugdlsai9q3ye9dwdfasoihfdsdfwqtg3deiqgtodaugdlsai9q3ye9dwdfasoihfdsdfwqtg3deiqgtodaugdlsai9q3ye9dwdfasoihfdsdf";
        File.WriteAllText("example.txt", data);
	    File.ReadAllText("example.txt");
	    File.Copy("example.txt","example1.txt");
	    File.Move("example.txt","example2.txt");
	    File.Delete("example1.txt");
	    File.Delete("example2.txt");
		
        File.WriteAllText("example.txt", data);
	    File.ReadAllText("example.txt");
	    File.Copy("example.txt","example1.txt");
	    File.Move("example.txt","example2.txt");
	    File.Delete("example1.txt");
	    File.Delete("example2.txt");
		
        File.WriteAllText("example.txt",data);
		File.ReadAllText("example.txt");
	    File.Copy("example.txt","example1.txt");
	    File.Move("example.txt","example2.txt");
	    File.Delete("example1.txt");
	    File.Delete("example2.txt");
		
        File.WriteAllText("example.txt", data);
		File.ReadAllText("example.txt");
	    File.Copy("example.txt","example1.txt");
	    File.Move("example.txt","example2.txt");
	    File.Delete("example1.txt");
	    File.Delete("example2.txt");
		
        File.WriteAllText("example.txt", data);
		File.ReadAllText("example.txt");
	    File.Copy("example.txt","example1.txt");
	    File.Move("example.txt","example2.txt");
	    File.Delete("example1.txt");
	    File.Delete("example2.txt");
		
		File.WriteAllText("example.txt", data);
		File.ReadAllText("example.txt");
	    File.Copy("example.txt","example1.txt");
	    File.Move("example.txt","example2.txt");
	    File.Delete("example1.txt");
	    File.Delete("example2.txt");
		
		File.WriteAllText("example.txt", data);
		File.ReadAllText("example.txt");
	    File.Copy("example.txt","example1.txt");
	    File.Move("example.txt","example2.txt");
	    File.Delete("example1.txt");
	    File.Delete("example2.txt");
		
		File.WriteAllText("example.txt", data);
		File.ReadAllText("example.txt");
	    File.Copy("example.txt","example1.txt");
	    File.Move("example.txt","example2.txt");
	    File.Delete("example1.txt");
	    File.Delete("example2.txt");
		
		        File.WriteAllText("example.txt", data);
		File.ReadAllText("example.txt");
	    File.Copy("example.txt","example1.txt");
	    File.Move("example.txt","example2.txt");
	    File.Delete("example1.txt");
	    File.Delete("example2.txt");
		
		File.WriteAllText("example.txt", data);
		File.ReadAllText("example.txt");
	    File.Copy("example.txt","example1.txt");
	    File.Move("example.txt","example2.txt");
	    File.Delete("example1.txt");
	    File.Delete("example2.txt");
		
		File.WriteAllText("example.txt", data);
		File.ReadAllText("example.txt");
	    File.Copy("example.txt","example1.txt");
	    File.Move("example.txt","example2.txt");
	    File.Delete("example1.txt");
	    File.Delete("example2.txt");
		
		File.WriteAllText("example.txt", data);
		File.ReadAllText("example.txt");
	    File.Copy("example.txt","example1.txt");
	    File.Move("example.txt","example2.txt");
	    File.Delete("example1.txt");
	    File.Delete("example2.txt");
		
	}
}