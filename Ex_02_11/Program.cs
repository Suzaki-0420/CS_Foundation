namespace Ex_02_11;

static class Program
{
    static void Main(string[] args)
    {
        string [] stations=["品川","大崎","五反田","目黒","恵比寿","渋谷","原宿","代々木","新宿"];

        Console.Write("駅名を入力してください->");
        string station=System.Console.ReadLine();
        
        for (int count=0;count<stations.Length;count++)
        {
            if (stations[count]==station)
            {
                continue;
            }
            Console.WriteLine(stations[count]); 
        }
    }
}
