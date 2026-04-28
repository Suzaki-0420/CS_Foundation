namespace Ex_02_04;

static class Program
{
    static void Main(string[] args)
    {
        var arrayA=new int[3];
        Console.Write("数値1を入力してください->");
        arrayA[0]=int.Parse(System.Console.ReadLine());
        Console.Write("数値2を入力してください->");
        arrayA[1]=int.Parse(System.Console.ReadLine());
        Console.Write("数値3を入力してください->");
        arrayA[2]=int.Parse(System.Console.ReadLine());

        Console.WriteLine("入力結果");
        Console.WriteLine($"数値1：{arrayA[0]}です");
        Console.WriteLine($"数値2：{arrayA[1]}です");
        Console.WriteLine($"数値3：{arrayA[2]}です");
    }
}
