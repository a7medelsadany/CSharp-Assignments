using OOP04.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.implementation
{
    public class Rectangle : IRectangle
    {
        public double width { get; set; }
        public double height { get; set; }
        public double Area => width* height;

        public void DisplayShapeInfo()
        {
            Console.WriteLine("this shape is : rectangle");
            Console.WriteLine($"width is : {width} , height is : {height}");
            Console.WriteLine($"area is : {Area}");
        }
    }
}
