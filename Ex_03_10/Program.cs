using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ex_03_10.Modules;
namespace Ex_03_10;

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("DVDのタイトルを入力してください->");
        string Media=System.Console.ReadLine();

        var dvdplayer = new DVDPlayer(Media);
        dvdplayer.Play();
        dvdplayer.Stop();

        Console.Write("ブルーレイのタイトルを入力してください->");
        Media=System.Console.ReadLine();

        var blurayplayer = new BlurayPlayer(Media);
        blurayplayer.Play();
        blurayplayer.Stop();
    }
}
