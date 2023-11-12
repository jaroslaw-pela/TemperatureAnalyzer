namespace TemperatureAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            TemperatureAnalyzer temp = new TemperatureAnalyzer();

            int[] temperatures = new int[5] { 1, 2, 3, 4, 5 };

            Console.WriteLine(temp.FindHighestTemperatureFind(temperatures));
        


        }
    }
}