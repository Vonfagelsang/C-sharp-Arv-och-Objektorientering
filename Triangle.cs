class Triangle : Shape
{
    public Triangle(int width, int height) : base(width, height)
    {
    }
    public override int Area()
    {
        return (width * height) / 2;
    }
    public override int Circumferance()
    {
        return (width * 3);
    }
}