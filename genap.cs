using System;

namespace Genap {
					
	public class Program
	{
		public void Main()
		{
			int[] array = new int [12] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10,11,12};
			int i = 1;
			Program program = new Program();
			for (i = 1; i <= array.Length; i++){
				if(i % 2 == 0){
					Console.WriteLine(i);
				}
			}
		}
	}
}