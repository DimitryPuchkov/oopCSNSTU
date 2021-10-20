using System;
using System.Collections.Generic;
using pz2.operations;
using pz2.functions;
using static pz2.Functions;
namespace pz2
{
   class Program
   {
      static void Main(string[] args)
      {
         //Console.WriteLine("Hello World!");
         //var c2 = new Constant(2);
         //var c3 = new Constant(3);
         //var e = c3 * new Sinh(c2) + c2 * new Cosh(c3);
         var c4 = new Constant(4);
         var c5 = new Constant(5);
         var a = new Variable("a");
         var b = new Variable("b");
         var e1 = Sinh(a * b);
         var e = a + b + c5;
         var dict = new Dictionary<string, double>();
         dict.Add("a", 3);
         dict.Add("b", 2);
         Expr ex = 5.0 * Sinh(b);
         Console.WriteLine(e);
      }
   }
}
