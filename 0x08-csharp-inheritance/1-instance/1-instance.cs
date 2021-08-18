using System;

class Obj
{
    /// <summary>
    /// checks if an object is an instance of Array or if the object is an instance of a class that inherited from Array
    /// </summary>
    /// <param name="obj">The object to check</param>
    /// <returns>True if instance of array or object is an istance of
    /// class that ihertied from array
    /// False otherwise
    /// </returns>
	public static bool IsInstanceOfArray(object obj)
    {
        if(obj.GetType() == typeof(Array) || obj is Array)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
