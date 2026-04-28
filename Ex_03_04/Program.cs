namespace Ex_03_04;

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

        int taxincluded=item.CalculateTaxAmount(item.salesTaxRate,item.price);
        Console.WriteLine($"税込み金額 = {taxincluded}");
    }
}
