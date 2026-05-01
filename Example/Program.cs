namespace Example;


static class Program
{
    static void Main(string[] args)
    {
        Warrior warrior1 = new("ユータ");
        Warrior warrior2 = new("ユーサク");
        Warrior warrior3 = new("ユースケ");
        warrior2.Greet();
        Console.WriteLine($"{Warrior.cnt}");
        Warrior.ShowHeroNum();
    }
}