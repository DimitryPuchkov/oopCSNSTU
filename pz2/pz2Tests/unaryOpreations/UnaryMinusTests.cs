using Microsoft.VisualStudio.TestTools.UnitTesting;
using pz2.operations;
using pz2.unaryOpreations;
using System;
using System.Collections.Generic;
using System.Text;

namespace pz2.unaryOpreations.Tests
{
	[TestClass()]
	public class UnaryMinusTests
	{
		[TestMethod()]
		public void ComputeTest()
		{ 
			// Arrange
			var a = new Variable("a");
			var dict = new Dictionary<string, double>
			{
				{ "a", 2 },
			};
			var obj = new UnaryMinus(a);
			double expected = -2;

			// Act
			var s = obj.Compute(dict);

			// Assert
			Assert.AreEqual(expected, s, 0.001, "Error expression");
		}

		[TestMethod()]
		public void DerivTest()
		{
			// Arrange
			var a = new Variable("a");
			string expected = "(-1)";
			var obj = new UnaryMinus(a);

			// Act

			var s = obj.Deriv().ToString();

			// Assert

			Assert.AreEqual(expected, s);
		}

		[TestMethod()]
		public void DerivTest1()
		{
			// Arrange
			var a = new Variable("a");
			string expected = "(-1)";
			var obj = new UnaryMinus(a);

			// Act

			var s = obj.Deriv("a").ToString();

			// Assert

			Assert.AreEqual(expected, s);
		}
	}
}