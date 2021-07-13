using System;
					
public class Program
{
	public static void Main()
	{
		 Console.WriteLine("Program Sederhana Bilangan Prima dengan C# .Net \n \n");
		 Console.Write("Masukkan Batas Bilangan Prima : ");
	 
		 bool prima = true;
		 
		 int bilangan = int.Parse(Console.ReadLine());
		 
		 if (bilangan >= 2)
		 {
		 	for (int i = 2; i <= bilangan; i++)
		 	{
		 		for (int j = 2; j < i; j++)
		 		{
		 			if ((i % j) == 0)
		 			{
						 prima = false;
						 break;
					 }
		 		}
		 
			 if (prima)
			 Console.WriteLine("Bilangan " + i + " adalah bilangan prima");
			 prima = true;
		 	}
		 }
		 else
		 Console.WriteLine("Tidak ada bilangan prima yang bisa dituliskan");
		 Console.ReadLine();
		 }
// 	edited by rory
	// 	edited by rory 2
}
