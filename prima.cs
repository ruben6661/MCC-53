using System;

namespace prima
{
    public class Program
    {
		public void Main()
        {
			int[] a = new int[5];
            for (int p = 0; p < 5; p++) {
                Console.WriteLine("Input Array ke - "+p);
                a[p] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int p in a) {
            if (CekPrima(p))
                Console.Write("Angka " + p + " adalah bilangan prima \n");
            else
                Console.Write("Angka " + p + " adalah Bukan bilangan Prima \n");
        	}
		}
		
        static bool CekPrima(int bilangan)
        {
            bool status = true;
            if (bilangan == 0 || bilangan == 1 || bilangan == -1)
            	{
                status = false;
            	}
            else
            	{
                for (int i = 2; i < bilangan; i++)
                {
                    if (bilangan % i == 0)
                    {
                        status = false;
                    }
                }
            }
            return status;
        }
    }
}