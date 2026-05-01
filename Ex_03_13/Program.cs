using System.Formats.Asn1;

namespace Ex_03_13;

static class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(5);

        Console.WriteLine($"5 * 5 * 3.14 ={circle.AreaCalculation()}");
        Console.WriteLine($"5 * 5 * 3.14 ={Circle.AreaCalculation(5)}");

    }
}
