namespace Example;


static class Program
{
    static void Main(string[] args)
    {
        Warrior warrior = new("ユータ", 15);
        Console.WriteLine(warrior.name);
        Console.WriteLine(warrior.hp);

        Warrior warrior2 = new("三郎");
        Console.WriteLine(warrior2.name);
        Console.WriteLine(warrior2.hp);
        warrior2.hp=12;
        Console.WriteLine(warrior2.name);
        Console.WriteLine(warrior2.hp);

    }
}