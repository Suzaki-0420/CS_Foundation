namespace Ex_03_07.Modules;

/// <summary>
/// 商品情報を表すクラス
/// </summary>
public class Item
{
    public int itemNo{ get; set; } //商品番号
    public string itemName{ get; set; } //商品名
    public int price{ get; set; }//単価

    public void Print(int itemNo,string itemName,int price)
    {
        Console.WriteLine("結果");
        Console.WriteLine($"商品番号 = {itemNo}");
        Console.WriteLine($"商品名 = {itemName}");
        Console.WriteLine($"単価 = {price}");
    }

}