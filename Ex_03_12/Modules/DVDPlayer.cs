namespace Ex_03_12.Modules;

public class DVDPlayer : Player
{
    public DVDPlayer(string Media):base(Media){}//コンストラクタ

    public override void Play()
    {
        Console.WriteLine($"DVD：{this.Media}を再生しています");
    }

    public override void Stop()
    {
        Console.WriteLine($"DVD：{this.Media}の再生を停止しました");
    }
}