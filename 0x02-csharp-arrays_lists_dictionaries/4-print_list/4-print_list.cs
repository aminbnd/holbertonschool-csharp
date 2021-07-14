using System;
using System.Collections.Generic;

class List
{
	public static List<int> CreatePrint(int size)
	{
		if (size < 0)
		{
			Console.WriteLine("Size cannot be negative");
			return null;
		}

		var newList = new List<int>();
		char separator = ' ';
		for (int i = 0; i < size; i++)
        {
			if (i == size - 1)
				separator = '\n';
			Console.Write($"{i}{separator}");
			newList.Add(i);
        }
		return newList;
	}
}
