using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.interfaces
{
    internal interface IRectangle:IShape
    {
        public double width { get; set; }
        public double height { get; set; }
    }
}
