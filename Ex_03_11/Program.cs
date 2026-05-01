namespace Ex_03_11;
using Ex_03_11.Modules;
static class Program
{
    static void Main(string[] args)
    {
        IUSB mouse = new Mouse();
        IUSB flashmemory = new FlashMemory();
        IUSB display = new Display();

        flashmemory.SendData();
        flashmemory.ReciveData();
        mouse.SendData();
        display.ReciveData();
    }
}
