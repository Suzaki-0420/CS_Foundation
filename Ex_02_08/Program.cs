namespace Ex_02_08;

static class Program
{
    static void Main(string[] args)
    {
        string [] stations=["品川","大崎","五反田","目黒","恵比寿","渋谷","原宿","代々木","新宿"];
        int count =0;
        while (count < stations.Length)
        {
        Console.WriteLine(stations[count]); 
        count+=1;
        }
    }
}
