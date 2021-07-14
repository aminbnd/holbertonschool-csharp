using System;
using System.Collections.Generic;

class List
{
	public static int MaxInteger(List<int> myList)
	{
		if(myList.Count == 0)
        {
			Console.WriteLine("List is empty");
			return -1;
        }

		int selectedValue = 0;
		for (int i = 0; i < myList.Count - 1; i++)
        {
			if (myList[i] > selectedValue)
			{
				selectedValue = myList[i];
            }
			//else
   //         {
			//	selectedValue = myList[i];
   //         }
        }
		return selectedValue;
	}
}
