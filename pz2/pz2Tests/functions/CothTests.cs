using Microsoft.VisualStudio.TestTools.UnitTesting;
using pz2.functions;
using System;
using System.Collections.Generic;
using System.Text;

namespace pz2.functions.Tests
{
	[TestClass()]
	public class CothTests
	{
		[TestMethod()]
		public void ComputeTest()
		{
			//Arrange
			var a = new Variable("a");
			var dict = new Dictionary<string, double>
			{
				{ "a", 2 }
			};
			double expected = 1.037;
			var obj = new Coth(a);

			// Act
			var s = obj.Compute(dict);

			// Assert
				Assert.AreEqual(expected, s, 0.001);
		}

		[TestMethod()]
		public void ComputeTestThrowException()
		{
			//Arrange
			var a = new Variable("a");
			var dict = new Dictionary<string, double>
				{
					{ "a", 0 }
				};
			var obj = new Coth(a);

			//Act Assert
			Assert.ThrowsException<pz2.Exceptions.YouMadmanException>(() => obj.Compute(dict));
		}

		[TestMethod()]
		public void ToStringTest()
		{
			//Arrange
			var a = new Variable("a");
			string expected = "Coth(a)";
			var obj = new Coth(a);

			// Act
			var s = obj.ToString();

			// Assert
			Assert.AreEqual(expected, s);
		}

		[TestMethod()]
		public void DerivTest()
		{
			//Arrange
			var a = new Variable("a");
			string expected = "((-1 / (Sinh(a) * Sinh(a))) * 1)";
			var obj = new Coth(a);

			// Act
			var s = obj.Deriv().ToString();

			// Assert
			Assert.AreEqual(expected, s);
		}

		[TestMethod()]
		public void DerivTest1()
		{
			//Arrange
			var a = new Variable("a");
			string expected = "((-1 / (Sinh(a) * Sinh(a))) * 1)";
			var obj = new Coth(a);

			// Act
			var s = obj.Deriv("a").ToString();

			// Assert
			Assert.AreEqual(expected, s);
		}
	}
}