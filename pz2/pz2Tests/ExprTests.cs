using Microsoft.VisualStudio.TestTools.UnitTesting;
using pz2;
using static pz2.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pz2.Tests
{
   [TestClass()]
   public class ExprTests
   {

      [TestMethod()]
      public void GradTest()
      {
         // Arrange
         var a = new Variable("a");
         var b = new Variable("b");
         var dict = new Dictionary<string, double>
         {
            { "a", 2 },
            { "b", 1 }
         };
         var obj = a + b;
         //Vector obj = new Vector(new List<Expr> { a, b });
         string expected = "[(1 + 0), (0 + 1)]";

         // Act
         var s = obj.Grad().ToString();

         // Asser
         Assert.AreEqual(expected, s);
      }

      [TestMethod()]
      public void IntegralTest()
      {
         // Arrange
         var a = new Variable("a");
         var dict = new Dictionary<string, double>
         {
            { "a", 2 },
         };
         var obj = a;
         //Vector obj = new Vector(new List<Expr> { a, b });
         double expected = 0.5;

         // Act
         var s = obj.Integral(a, 0, 1, 1000, dict);

         // Asser
         Assert.AreEqual(expected, s, 0.001);
      }

      [TestMethod()]
      public void VariblesTest()
      {
         // Arrange
         var a = new Variable("a");
         var b = new Variable("b");
         var c = new Constant(4);
         var obj = (Sinh(a) + (-a))*b + c;
         IEnumerable<string> expected = new List<string> {"a", "b"};

         // Act
         var s = obj.Variables;

         // Assert
         Assert.IsTrue(expected.SequenceEqual(s));

      }
   }
}