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
        MethodInfo[] meth = myObj.GetType().GetMethods();

        Console.WriteLine($"{myObj.GetType().Name} Properties:");
        foreach(var prop in props)
        {
            Console.WriteLine(prop.Name);
        }
        Console.WriteLine($"{myObj.GetType().Name} Properties:");
        foreach(var me in meth)
        {
            Console.WriteLine(me.Name);
        }
    }
}
