namespace Example;
/// <summary>
/// キャラクターの概念を継承した戦士の具象クラス
/// </summary>
public class Warrior : Character
{
    /// <summary>
    /// 挨拶をするメソッド
    /// </summary>
    public override void Greet()
    {
        Console.WriteLine($"{Name}:Hello!");
    }
}