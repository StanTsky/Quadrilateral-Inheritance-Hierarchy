public class Rectangle : Parallelogram
{
    public Rectangle(float x, float y, float length, float width) :
    base(x,y,length,width)
    {
    }

    public override float ShapeArea() => MyWidth * MyHeight;
    // everything downstream is calculated the same

    public override string UniquePart() => $"{base.UniquePart()}";
    // carry over unique value from upsteram

    public override string ToString() =>
                                        $"Shape: {this.GetType().Name}\n" +
                                        $"{UniquePart()}\n" +
                                        $"Width: {MyWidth:F0}\n" +
                                        $"Length: {MyHeight:F0}\n" +
                                        $"Formula: Width * Length\n" +
                                        $"Area: {ShapeArea():F2}\n";
}
