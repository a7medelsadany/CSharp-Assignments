using OOP04.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.implementation
{
    internal class Circle : ICircle
    {
        
       
        public double radius { get; set; }
        public double Area=> Math.PI * radius * radius;

        public void DisplayShapeInfo()
        {
            Console.WriteLine("this shape is : circle");
            Console.WriteLine($"radius is : {radius}");
            Console.WriteLine($"area is : {Area}");
        }
    }
}
