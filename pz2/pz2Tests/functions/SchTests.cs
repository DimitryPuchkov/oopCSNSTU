using Microsoft.VisualStudio.TestTools.UnitTesting;
using pz2.functions;
using System;
using System.Collections.Generic;
using System.Text;

namespace pz2.functions.Tests
{
	[TestClass()]
	public class SchTests
	{
		[TestMethod()]
		public void ComputeTest()
		{ 				
			    //Arrange
				var a = new Variable("a");
				var dict = new Dictionary<string, double>
				{
					{ "a", 4 }
				};
				double expected = 0.037;

				// Act
				var s = new Sch(a).Compute(dict);

				// Assert
				if (a != null)
					Assert.AreEqual(expected, s, 0.001);
				else
					Assert.Fail("Argument is uncorrect");
		}

		[TestMethod()]
		public void DerivTest()
		{
			//Arrange
			var a = new Variable("a");
			string expected = "(((-Coth(a)) / Sinh(a)) * 1)";

			// Act
			var s = new Sch(a).Deriv().ToString();

			// Assert
			Assert.AreEqual(expected, s);
		}

		[TestMethod()]
		public void DerivTest1()
		{
			//Arrange
			var a = new Variable("a");
			string expected = "(((-Coth(a)) / Sinh(a)) * 1)";

			// Act
			var s = new Sch(a).Deriv("a").ToString();

			// Assert
			Assert.AreEqual(expected, s);
		}
	}
}