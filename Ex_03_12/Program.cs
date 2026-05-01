namespace Ex_03_12;
using Ex_03_12.Modules;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("DVDのタイトルを入力してください->");
        string Media=System.Console.ReadLine();

        Player dvdplayer = new DVDPlayer(Media);
        dvdplayer.UseMachine();

        Console.Write("ブルーレイのタイトルを入力してください->");
        Media=System.Console.ReadLine();

        Player blurayplayer = new BlurayPlayer(Media);
        blurayplayer.UseMachine();
    }
}
