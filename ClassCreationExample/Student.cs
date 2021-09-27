using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCreationExample
{
    class Student
    {
        public string Name { get; set; }

        private int _SAT = 800;                              //getting and setting conditions for instances
        public int SAT { 
            get { return _SAT; }
            set
            {
                if (value < 400 || value > 1600)
                {
                    Console.WriteLine("Invalid SAT score!");
                }
                else
                {
                    this._SAT = value;
                }
            }
            
        }
        public void Print(int code)
        {
            Console.WriteLine($"Code:{code} Name:{this.Name} | sat:{this.SAT}");
        }
    }
}
