namespace Example;


static class Program
{
    static void Main(string[] args)
    {
        Warrior warrior = new Warrior();
        warrior.Greet();//Humanクラスのメソッドの呼び出し
        warrior.Attack();//Warriorクラスのメソッドの呼び出し
    }
}