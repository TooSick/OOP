﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    class LineCreator : IShapesCreator
    {
        public Shapes CreateShape()
        {
            return new Line();
        }
    }
}
