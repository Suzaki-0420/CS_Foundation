namespace Ex_04_02;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("年を入力してください->");
        int year = int.Parse(System.Console.ReadLine());
        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine($"{year}年は閏年です。");
        }
        else
        {
            Console.WriteLine($"{year}年は閏年ではありません。");
        }
    }
}
