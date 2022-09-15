class Rectangle : Shape
{
    public Rectangle(int width, int height) : base(width, height)
    {
    }
    public override int Area()
    {
        return (width * height);
    }
    public override int Circumferance()
    {
        return (width * 2) + (height * 2);
    }
}