using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01_OOP_C_Sharp
{
    [Flags]
    internal enum permissions:byte
    {
        Read=1,
        Write=2,
        Delete=4,
        Execute=8
    }
}
