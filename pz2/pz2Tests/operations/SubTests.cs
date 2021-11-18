using Microsoft.VisualStudio.TestTools.UnitTesting;
using pz2.operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace pz2.operations.Tests
{
	[TestClass()]
	public class SubTests
	{
		[TestMethod()]
		public void ComputeTest()
		{
			// Arrange
			var a = new Variable("a");
			var b = new Variable("b");
			var dict = new Dictionary<string, double>
			{
				{ "a", 2 },
				{ "b", 1 }
			};
			var obj = new Sub(a, b);
			double expected = 1;

			// Act
			var s = obj.Compute(dict);

			// Assert
			Assert.AreEqual(expected, s, 0.001);
		}

		[TestMethod()]
		public void ToStringTest()
		{
			//Arrange
			var a = new Variable("a");
			var b = new Variable("b");
			string expected = "(a - b)";
			var obj = new Sub(a, b);

			// Act
			var s = obj.ToString();

			// Assert
			Assert.AreEqual(expected, s);
		}

		[TestMethod()]
		public void DerivTest()
		{
			// Arrange
			var a = new Variable("a");
			var b = new Variable("b");
			string expected = "(1 - 1)";
			var obj = new Sub(a, b);

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
			var b = new Variable("b");
			string expected = "(1 - 0)";
			var obj = new Sub(a, b);

			// Act

			var s = obj.Deriv("a").ToString();

			// Assert

			Assert.AreEqual(expected, s);
		}
	}
}