using Microsoft.VisualStudio.TestTools.UnitTesting;
using pz2.functions;
using System;
using System.Collections.Generic;
using System.Text;

namespace pz2.functions.Tests
{
	[TestClass()]
	public class TanhTests
	{
		[TestMethod()]
		public void ComputeTest()
		{
			//Arrange
			var a = new Variable("a");
			var dict = new Dictionary<string, double>
			{
				{ "a", 0 }
			};
			double expected = 0;

			// Act
			var s = new Tanh(a).Compute(dict);

			// Assert
			Assert.AreEqual(expected, s, 0.001);
		}

		[TestMethod()]
		public void DerivTest()
		{
			//Arrange
			var a = new Variable("a");
			string expected = "((1 / (Cosh(a) * Cosh(a))) * 1)";

			// Act
			var s = new Tanh(a).Deriv().ToString();

			// Assert
			Assert.AreEqual(expected, s);
		}

		[TestMethod()]
		public void DerivTest1()
		{
			//Arrange
			var a = new Variable("a");
			string expected = "((1 / (Cosh(a) * Cosh(a))) * 1)";

			// Act
			var s = new Tanh(a).Deriv("a").ToString();

			// Assert
			Assert.AreEqual(expected, s);
		}
	}
}