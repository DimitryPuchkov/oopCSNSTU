using Microsoft.VisualStudio.TestTools.UnitTesting;
using pz2;
using System;
using System.Collections.Generic;
using System.Text;

namespace pz2.Tests
{
   [TestClass()]
   public class VectorTests
   {

      [TestMethod()]
      public void VComputeTest()
      {
         // Arrange
         var a = new Variable("a");
         var b = new Variable("b");
         var dict = new Dictionary<string, double>
         {
            { "a", 2 },
            { "b", 1 }
         };
         Vector obj = new Vector(new List<Expr> { a, b });
         var expected = new List<double> { 2, 1 };

         // Act
         var s = obj.VCompute(dict);

         // Asser
         CollectionAssert.AreEqual(expected, s);
      }

      [TestMethod()]
      public void ScalarMultTest()
      {
         // Arrange
         var a = new Variable("a");
         var b = new Variable("b");
         Vector obj = new Vector(new List<Expr> { a, b });
         string expected = "((a * a) + (b * b))";

         // Act
         var s = (obj * obj).ToString();

         // Assert
         Assert.AreEqual(expected, s);
      }

      [TestMethod()]
      public void ScalarMultTestThrowExeption()
      {
         // Arrange
         var a = new Variable("a");
         var b = new Variable("b");
         Vector obj1 = new Vector(new List<Expr> { a, b });
         Vector obj2 = new Vector(new List<Expr> { a, b, b });

         // Act Assert
         Assert.ThrowsException<pz2.Exceptions.YouMadmanException>(() => obj1 * obj2);
      }

      [TestMethod()]
      public void MultVecExprTest()
      {
         // Arrange
         var a = new Variable("a");
         var b = new Variable("b");
         Vector obj = new Vector(new List<Expr> { a, b });
         string expected = "[(a * a), (b * a)]";

         // Act
         var s = (obj * a).ToString();
         var s1 = (a * obj).ToString();

         // Assert
         Assert.AreEqual(expected, s);
         Assert.AreEqual(expected, s1);
      }

      [TestMethod()]
      public void NormaTest()
      {
         // Arrange
         var a = new Variable("a");
         var b = new Variable("b");
         var dict = new Dictionary<string, double>
         {
            { "a", 3 },
            { "b", 4 }
         };
         Vector obj = new Vector(new List<Expr> { a, b });
         double expected = 5;

         // Act
         var s = obj.Norma(dict);

         // Asser
         Assert.AreEqual(expected, s, 0.001);
      }

      [TestMethod()]
      public void DerivTest()
      {
         // Arrange
         var a = new Variable("a");
         var b = new Variable("b");
         Vector obj = new Vector(new List<Expr> { a, b });
         string expected = "[1, 1]";

         // Act
         var s = obj.Deriv().ToString();

         // Assert
         Assert.AreEqual(expected, s);
      }

      [TestMethod()]
      public void VectorSumTest()
      {
         // Arrange
         var a = new Variable("a");
         var b = new Variable("b");
         Vector obj = new Vector(new List<Expr> { a, b });
         string expected = "[(a + (-a)), (b + (-b))]";

         // Act
         var s = (obj + (-obj)).ToString();

         // Assert
         Assert.AreEqual(expected, s);
      }

      [TestMethod()]
      public void VectorSumThrowExceptionTest()
      {
         // Arrange
         var a = new Variable("a");
         var b = new Variable("b");
         Vector obj1 = new Vector(new List<Expr> { a, b });
         Vector obj2 = new Vector(new List<Expr> { a, b, b });

         // Act Assert
         Assert.ThrowsException<pz2.Exceptions.YouMadmanException>(() => obj1 + obj2);
      }

      [TestMethod()]
      public void VectorSubTest()
      {
         // Arrange
         var a = new Variable("a");
         var b = new Variable("b");
         Vector obj = new Vector(new List<Expr> { a, b });
         string expected = "[(a - a), (b - b)]";

         // Act
         var s = (obj - obj).ToString();

         // Assert
         Assert.AreEqual(expected, s);
      }

      [TestMethod()]
      public void VectorSubThrowExceptionTest()
      {
         // Arrange
         var a = new Variable("a");
         var b = new Variable("b");
         Vector obj1 = new Vector(new List<Expr> { a, b });
         Vector obj2 = new Vector(new List<Expr> { a, b, b });

         // Act Assert
         Assert.ThrowsException<pz2.Exceptions.YouMadmanException>(() => obj1 - obj2);
      }
   }
}