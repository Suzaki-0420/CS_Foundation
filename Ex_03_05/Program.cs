namespace Ex_03_05;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("商品番号を入力してください->");
        int itemNo=int.Parse(System.Console.ReadLine());

        Console.Write("商品名を入力してください->");
        string itemName=System.Console.ReadLine();

        Console.Write("単価を入力してください->");
        int price=int.Parse(System.Console.ReadLine());

        Item item = new(itemNo,itemName,price);

        item.Print(item.itemNo,item.itemName,item.price);
    }
}
