string day = "本日";
string wether = "晴れ";
// 可変数の引数を渡せる
StringConcatenation(day, "は", wether, "です。");
/// <summary>
/// 引数の文字列を結合して表示する
/// </summary>
/// <param name="strings">結合する文字列</param>
static void StringConcatenation(params string[] strings)
{
    var result = "";
    for (int i = 0; i < strings.Length; i++)
    {
        result += strings[i];
    }
    Console.WriteLine(result);
}