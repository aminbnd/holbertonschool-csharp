using System;
using System.Reflection;

class Obj
{
    /// <summary>
    /// Prints the names of the available properties and methods of an object.
    /// </summary>
    /// <param name="myObj">Object to use</param>
	public static void Print(object myObj)
    {
        PropertyInfo[] props = myObj.GetType().GetProperties();
        MethodInfo[] meths = myObj.GetType().GetMethods();

        Console.WriteLine($"{myObj.GetType().Name} Properties:");
        foreach (var prop in props)
        {
            Console.WriteLine(prop.Name);
        }

        Console.WriteLine($"{myObj.GetType().Name} Methods:");
        foreach (var meth in meths)
        {
            Console.WriteLine(meth.Name);
        }
    }
}
