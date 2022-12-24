using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_3C
{
	internal class Cube
	{
		public static void cubeN (int value) 
		{
			for(int i = 1; i <= value; i++)
			{
				Console.WriteLine("Куб числа " + i  + " равен " + (i * i * i));
			}
		}
	}
}
