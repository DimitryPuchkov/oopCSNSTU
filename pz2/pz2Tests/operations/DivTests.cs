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

			double expected = 2;

			// Act
			var s = new Div(a, b).Compute(dict);

			// Assert
			if(b != null)
				Assert.AreEqual(expected, s, 0.001);
			else 
				Assert.Fail("Division by zero");
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

			//Act Assert
			Assert.ThrowsException<pz2.Exceptions.YouMadmanException>(() => (a/b).Compute(dict));
		}

		[TestMethod()]
		public void DerivTest()
		{
			// Arrange
			var a = new Variable("a");
			var b = new Variable("b");
			string expected = "(((1 * b) - (1 * a)) / (b * b))";

			// Act
			var s = new Div(a, b).Deriv().ToString();

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

			// Act
			var s = new Div(a, b).Deriv("a").ToString();

			// Assert
			Assert.AreEqual(expected, s);
		}
	}
}