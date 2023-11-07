using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I020.Objects
{
    public sealed class Z01 : IPrint
    {
        public void Print()
        {
            Debug.WriteLine("print!!");
        }
    }
}
