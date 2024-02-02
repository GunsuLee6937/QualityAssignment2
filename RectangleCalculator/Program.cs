
using RectangleCalculator;

internal class Program
{
    private static void Main(string[] args)
    {
        var rect = new Rectangle();
        Console.WriteLine("Rectagle Calculator");
        Console.Write("Enter length: ");
        var length = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter width: ");
        var width = Convert.ToInt32(Console.ReadLine());
        rect.SetLength(length);
        rect.SetWidth(width);

        Console.WriteLine($"Area : {rect.GetPerimeter()}");
        Console.WriteLine($"Area : {rect.GetArea()}");
        
    }
}