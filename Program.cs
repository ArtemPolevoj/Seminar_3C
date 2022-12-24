using Seminar_3C;

internal class Program
{
	private static void Main(string[] args)
	{
		Palindrome.number(GetValue.numberInt("Введите пятизначное число."));
		Distance3D.distans();
		Cube.cubeN(GetValue.numberInt("Введите целое число"));
	}
}