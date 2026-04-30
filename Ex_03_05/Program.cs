namespace Ex_03_05;

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

        Console.Write("新しい単価を入力してください->");
        int pprice=int.Parse(System.Console.ReadLine());

        item.Print(item.itemNo,item.itemName,item.price);
    }
}
