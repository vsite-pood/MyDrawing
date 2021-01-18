﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.pood.MyDrawing.Model
{
    public class Ellipse : Shape, IDrawable, IMoveable, IResizeable, IBounding, IHitable
    {
        public float Left { get; private set; }
        public float Top { get; private set; }
        public float Width { get; private set; }
        public float Height { get; private set; }
        public override RectangleF BoundingRectangle => new RectangleF(Left, Top, Width, Height);

        public Ellipse(float left, float top, float width, float height)
        {
            Left = left;
            Top = top;
            Width = width;
            Height = height;
        }
        public override void Draw(IGraphics graphics)
        {
            graphics.DrawEllipse(this);
        }

        public override void Move(float dx, float dy)
        {
            Left += dx;
            Top += dy;
        }

        public override void Resize(ResizeDirection diretion, float dx, float dy)
        {
            throw new NotImplementedException();
        }

        public override bool Contains(float x, float y)
        {
            return BoundingRectangle.Contains(x, y);
        }
    }
}
