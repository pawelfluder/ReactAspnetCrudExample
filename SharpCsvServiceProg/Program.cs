using SharpCSVServiceProg.Service;

namespace SharpCSVServiceProg
{
    internal partial class Program
    {
        static async Task Main(string[] args)
        {
            var csvServie = new CsvService();
            //var filePath = "CsvFiles/Example01.csv";
            //var result = csvServie.Read<Foo>(filePath);
        }
    }
}
