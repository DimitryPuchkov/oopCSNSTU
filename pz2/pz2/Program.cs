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
         var a = new Variable("a");
         var b = new Variable("b");
         var dict = new Dictionary<string, double>
         {
            { "a", 0 },
            { "b", 1 }
         };
         Vector vec1 = new Vector(new List<Expr>() { 1, 2, 3 });
         Vector vec2 = new Vector(new List<Expr>() { 1, 2, 3 });
         Vector vec3 = vec1 + vec2;
         Console.WriteLine(vec3.VCompute(dict));
         //Expr ex = Coth(a)*Sinh(a); // вызывает знак вопроса что то странное
         //Expr ex1 = Csch(a).Integral(a, 0, 1, 300, dict);
         //Console.WriteLine($"{ex.Compute(dict):f4}");
         //Console.WriteLine($"{ex1.Compute(dict):f4}");
      }
   }
}
