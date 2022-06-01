using System;
using System.Collections.Generic;
using System.Linq;

/*
 * Dado un array de numeros, cuál es el número que más se repite, y cuantas veces?
 */
public class Array1
{
	public static void Main()
	{
		Random rnd = new Random();
		var numbers = Enumerable.Range(0, 20).Select(_ => rnd.Next(0, 10)).OrderBy(_ => _).ToArray();

		Console.WriteLine($"Given the array: [{string.Join(", ", numbers)}]");

		int numero = 0;
		int count = 0;
		foreach(var n in numbers)
		{
			var currentCount = numbers.Where(x => x == n).Count();
			if (count < currentCount)
			{
				numero = n;
				count = currentCount;
			}
		}

		PrintResult(numero, count);
	}

	public static void PrintResult(int number, int count)
	{
		Console.WriteLine($"Most repeated number is {number} with a count of {count}");
	}
}