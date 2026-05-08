using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P_1
{
    public class Expens
    {
        public string Date { get; set; }//日付のプロパティ
        public string Category { get; set; }//カテゴリのプロパティ
        public int Amount { get; set; }//金額のプロパティ

        //コンストラクタ
        public Expens(string Date, string Category, int Amount)
        {
            this.Date = Date;
            this.Category = Category;
            this.Amount = Amount;
        }

        //以下メソッド
    }
}