using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_3C
{
	internal class Distance3D
	{
		public static void distans()
		{
			double ax = GetValue.numberDouble("Введите координату Х для точки А");
			double ay = GetValue.numberDouble("Введите координату Y для точки А");
			double az = GetValue.numberDouble("Введите координату Z для точки А");
			double bx = GetValue.numberDouble("Введите координату Х для точки B");
			double by = GetValue.numberDouble("Введите координату Y для точки B");
			double bz = GetValue.numberDouble("Введите координату Z для точки B");

			float distanc = (float)Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2) + Math.Pow((bz - az), 2));
			Console.WriteLine("Расстояние между точками А и В в 3D пространстве равно " + distanc);
		}
	}
}
