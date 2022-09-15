class Program
{
    public static void Main()
    {
        Console.Clear();
        int awnser;
        Console.WriteLine("Write the width");
        int width = int.Parse(Console.ReadLine());
        Console.WriteLine("Write  the height");
        int height = int.Parse(Console.ReadLine());
        
        List<Shape> ShapeList = new List<Shape>();
        ShapeList.Add(new Triangle(width, height));
        ShapeList.Add(new Rectangle(width, height));
        Console.WriteLine("Choose 1 for Triangle or 2 for Rectangle");
        awnser = int.Parse(Console.ReadLine());

        if(awnser == 1)
        {
            Console.WriteLine("Area: " + ShapeList[0].Area());
            Console.WriteLine("Circumferance: " + ShapeList[0].Circumferance());
        }
        else if(awnser == 2)
        {
            Console.WriteLine("Area: " + ShapeList[1].Area());
            Console.WriteLine("Circumferance: " + ShapeList[1].Circumferance());
        }
    }
}