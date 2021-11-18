using Microsoft.VisualStudio.TestTools.UnitTesting;
using pz2;
using System;
using System.Collections.Generic;
using System.Text;
using static pz2.Functions;
using pz2.operations;

namespace pz2.Tests
{
   [TestClass()]
   public class VariableTests
   {

      [TestMethod()]
      public void IsPolinomTest1()
      {
         // Arrange
         var a = new Variable("a");
         var b = new Variable("b");
         var c = new Constant(5.0);
         var obj = -a + (b / c) + c;

         // Act
         bool s = obj.IsPolynom;

         // Assert
         Assert.IsTrue(s);
      }

      [TestMethod()]
      public void IsPolinomTest2()
      {
         // Arrange
         var a = new Variable("a");
         var obj = a -Sch(a);

         // Act
         bool s = obj.IsPolynom;

         // Assert
         Assert.IsFalse(s);
      }
      [TestMethod()]
      public void IsPolinomTest3()
      {
         // Arrange
         var a = new Variable("a");
         var e = Sinh(a);
         var obj = a * e;

         // Act
         bool s = obj.IsPolynom;

         // Assert
         Assert.IsFalse(s);
      }

   }
}