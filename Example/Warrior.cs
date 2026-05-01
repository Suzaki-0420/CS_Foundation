namespace Example;
/// <summary>
/// キャラクターの概念を継承した戦士の具象クラス
/// </summary>
public class Warrior
{
    public static int cnt = 0;

    public string name;
    public int braveNum;

    public Warrior(string pname)
    {
        cnt++;
        name = pname;
        braveNum = cnt;
    }

    public void Greet()
    {
        Console.WriteLine($"こんにちは。{braveNum}人目の戦士{name}です");
    }

    public static void ShowHeroNum()
    {
        Console.WriteLine($"現在、この世界には{cnt}人の戦士がいます");
    }
}