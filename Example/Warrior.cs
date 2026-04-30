namespace Example;
/// <summary>
/// 戦士を表すクラス
/// </summary>
﻿/// <summary>
/// 人物を表すクラス
/// </summary>
public class Human
{
    public string Name { get; set; }
    public int Hp { get; private set; }

    public void Greet()
    {
        Console.WriteLine("Hi!");
    }

    public void Defence(int damage)
    {
        Hp -= damage;
    }
}