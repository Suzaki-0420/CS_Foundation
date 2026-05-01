namespace Example;


static class Program
{
    static void Main(string[] args)
    {
        try
        {
            int[] vals=null;
            ArrayCalc arrayCalc = new ArrayCalc();
            var sum = arrayCalc.Summarize(vals);
            Console.WriteLine($"合計={0}", sum);
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("配列の誤ったアクセスによる例外");
        }
        catch (NullReferenceException e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("値がNullの変数利用による例外");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("その他の例外");
        }
    }
}