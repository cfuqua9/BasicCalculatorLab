using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** BASIC WEATHER CALCULATOR ***");

            //declare some vairabes
            string input;
            int temp;
            int relHumidity;
            int dewpoint;


            // Ask the user for the temp
            Console.WriteLine("Enter a Temperature");
            input = Console.ReadLine();
            temp = int.Parse(input);

            // Ask them for rell humidity
            Console.WriteLine("Enter RH");
            input = Console.ReadLine();
            relHumidity = int.Parse(input);

            // calculate the dew point
            dewpoint = temp - 9 * (100 - relHumidity) / 25;

            // print the dew point
            Console.WriteLine("dewpoint=" + dewpoint);
            // ask for the windspeed

            // calculate windchill

        }
    }
}
