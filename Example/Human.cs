namespace Example;

/// <summary>
/// 戦士を表すクラス
/// </summary>
public class Warrior : Human
{
    public int Ap { get; set; } = 5;
    public int Dp { get; set; }

    public void Attack()
    {
        Console.WriteLine("戦士は攻撃した！");
        Console.WriteLine($"{Ap}のダメージを与えた。");
    }
}