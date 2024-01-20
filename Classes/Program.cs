
namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Car roadster = new Car("BMW Z4", "Roadster", 2024);
            Console.WriteLine($"{roadster.Make}\n{roadster.Model}\n{roadster.Year}");
        }
    }
}
