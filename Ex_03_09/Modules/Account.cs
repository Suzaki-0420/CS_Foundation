namespace Ex_03_09.Modules;
public class Account
{
    public string? AccountNo { get; set; } //口座番号
    public string? AccountName { get; set; } //口座名義
    public int Balance { get; set; } //残高

    public Account(string AccountNo, string AccountName, int Balance)
    {
        this.AccountNo=AccountNo;
        this.AccountName=AccountName;
        this.Balance=Balance;
    }

    public virtual void Print()
    {
        Console.WriteLine("結果");
        Console.WriteLine($"口座番号:{AccountNo}");
        Console.WriteLine($"残高:{Balance}");
    }

    public override string ToString()
    {
        return $"Account[AccountNo={AccountNo},AccountName={AccountName},Balance ={Balance}]";
    }
}