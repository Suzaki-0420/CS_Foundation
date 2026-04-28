namespace Ex_03_03;

/// <summary>
/// 商品情報を表すクラス
/// </summary>
public class Item
{
    public int itemNo; //商品番号
    public string itemName; //商品名
    public int price;//単価

    public void ChangePrice(int pprice)
    {
        price=pprice;
    }
}