namespace P_1;

static class Program
{
    static void Main(string[] args)
    {
        List<Expens> expens = new List<Expens>();
        int sum = 0;//すべての合計金額
        while (true)
        {
            Console.Write("日付を入力してください->");
            string date = System.Console.ReadLine();

            if (date == "End")
            {
                break;
            }

            Console.Write("カテゴリを入力してください->");
            string category = System.Console.ReadLine();

            Console.Write("金額を入力してください->");
            int amount = int.Parse(System.Console.ReadLine());


            Expens expenses = new Expens(date, category, amount);
            expens.Add(expenses);

            //すべての支出が入ったリストが完成する
            //ここから処理をしていく
        }
        ShowCategoryTotal(expens);
        ShowTotalandOveruse(expens);
    }

    //メソッド
    static void ShowCategoryTotal(List<Expens> expenses)
    {
        Dictionary<string, int> categoryTotals = new Dictionary<string, int>();

        foreach (Expens expense in expenses)
        {
            // 初登場カテゴリなら0を入れる
            if (!categoryTotals.ContainsKey(expense.Category))
            {
                categoryTotals[expense.Category] = 0;
            }

            // 加算
            categoryTotals[expense.Category] += expense.Amount;
        }

        // 表示
        foreach (KeyValuePair<string, int> item in categoryTotals)
        {
            Console.WriteLine($"{item.Key} : {item.Value}円");
        }

        Console.WriteLine();
    }

    static void ShowTotalandOveruse(List<Expens> expenses)
    {
        int total = 0;
        foreach (Expens expens in expenses)
        {
            total += expens.Amount;
        }

        if (total >= 10000)
        {
            Console.WriteLine("使いすぎです！！");
        }
    }
}
