using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Lab1.Interfaces;

namespace Lab1.Models
{
    public class Analizator
    {
        public IGenerator Generator { private get; set; }

        public double CalculateAverage()
        {
            var generatorData = Generator.GetData();
            return generatorData.Any() ? generatorData.Average() : 0;
        }

        public double CalculateDeviation()
        {
            var generatorData = Generator.GetData();
            return generatorData.Any()
                ? Math.Sqrt(generatorData.Sum(num => Math.Pow(num - generatorData.Average(), 2)) /
                            (generatorData.Count() - 1))
                : 0;
        }

        public void SaveSortedList(string fileName)
        {
            var generatorData = Generator.GetData();
            generatorData.Sort();
            SaveToFile(generatorData, fileName);
        }

        private static void SaveToFile(IEnumerable<double> values, string fileName)
        {
            using (var writer = new StreamWriter(fileName))
            {
                foreach (var number in values)
                    writer.WriteLine(number);
            }
        }

        public static List<double> ReadFromFile(string fileName)
        {
            var list = new List<double>();
            using (var reader = new StreamReader(fileName))
            {
                while (reader.Peek() >= 0) list.Add(double.Parse(reader.ReadLine()));
            }

            DeleteFile(fileName);
            return list;
        }

        private static bool DeleteFile(string fileName)
        {
            if (!File.Exists(fileName)) return false;
            File.Delete(fileName);
            return true;

        }
    }
}