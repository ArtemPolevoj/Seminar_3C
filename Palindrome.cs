using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_3C
{
	internal class Palindrome
	{
		public static void number(int value)

		{
			string numStr;
			numStr = value.ToString();
			 while (numStr.Length != 5) 
			{
				Console.WriteLine("Ввели не пятизначное число или все нули.");
				value = GetValue.numberInt("Введите пятизначное число.");
				numStr = value.ToString();

			}

			if (numStr[0] == numStr[4] && numStr[1] == numStr[3])
			{
				Console.WriteLine("Число " + numStr + " - палиндром.");
			}
			else Console.WriteLine("Число " + numStr + " - не палиндром.");
		}

	}
}
