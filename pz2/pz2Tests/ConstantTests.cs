using Microsoft.VisualStudio.TestTools.UnitTesting;
using pz2;
using System;
using System.Collections.Generic;
using System.Text;
using static pz2.Functions;

namespace pz2.Tests
{
   [TestClass()]
   public class ConstantTests
   {
      [TestMethod()]
      public void IsConstantTest1()
      {
         // Arrange
         var a = new Variable("a");
         var b = new Variable("b");
         var c = new Constant(5.0);
         var obj = -c + (b / a);

         // Act
         bool s = obj.IsConstant;

         // Assert
         Assert.IsFalse(s);
      }
      [TestMethod()]
      public void IsConstantTest2()
      {
         // Arrange
         var c = new Constant(5.0);
         var obj = Csch(c);

         // Act
         bool s = obj.IsConstant;

         // Assert
         Assert.IsTrue(s);
      }

      [TestMethod()]
      public void DerivTest1()
      {
         // Arrange
         var obj = new Constant(5.0);
         string expected = "0";
         // Act
         var s = obj.Deriv().ToString();

         // Assert
         Assert.AreEqual(expected, s);
      }

      [TestMethod()]
      public void DerivTest2()
      {
         // Arrange
         var obj = new Constant(5.0);
         string expected = "0";
         // Act
         var s = obj.Deriv("a").ToString();

         // Assert
         Assert.AreEqual(expected, s);
      }
   }
}