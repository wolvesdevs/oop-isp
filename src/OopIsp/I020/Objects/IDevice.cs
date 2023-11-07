using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I020.Objects
{
    public interface IPrint
    {
        void Print();
    }

    public interface IFax
    {
        void Fax();
    }

    public interface IScan
    {
        void Scan();
    }
}
