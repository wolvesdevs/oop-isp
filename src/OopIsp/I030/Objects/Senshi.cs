using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I030.Objects
{
    public sealed class Senshi : CharaBase, IPlayer
    {
        public Senshi() : base(10, 50, Color.Red)
        {
        }

        public void Right()
        {
            X += 20;
        }
    }
}
