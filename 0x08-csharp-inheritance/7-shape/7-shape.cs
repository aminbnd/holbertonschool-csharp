using System;

/// <summary>
/// Shape: Class
/// </summary>
class Shape
{
	public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary>
/// Rectangle: Class that inherit from Shape
/// </summary>
class Rectangle : Shape
{
    private int width;
    private int height;
    /// <summary>
    /// Property: width stter and getter
    /// </summary>
    public int Width
    {
        get
        {
            return width;
        }
        set
        {
            if (value < 0) throw new ArgumentException("Width must be greater than or equal to 0");
            width = value;
        }
    }

    /// <summary>
    /// Property: height setter and getter
    /// </summary>
    public int Height
    {
        get
        {
            return height;
        }
        set
        {
            if (value < 0) throw new ArgumentException("Height must be greater than or equal to 0");
            height = value;
        }
    }

    /// <summary>
    /// Returns the Area of a rectangle
    /// </summary>
    /// <returns>Integer: area of the rectangle</returns>
    public new int Area()
    {
        return (this.height * this.width);
    }

    public override string ToString()
    {
        return $"[Rectangle] {this.width} / {this.height}";
    }
}