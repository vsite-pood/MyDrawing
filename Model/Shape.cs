﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.POOD.MyDrowing.Model
{
    public abstract class Shape : IDrawable, IMovable
    {
        public abstract void Draw(IGraphics graphics);
        public abstract void Move(float dx, float dy);
    }
}
