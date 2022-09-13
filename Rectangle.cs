class Rectangle : Shape
{
    public Rectangle(int width, int height) : base(width, height)
    {
    }
    public int Area()
    {
        return (width * height);
    }
    public int Circumferance()
    {
        return (width * 2) + (height * 2);
    }
}