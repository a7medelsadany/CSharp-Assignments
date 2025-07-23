using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP05
{
    internal class Point3D
    {
        public double point1 { get; set; }
        public double point2 { get; set; }
        public double point3 { get; set; }

        public Point3D():this(0,0,0) { }
        public Point3D(double _point1) : this(_point1, 0, 0) { }
        public Point3D(double _point1, double _point2) : this(_point1, _point2, 0) { }
        public Point3D(double _point1, double _point2, double _point3)
        {
            point1 = _point1;
            point2 = _point2;
            point3 = _point3;
        }
        public override string ToString()
        {
            return $"Point Coordinates {point1},{point2},{point3}";
        }
        public object Clone() => new Point3D(point1, point2, point3);
       

    }
}
