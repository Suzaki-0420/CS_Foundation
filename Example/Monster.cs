namespace Example;
/// <summary>
/// 魔物を表すクラス
/// </summary>
public class Monster
{
    public string name;     // 魔物の名前を表すフィールド
    public int hp = 10;     // 魔物の体力を表すフィールド
    public int ap = 5;      // 魔物の攻撃力を表すフィールド
    public int dp;          // 魔物の防御力を表すフィールド
    /// <summary>
    /// 挨拶を行うメソッド
    /// </summary>
    public void Greet()
    {
        Console.WriteLine($"{name}:Grr...");
    }
    /// <summary>
    /// 体力ゲージを返すメソッド
    /// </summary>
    /// <returns>体力ゲージの文字列</returns>
    public string GetHpMeter()
    {
        string meter = $"{name} ";
        for (int i = 0; i < hp; i++)
        {
            meter += "|";
        }
        return meter;
    }
    /// <summary>
    /// 攻撃を行うメソッド
    /// </summary>
    /// <param name="warrior">攻撃対象の戦士</param>
    public void Attack(Warrior warrior)
    {
        Console.WriteLine($"{name}の攻撃!");
        warrior.Defence(ap);//攻撃対象の戦士に防御させる
    }
    /// <summary>
    /// 防御を行うメソッド
    /// </summary>
    /// <param name="damage">受けるダメージの値</param>
    public void Defence(int damage)
    {
        var defencedDamage = damage - dp;
        hp -= defencedDamage;
        Console.WriteLine($"{name}は{defencedDamage}のダメージを受けた");

        
    }
}