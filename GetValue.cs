using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_3C
{
	internal class GetValue
	{
		public static int numberInt (string str)
		{
			int number;
			controlNumber:
			Console.WriteLine (str);
			string numStr = Console.ReadLine ();
			try
			{
				number = int.Parse(numStr);
			}
			catch (Exception ex)
			{
				Console.WriteLine ("Ввели не число или не целое число.");
				goto controlNumber;
			}
			return number;
		}

		public static double numberDouble (string str)
		{
			double number;
		controlNumber:
			Console.WriteLine(str);
			string numStr = Console.ReadLine();
			try
			{
				number = double.Parse(numStr);
			}
			catch (Exception ex)
			{
				Console.WriteLine("Ввели не число.");
				goto controlNumber;
			}
			return number;
		}

	}
}
