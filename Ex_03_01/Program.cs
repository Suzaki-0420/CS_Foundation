using System.Net.ServerSentEvents;

namespace Ex_03_01;

static class Program
{
    static void Main(string[] args)
    {
        Item item=new();
        Console.Write("商品番号を入力してください->");
        item.itemNo=int.Parse(System.Console.ReadLine());

        Console.Write("商品名を入力してください->");
        item.itemName=System.Console.ReadLine();

        Console.Write("単価を入力してください->");
        item.price=int.Parse(System.Console.ReadLine());

        Console.WriteLine($"商品番号 = {item.itemNo}");
        Console.WriteLine($"商品名 = {item.itemName}");
        Console.WriteLine($"単価 = {item.price}");
    }
}
