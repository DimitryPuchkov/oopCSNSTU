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
		public void UnaryMinusTest()
		{
			Assert.Fail();
		}

		[TestMethod()]
		public void ComputeTest()
		{ 
			// Arrange
			var a = new Variable("a");
			var dict = new Dictionary<string, double>
			{
				{ "a", 2 },
			};

			double expected = -2;

			// Act
			var s = new Mult(a, -1).Compute(dict);

			// Assert
			Assert.AreEqual(expected, s, 0.001, "Error expression");
		}

		[TestMethod()]
		public void DerivTest()
		{
			Assert.Fail();
		}

		[TestMethod()]
		public void DerivTest1()
		{
			Assert.Fail();
		}
	}
}