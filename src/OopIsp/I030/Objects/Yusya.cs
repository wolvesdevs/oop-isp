﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I030.Objects
{
    public sealed class Yusya : CharaBase, IPlayer
    {
        public Yusya() : base(10, 10, Color.Blue)
        {
        }

        public void Right()
        {
            X += 10;
        }
    }
}
