using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureAnalyzer
{
    public class TemperatureAnalyzer
    {

        int[] temperatures = new int[5] {1, 2, 3, 4, 5};  


        // Znajduje najwyższą temperaturę w tablicy temperatur
        public int FindHighestTemperature(int[] temperatures)
        {
            // TODO: Uzupełnij implementację, znajdując najwyższą temperaturę
            // wśród wszystkich temperatur w tablicy.
            // Zwróć wartość najwyższej temperatury.
            return temperatures.Max();
        }


        // Znajduje najniższą temperaturę w tablicy temperatur
        public static int FindLowestTemperature(int[] temperatures)
        {
            // TODO: Uzupełnij implementację, znajdując najniższą temperaturę
            // wśród wszystkich temperatur w tablicy.
            // Zwróć wartość najniższej temperatury.
            return temperatures.Min();
        }

    }
}
