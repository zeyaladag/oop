using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* all type definitions (class, struct, interface, delegate, enum) are included in one namespace.
 * namespace is a place where all instruments that has the same purpose are located.
 * it can be viewed as packages in java. good for encapsulation.
 */

namespace Basics
{
    internal class Car
    {
        public string Name;
        // color field can only be defined from our own enum constant color
        public Colors Color;
        public string Model;
        public short Year;
    }
}
