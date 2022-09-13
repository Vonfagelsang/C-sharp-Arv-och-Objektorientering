class Triangle : Shape
{
    public Triangle(int width, int height) : base(width, height)
    {
    }
    public int Area()
    {
        return (width * height) / 2;
    }
    public int Circumferance()
    {
        return (width * 3);
    }
}