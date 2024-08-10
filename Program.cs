using Newtonsoft.Json;

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        var json = JsonConvert.SerializeObject(new { Id = 1, Name = "One" });
        Console.WriteLine(json);
    }
}
