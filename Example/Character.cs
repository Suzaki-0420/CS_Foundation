namespace Example;

/// <summary>
/// キャラクターの概念を表す抽象クラス
/// </summary>
public abstract class Character
{
    public string Name { get; set; }
    /// <summary>
    /// 挨拶をする抽象メソッド
    /// </summary>
    public abstract void Greet();
}