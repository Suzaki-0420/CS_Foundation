using System.Data;

namespace Ex_02_03;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("数値を入力してください->");
        string a = Console.ReadLine();//変数valueに入力された値を代入
        int b =int.Parse(a);
        Console.WriteLine($"5を加算した結果は{b+5}です");
        Console.WriteLine($"5を減算した結果は{b-5}です");
    }
}
