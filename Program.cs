namespace TemperatureAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            TemperatureAnalyzer temp = new TemperatureAnalyzer();

            Console.WriteLine(temp.FindHighestTemperature(temp.temperatures));

            Console.WriteLine(temp.FindLowestTemperature(temp.temperatures));


        }
    }
}