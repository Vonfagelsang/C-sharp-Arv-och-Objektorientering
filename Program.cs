class Shape{
    protected int width;
    protected int height;
    public Shape(int width, int height)
    {
        this.width = width;
        this.height = height;
    }
}
class Triangle : Shape{
    public Triangle() : base(10, 5){

    }
}
class Rectangle : Shape{
    public Rectangle() : base(12, 3){

    }
}

