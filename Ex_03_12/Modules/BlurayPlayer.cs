namespace Ex_03_12.Modules;

public class BlurayPlayer : Player
{
    public BlurayPlayer(string Media):base(Media){}//コンストラクタ

    public override void Play()
    {
        Console.WriteLine($"Bluray：{this.Media}を再生しています");
    }

    public override void Stop()
    {
        Console.WriteLine($"Bluray：{this.Media}の再生を停止しました");
    }
}