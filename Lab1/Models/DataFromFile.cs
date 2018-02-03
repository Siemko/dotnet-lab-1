using Lab1.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace Lab1.Models
{
    public class DataFromFile : IGenerator
    {
        private string FileName { get; set; }

        public List<double> GetData()
        {
            List<double> list = new List<double>();

            using (var reader = new StreamReader(FileName))
            {
                while (reader.Peek() >= 0)
                {
                    list.Add(Double.Parse(reader.ReadLine()));
                }
            }
            return list;
        }

        public void PassParameter(object fileName)
        {
            FileName = fileName.ToString();
        }
    }
}