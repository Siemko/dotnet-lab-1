using System.Collections.Generic;

namespace Lab1.Interfaces
{
    public interface IGenerator
    {
        List<double> GetData();

        void PassParameter(object obj);
    }
}