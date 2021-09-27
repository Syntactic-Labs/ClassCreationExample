using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCreationExample
{
    class MathLib
    {
        public int Inc(int a)
        {                                 //incramentaion of an instance
            return ++a;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Multi(int a, int b)
        {
            return a * b;
        }
        public int Div(int a, int b)
        {
            return a / b;
        }
    }
}
