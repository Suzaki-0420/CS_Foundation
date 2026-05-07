using Ex_04_03.Modules;
namespace Ex_04_03;

static class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees= new List<Employee>();
        while (true)
        {
            Console.Write("社員番号を入力してください->");
            string id = System.Console.ReadLine();

            if (id=="End")
            {
                break;
            }

            Console.Write("社員名を入力してください->");
            string name = System.Console.ReadLine();

            Console.Write("住所を入力してください->");
            string address = System.Console.ReadLine();

            Employee employee = new Employee(int.Parse(id), name, address);
            employees.Add(employee);
            Console.WriteLine(employee);
        }
        foreach (Employee employee in employees)
        {
            Console.WriteLine($"Enployee[{employee}]");
        }
    }
}
