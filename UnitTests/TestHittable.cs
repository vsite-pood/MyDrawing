using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Vsite.Pood.MyDrawing.Model;

namespace Vsite.Pood.MyDrawing.UnitTests
{
	[TestClass]
	public class TestHittable
	{
		[TestMethod]
		public void ContainsReturnsTrueForAPointInsideAShape()
		{
			Shape s1 = new Rectangle( 10, 20, 100, 50 );
			Assert.IsTrue( s1.Contains( 20, 30 ) );

			Shape s2 = new Ellipse( 10, 20, 100, 50 );
			Assert.IsTrue( s2.Contains( 20, 30 ) );
		}
		
		[TestMethod]
		public void ContainsReturnsFalseForAPointOutsideAShape()
		{
			Shape s1 = new Rectangle( 10, 20, 100, 50 );
			Assert.IsFalse( s1.Contains( 120, 30 ) );

			Shape s2 = new Ellipse( 10, 20, 100, 50 );
			Assert.IsFalse( s2.Contains( 0,0 ) );
		}
	}
}
