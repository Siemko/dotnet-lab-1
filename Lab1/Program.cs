using System;
using Lab1.Models;
using TimeSpanLib;

namespace Lab1
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var analizator = new Analizator();

            Console.WriteLine("RandomGenerator:");
            var randomGenerator = new RandomGenerator();
            randomGenerator.PassParameter(10);

            analizator.Generator = randomGenerator;
            var avg = analizator.CalculateAverage();
            var stdDev = analizator.CalculateDeviation();

            var timeSpanHelper = new TimeSpanHelper();

            var startDate = DateTime.Now;
            analizator.SaveSortedList("output.txt");
            var endDate = DateTime.Now;

            var timeSpan = timeSpanHelper.CalculateTimeSpan(startDate, endDate);
            Console.WriteLine("Czas zapisu: ");
            Console.WriteLine(timeSpan + " [ms]");

            Console.WriteLine();
            Console.WriteLine("Średnia: ");
            Console.WriteLine(avg);

            Console.WriteLine();
            Console.WriteLine("Odchylenie: ");
            Console.WriteLine(stdDev);

            Console.ReadKey();
        }
    }
}