﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Pood.MyDrawing.Model
{
    public abstract class Shape : IDrawable,IMovable,IResizeable
    {
        public abstract void Draw(IGraphics graphics);
		public abstract void Move(float dx, float dy);
		public abstract void Resize(IResizeable.ResizeDirection direction, float dx, float dy);
	}
}
