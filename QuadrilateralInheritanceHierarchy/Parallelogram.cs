using System;

public class Parallelogram : Quadrilateral
{
    private float myHeight;
    private float myBaseWidth;

    public Parallelogram(float x, float y, float baseWidth, float height) :
        base(x, y, 0, 0, x, y + height, 0, 0)
    {
        TopLeft = new Point(x, y); // only coordinate in use at this level
        MyWidth = baseWidth;
        MyHeight = height;
    }
    public float MyHeight
    {
        get
        {
            return myHeight;
        }
        set
        {
            if (value < 0) // validation
            {
                throw new ArgumentOutOfRangeException(nameof(value),
                   value, $"{nameof(MyHeight)} must be >= 0");
            }
            myHeight = value;
        }
    }

    public float MyWidth
    {
        get
        {
            return myBaseWidth;
        }
        set
        {
            if (value < 0) // validation
            {
                throw new ArgumentOutOfRangeException(nameof(value),
                   value, $"{nameof(MyWidth)} must be >= 0");
            }
            myBaseWidth = value;
        }
    }
    public override float ShapeArea() => MyWidth * MyHeight; 
    // everything downstream is calculated the same

    public override string UniquePart() => $"{base.UniquePart()}";
    // carry over unique value from upsteram

    public override string ToString() =>
                                        $"Shape: {this.GetType().Name}\n" +
                                        $"{UniquePart()}\n" +
                                        $"Width: {MyWidth:F0}\n" +
                                        $"Height: {MyHeight:F0}\n" +
                                        $"Formula: Width * Height\n" +
                                        $"Area: {ShapeArea():F2}\n";
}


