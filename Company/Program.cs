namespace Company;
using List3_20Namespace.Sales;
static class Program
{
    static void Main(string[] args)
    {
        //usingディレクティブを使い開発部の鈴木さんを呼び出し

        Suzuki suzuki1 = new();

        //完全修飾名を使い経理部の鈴木さんを呼び出し
        List3_20Namespace.Accounting.Suzuki suzuki2 = new();

        // 山田さんが所属する経理部又は営業部は直接参照できない（コンパイルエラー）
        Yamada yamada = new();
    }
}
