class Program
{
    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("Write the width");
        int width = int.Parse(Console.ReadLine());
        Console.WriteLine("Write  the height");
        int height = int.Parse(Console.ReadLine());
        Console.WriteLine("Choose 1 for Triangle or 2 for Rectangle");
        int awnser = int.Parse(Console.ReadLine());
        if(awnser == 1)
        {
            Triangle triangle = new Triangle(width, height);
            Console.WriteLine("Area: " + triangle.Area());
            Console.WriteLine("Circumferance: " + triangle.Circumferance());
        }
        else
        {
            Rectangle rectangle = new Rectangle(width, height);
            Console.WriteLine("Area: " + rectangle.Area());
            Console.WriteLine("Circumferance: " + rectangle.Circumferance());
        }
    }
}