using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCreationExample
{
    class MathLib
    {   //Constructor... This is auto made for us. An unseen default if this was not made... (option)
        //When first Constuctor is made (probably one that had paras) make an empty Constuctor to avoid errors
        public MathLib(){}  

        public int Inc(int a)
        {                                 
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
