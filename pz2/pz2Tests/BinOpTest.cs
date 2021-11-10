using Microsoft.VisualStudio.TestTools.UnitTesting;
using pz2;
using pz2.operations;
using System.Collections.Generic;

namespace pz2Tests
{
   [TestClass]
   public class BinOpTest
   {
      [TestMethod]
      public void SumCompute()
      {
         // Arrange
         var a = new Variable("a");
         var b = new Variable("b");
         var dict = new Dictionary<string, double>
         {
            { "a", 2 },
            { "b", 1 }
         };
         double expected = 3;

         // Act

         var s = new Sum(a, b).Compute(dict);

         // Assert

         Assert.AreEqual(expected, s, 0.001, "Error in Sum");
      }

      [TestMethod]
      public void SubCompute()
      {
         // Arrange
         var a = new Variable("a");
         var b = new Variable("b");
         var dict = new Dictionary<string, double>
         {
            { "a", 2 },
            { "b", 1 }
         };
         double expected = 1;

         // Act

         var s = new Sub(a, b).Compute(dict);

         // Assert

         Assert.AreEqual(expected, s, 0.001, "Error in Sub");
      }

      [TestMethod]
      public void MultCompute()
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

         var s = new Mult(a, b).Compute(dict);

         // Assert

         Assert.AreEqual(expected, s, 0.001, "Error in Mult");
      }
      [TestMethod]
      public void DivCompute()
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

         Assert.AreEqual(expected, s, 0.001, "Error computing Div");
      }
      [TestMethod]
      public void DivException()
      {
         // Arrange
         var a = new Variable("a");
         var b = new Variable("b");
         var dict = new Dictionary<string, double>
         {
            { "a", 2 },
            { "b", 0 }
         };

         // Act and Assert
         Assert.ThrowsException<pz2.Exceptions.YouMadmanException>(() => (a / b).Compute(dict));
      }
   }
}
