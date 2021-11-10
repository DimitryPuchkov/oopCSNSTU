﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using pz2.functions;
using System;
using System.Collections.Generic;
using System.Text;

namespace pz2.functions.Tests
{
	[TestClass()]
	public class CoshTests
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
			double expected = 1;

			// Act
			var s = new Cosh(a).Compute(dict);

			// Assert
			Assert.AreEqual(expected, s, 0.001);
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