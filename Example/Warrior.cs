namespace Example;
/// <summary>
/// 戦士を表すクラス
/// </summary>
public class Warrior
{
    public string name;     // 名前を表すフィールド
    public int hp = 10;     // 体力を表すフィールド
    public int ap = 5;      // 攻撃力を表すフィールド
    public int dp;          // 防御力を表すフィールド
    /// <summary>
    /// 挨拶を行うメソッド
    /// </summary>
    public void Greet()
    {
        Console.WriteLine($"{name}:hi!");
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
    /// <param name="monster">攻撃対象の魔物</param>
    public void Attack(Monster monster)
    {
        Console.WriteLine($"{name}の攻撃!");
        monster.Defence(ap);//攻撃対象の魔物に防御させる
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