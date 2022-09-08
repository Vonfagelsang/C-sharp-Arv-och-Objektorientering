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
    public Triangle(int width, int height) : base(width, height){
    }
    public int Area(){
        int Area = (width * height) / 2;
        return Area;
    }
    public int Circumferance(){
        int Circumferance = (width * 3);
        return Circumferance;
    }
}
class Rectangle : Shape{
    public Rectangle(int width, int height) : base(width, height){
    }
    public int Area(){
        int Area = (width * height);
        return Area;
    }
    public int Circumferance(){
        int Circumferance = (width * 2) + (height * 2);
        return Circumferance;
    }
}
class Program{
    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("Write the width");
        int width = int.Parse(Console.ReadLine());
        Console.WriteLine("Write  the height");
        int height = int.Parse(Console.ReadLine());
        Console.WriteLine("Choose 1 for Triangle or 2 for Rectangle");
        int awnser = int.Parse(Console.ReadLine());
        if(awnser == 1){
            Triangle triangle = new Triangle(width, height);
            Console.WriteLine("Area: " + triangle.Area());
            Console.WriteLine("Circumferance: " + triangle.Circumferance());
        }
        else{
            Rectangle rectangle = new Rectangle(width, height);
            Console.WriteLine("Area: " + rectangle.Area());
            Console.WriteLine("Circumferance: " + rectangle.Circumferance());
        }
    }
}