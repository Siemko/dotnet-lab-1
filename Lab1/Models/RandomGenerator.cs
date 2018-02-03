using Lab1.Interfaces;
using System;
using System.Collections.Generic;

namespace Lab1.Models
{
    public class RandomGenerator : IGenerator
    {
        private int Count { get; set; }

        public List<double> GetData()
        {
            var rnd = new Random();
            var list = new List<double>();

            for (int i = 0; i < Count; i++)
            {
                list.Add(rnd.NextDouble() * (1 - 0) + 0);
            }
            return list;
        }

        public void PassParameter(object count)
        {
            Count = Convert.ToInt32(count);
        }
    }
}