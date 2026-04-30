using Ex_03_09.Modules;
namespace Ex_03_09;

static class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("口座番号を入力してください->");
        string AccountNo=System.Console.ReadLine();

        Console.Write("口座名義を入力してください->");
        string AccountName=System.Console.ReadLine();

        Console.Write("残高を入力してください->");
        int Balance=int.Parse(System.Console.ReadLine());

        Console.Write("ポイントを入力してください->");
        int Point=int.Parse(System.Console.ReadLine());

        NetAccount netaccount = new NetAccount(AccountNo,AccountName,Balance,Point);

        netaccount.Print();
        netaccount.ToString();
    }
}
