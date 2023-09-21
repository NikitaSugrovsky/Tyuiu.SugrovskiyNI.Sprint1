using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SugrovskiyNI.Sprint1.Task2.V10.Lib
{
    public class DataService : ISprint1Task1V10
    {
        public double Calculate(double a, double b)
        {
            
            return a * b;

        }

        public string Calculate(int a)
        {
            throw new NotImplementedException();
        }
    }
}

