namespace Ex_02_03;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("文字列を入力してください->");
        int a = Console.ReadLine();//変数valueに入力された値を代入
        Console.WriteLine($"5を加算した結果は{a+5}です");
        Console.WriteLine($"5を減算した結果は{a-5}です");
    }
}
