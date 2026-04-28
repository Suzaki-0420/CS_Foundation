namespace Ex_03_04;

/// <summary>
/// 商品情報を表すクラス
/// </summary>
public class Item
{
    public int itemNo; //商品番号
    public string itemName; //商品名
    public int price;//単価
    public double salesTaxRate = 0.10;//税率

    public int CalculateTaxAmount(double salesTaxRate,int price)
    {
        double taxincluded=price*(1+salesTaxRate);
        int taxincludedint=(int)taxincluded;
        return taxincludedint;
    }
}