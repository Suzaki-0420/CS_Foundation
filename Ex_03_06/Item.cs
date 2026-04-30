namespace Ex_03_06;

/// <summary>
/// 商品情報を表すクラス
/// </summary>
public class Item
{
    public int itemNo; //商品番号
    public string itemName; //商品名
    public int price;//単価

    public void Print(int itemNo,string itemName,int price)
    {
        Console.WriteLine("結果");
        Console.WriteLine($"商品番号 = {itemNo}");
        Console.WriteLine($"商品名 = {itemName}");
        Console.WriteLine($"単価 = {price}");
    }

    ///<summary>
    /// コンストラクタ
    /// </summary>
    
    public Item()
    {}

    public void ChangePrice(int price)
    {
        this.price=price;
    }
    public void ChangePrice(string price)
    {
        int intprice=int.Parse(price);
        this.price=intprice;
    }

}