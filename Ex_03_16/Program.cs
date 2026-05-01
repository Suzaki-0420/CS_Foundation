namespace Ex_03_16;

static class Program
{
    static void Main(string[] args)
    {
        var calculator = new Calculator();
        //var input = new InputParameterLessThanZeroException();

        Console.WriteLine("値1を入力してください->");
        int x=int.Parse(System.Console.ReadLine());

        Console.WriteLine("値2を入力してください->");
        int y=int.Parse(System.Console.ReadLine());

        try
        {
            int div=calculator.Div(x,y);
            Console.WriteLine($"値1 / 値2 = {div}");
        }
        catch
        {
            Console.WriteLine("例外:Attempted to divide by zero.");
        }
        finally
        {
            Console.WriteLine("必ず実行");
        }
        Console.WriteLine("プログラム正常終了");
    }
}
