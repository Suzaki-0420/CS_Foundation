namespace Example;


static class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        Console.WriteLine($"random.Next(1, 6):{random.Next(1, 6)}");
        Console.WriteLine($"random.NextSingle():{random.NextSingle()}");
        int[] vs = { 8, 3, 5, 7, 2 };
        random.Shuffle(vs);
        Console.WriteLine("random.Shuffle({ 8, 3, 5, 7, 2 });");
        foreach ( int v in vs) {  Console.Write(v); }
    }
}