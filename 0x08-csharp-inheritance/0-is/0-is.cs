using System;

class Obj
{
    /// <summary>
    /// Checks if object is type of int
    /// </summary>
    /// <param name="obj">Object to check</param>
    /// <returns>boolean: true if int false otherwise</returns>
	public static bool IsOfTypeInt(object obj)
    {
        if (obj.GetType() == typeof(int))
            return true;
        else
            return false;
    }
}
