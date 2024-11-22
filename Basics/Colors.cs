using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics

/* One of the data types we can design is enum constants.
 * they make numerics more readable.
 * enums doesn't contain any functions or methods like class or struct
 */
{
    internal enum Colors
    {
        Black = 100,
        White = 200,
        Green = 300,
        Blue = 400
    }
    
    internal struct ObjectColor
    {
        public byte Red;
        public byte Green;
        public byte Blue;
        public byte TransperencyRate;
    }
}
