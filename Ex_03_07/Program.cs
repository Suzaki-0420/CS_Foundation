namespace Ex_03_07;
using Ex_03_07.Modules;

static class Program
{
    static void Main(string[] args)
    {
        Item item = new();
        //デフォルトコンストラクタが消えたのでここでnewをするとエラーになる
        Console.Write("商品番号を入力してください->");
        item.itemNo=System.Console.ReadLine();

        Console.Write("商品名を入力してください->");
        item.itemName=System.Console.ReadLine();

        Console.Write("単価を入力してください->");
        item.price=int.Parse(System.Console.ReadLine());

        item.Print(item.itemNo,item.itemName,item.price);
    }
}
