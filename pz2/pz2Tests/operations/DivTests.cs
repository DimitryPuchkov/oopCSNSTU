using Microsoft.VisualStudio.TestTools.UnitTesting;
using pz2.operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace pz2.operations.Tests
{
	[TestClass()]
	public class DivTests
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
			var obj = new Div(a, b);
			double expected = 2;

			// Act
			var s = obj.Compute(dict);

			// Assert
				Assert.AreEqual(expected, s, 0.001);
		}

		[TestMethod()]
		public void ComputeTestThrowException()
		{
			// Arrange
			var a = new Variable("a");
			var b = new Variable("b");
			var dict = new Dictionary<string, double>
			{
				{ "a", 2 },
				{ "b", 0 }
			};
			var obj = new Div(a, b);

			//Act Assert
			Assert.ThrowsException<pz2.Exceptions.YouMadmanException>(() => obj.Compute(dict));
		}

		[TestMethod()]
		public void ToStringTest()
		{
			//Arrange
			var a = new Variable("a");
			var b = new Variable("b");
			string expected = "(a / b)";
			var obj = new Div(a, b);

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
			string expected = "(((1 * b) - (1 * a)) / (b * b))";
			var obj = new Div(a, b);

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
			string expected = "(((1 * b) - (0 * a)) / (b * b))";
			var obj = new Div(a, b);

			// Act
			var s = obj.Deriv("a").ToString();

			// Assert
			Assert.AreEqual(expected, s);
		}
	}
}