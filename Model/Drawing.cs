using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Pood.MyDrawing.Model
{
	public class Drawing : IDrawable
	{
		public event EventHandler ModelChanged;
		protected virtual void onModelChanged(EventArgs e) 
		{
            ModelChanged?.Invoke(this, EventArgs.Empty);
        }
		private List<Shape> shapes = new List<Shape>();
		public readonly Selection Selection = new Selection();

		public void Draw(IGraphics graphics)
		{
			foreach ( var shape in shapes )
				shape.Draw( graphics );
		}

		public void Add(Shape shape)
		{
			shapes.Add( shape );
			onModelChanged(EventArgs.Empty);
		}
		public void Remove(Shape shape)
		{
			shapes.Remove( shape );
			onModelChanged(EventArgs.Empty);
		}
		public void Clear()
		{
			shapes.Clear();
			onModelChanged(EventArgs.Empty);
		}

		public IEnumerable<Shape> Shapes
		{
			get { return shapes; }
		}
		public Shape GetHitShape(float x, float y)
		{
			foreach ( Shape shape in shapes )
			{
				if ( shape.Contains( x, y ) )
					return shape;
				
			}
			return null;
		}
	}
}
