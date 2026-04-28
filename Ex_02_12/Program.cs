namespace Ex_02_12;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("値を入力してください->");
        int num=int.Parse(System.Console.ReadLine());
        int answer=Mul3(num);
        Console.WriteLine(answer);

        int Mul3(int x)
        {
            return x*3;
        }
    }
}
