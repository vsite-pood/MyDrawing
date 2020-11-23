﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Pood.MyDrawing.Model
{
    public class Rectangle : Shape, IDrawable
    {
        public override void Draw(IGraphics graphics)
        {
            graphics.DrawRectangle(this);
        }
    }
}
