namespace Ex_03_06;

static class Program
{
    static void Main(string[] args)
    {
        Item item = new();
        //デフォルトコンストラクタが消えたのでここでnewをするとエラーになる
        Console.Write("商品番号を入力してください->");
        item.itemNo=int.Parse(System.Console.ReadLine());

        Console.Write("商品名を入力してください->");
        item.itemName=System.Console.ReadLine();

        Console.Write("単価を入力してください->");
        item.price=int.Parse(System.Console.ReadLine());

        Console.Write("新しい単価を入力してください->");
        int newprice=int.Parse(System.Console.ReadLine());

        //1回目の単価変更（int型が入る）
        item.ChangePrice(newprice);
        //1回目の単価変更後の表示
        item.Print(item.itemNo,item.itemName,item.price);

        Console.Write("さらに新しい単価を入力してください->");
        string newprice2 = System.Console.ReadLine(); //string型

        //2回目の単価変更（string型が入る）
        item.ChangePrice(newprice2);
        //2回目の単価変更後の表示
        item.Print(item.itemNo,item.itemName,item.price);
    }
}
