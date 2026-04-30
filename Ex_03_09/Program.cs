namespace Ex_03_09;

static class Program
{
    static void Main(string[] args)
    {
        NewAccount newaccount = new();
        
        Console.Write("口座番号を入力してください->");
        newaccount.AccountNo=System.Console.ReadLine();

        Console.Write("口座名義を入力してください->");
        newaccount.AccountName=System.Console.ReadLine();

        Console.Write("残高を入力してください->");
        newaccount.Balance=int.Parse(System.Console.ReadLine());

        Console.Write("ポイントを入力してください->");
        newaccount.Point=int.Parse(System.Console.ReadLine());

        Console.WriteLine($"口座番号：{newaccount.AccountNo} 口座名義：{newaccount.AccountName} 残高：{newaccount.Balance} ポイント：{newaccount.Point}");
    }
}
