using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //explict typing -
            string variable = "Hello";

            //infered typing -
            var varName = "Hello";

            var a = 17;
            var b = 4;

            var div = a / b;
            var mod = a % b;

            Console.WriteLine($"{a}/{b} is {div} remainder {mod}");

            var r = 20;
            var pi = Math.PI;
            
            var areaOfCircle = pi * (r * r);

            Console.WriteLine($" The area of a circle with radius of {r} is {areaOfCircle}");







        }
    }
}
