namespace Ex_03_16;

static class Program
{
    static void Main(string[] args)
    {
        try {
            Console.Write("値1を入力してください->");
            int val1 = int.Parse(Console.ReadLine());
            Console.Write("値2を入力してください->");
            int val2 = int.Parse(Console.ReadLine());

            var calc = new Calculator();
            Console.WriteLine($"値1 / 値2 = {calc.Div(val1, val2)}");
        }
        catch(InputParameterLessThanZeroException e)
        {
            Console.WriteLine(e.Message);
        }
        catch(DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("必ず実行");
        }
        Console.WriteLine("プログラム正常終了");
    }
}