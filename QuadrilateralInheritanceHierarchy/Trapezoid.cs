using System;

public class Trapezoid : Quadrilateral
{
    private float myTopBase;
    private float myBottomBase;
    private float myShapeHeight;

    public Trapezoid(float x1, float y1, float topWidth,
                     float bottomWidth, float shapeHeight) :
        base(x1, y1, 0, 0, 0, 0, 0, 0)
    {
        TopLeft = new Point(x1, y1); // only coordinate in use at this level
        MyTopBase = topWidth;
        MyBottomBase = bottomWidth;
        MyShapeHeight = shapeHeight;
    }

    public override float ShapeArea() => ((MyTopBase + MyBottomBase) / 2) * MyShapeHeight;

    public override string UniquePart() => $"{base.UniquePart()}";
    // carry over unique value from upsteram

    public override string ToString() =>
                                        $"Shape: {this.GetType().Name}\n" +
                                        $"{UniquePart()}\n" +
                                        $"Top Width: {MyTopBase:F0}\n" +
                                        $"Bottom Width: {MyBottomBase:F0}\n" +
                                        $"Shape Height: {MyShapeHeight:F0}\n" +
                                        $"Formula: ((Top Base + Bottom Base)/2) * Shape Height\n" +
                                        $"Area: {ShapeArea():F2}\n";
    public float MyTopBase
    {
        get
        {
            return myTopBase;
        }
        set
        {
            if (value < 0) // validation
            {
                throw new ArgumentOutOfRangeException(nameof(value),
                   value, $"{nameof(MyTopBase)} must be >= 0");
            }
            myTopBase = value;
        }
    }

    public float MyBottomBase
    {
        get
        {
            return myBottomBase;
        }
        set
        {
            if (value < 0) // validation
            {
                throw new ArgumentOutOfRangeException(nameof(value),
                   value, $"{nameof(MyBottomBase)} must be >= 0");
            }
            myBottomBase = value;
        }
    }
    public float MyShapeHeight
    {
        get
        {
            return myShapeHeight;
        }
        set
        {
            if (value < 0) // validation
            {
                throw new ArgumentOutOfRangeException(nameof(value),
                   value, $"{nameof(MyShapeHeight)} must be >= 0");
            }
            myShapeHeight = value;
        }
    }
}
