class Shape
{
    protected int width;
    protected int height;
    public Shape(int width, int height)
    {
        this.width = width;
        this.height = height;
    }
    public virtual int Area()
    {
        return (width * height);
    }
    public virtual int Circumferance()
    {
        return (width * 2) + (height * 2);
    }
}