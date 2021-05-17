public abstract class Quadrilateral
{
    public struct Point // accepts point with x,y coordinates
    {
        public float X;
        public float Y;

        public Point(float x, float y)
        {
            X = x;
            Y = y;
        }
    }

    public Point TopLeft { get; set; }
    public Point TopRight { get; set; }
    public Point BottomLeft { get; set; }
    public Point BottomRight { get; set; }

    public Quadrilateral(float x1, float y1,
                         float x2, float y2,
                         float x3, float y3,
                         float x4, float y4)
    {
        Point TopLeft = new Point(x1, y1);
        Point TopRight = new Point(x2, y2);
        Point BottomLeft = new Point(x3, y3);
        Point BottomRight = new Point(x4, y4);
    }

    public virtual string UniquePart() => $"Top Left ({TopLeft.X}, {TopLeft.Y})";

    public override string ToString() => $"Shape: {this.GetType().Name}\n" +
                                        $"{UniquePart()}\n" +
                                        $"Top Right ({TopRight.X}, {TopRight.Y})\n" +
                                        $"Bottom Left ({BottomLeft.X}, {BottomLeft.Y})\n" +
                                        $"Bottom Right ({BottomRight.X}, {BottomRight.Y})";

    public abstract float ShapeArea();
}
