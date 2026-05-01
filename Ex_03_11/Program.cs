namespace Ex_03_11;
using Ex_03_11.Modules;
static class Program
{
    static void Main(string[] args)
    {
        var mouse = new Mouse();
        var flashmemory = new FlashMemory();
        var display = new Display();

        flashmemory.SendData();
        flashmemory.ReciveData();
        mouse.SendData();
        display.ReciveData();
    }
}
