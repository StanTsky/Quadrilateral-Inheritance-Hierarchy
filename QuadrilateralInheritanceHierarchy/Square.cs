public class Square : Rectangle
{
    public Square(float x, float y, float sideWidth) :
    base(x, y, sideWidth, sideWidth)
    {
    }

    public override float ShapeArea() => MyWidth * MyHeight;
    // inherited from upstream

    public override string UniquePart() => $"{base.UniquePart()}";
    // carry over unique value from upsteram

    public override string ToString() =>
                                        $"Shape: {this.GetType().Name}\n" +
                                        $"{UniquePart()}\n" +
                                        $"Side Width: {MyWidth:F0}\n" +
                                        $"Formula: (Side Width)^2\n" +
                                        $"Area: {ShapeArea():F2}\n";
}

