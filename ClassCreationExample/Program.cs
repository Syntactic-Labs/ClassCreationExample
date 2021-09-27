using System;

namespace ClassCreationExample {
    class Program {
        static void Main(string[] args) {

            var fred = new Student();           //Goes with StudentLib Class that was created
            fred.Name = "Fred";
            fred.SAT = 1000;
            var wilma = new Student();
            wilma.Name = "Wilma";
            wilma.SAT = 2000;
            var barney = new Student();
            barney.Name = "Barney";
            barney.SAT = 1200;
            wilma.Print(1);
            fred.Print(2);
            barney.Print(3);
            barney.SAT += 20;
            barney.Print(4);
 //----------------------------------------------------------------------------------------------------------------------------------------------------------------------
            var a = 1;
            var b = 6;
            var mathlib = new MathLib();                //Goes with MathLib Class that was created
            var subResult = mathlib.Sub(a,b);
            Console.WriteLine($"Answer is {subResult}");
            
                                                        //Goes with MathLib Class that was created
            var addResult = mathlib.Add(a,b);
            Console.WriteLine($"Answer is {addResult}");

                                                        //Goes with MathLib Class that was created
            var multiResult = mathlib.Multi(a,b);
            Console.WriteLine($"Answer is {multiResult}");

                                                        //Goes with MathLib Class that was created
            var divResult = mathlib.Div(a,b);
            Console.WriteLine($"Answer is {divResult}");
        }
    }
}
