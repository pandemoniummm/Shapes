﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public interface Shape
    {
        void Draw();
        int GetArea();
        int GetPerimeter();
    }
}
