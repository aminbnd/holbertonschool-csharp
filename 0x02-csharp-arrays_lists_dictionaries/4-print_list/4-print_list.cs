using System;


class List
{
	public static System.Collections.Generic.List<int> CreatePrint(int size)
	{
		if (size < 0)
		{
			Console.WriteLine("Size cannot be negative");
			return null;
		}

		var newList = new System.Collections.Generic.List<int>();
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
