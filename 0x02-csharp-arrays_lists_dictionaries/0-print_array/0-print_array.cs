﻿using System;
using System.Text;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        int[] newArray = new int[size];
        var output = new StringBuilder();
        for (int i = 0; i < size; i++)
        {
            output.Append(i);
            if (i != size - 1)
            {
                output.Append(" ");
            }
            newArray[i] = i;
        }

        Console.WriteLine(output);

        return newArray;
    }
}
