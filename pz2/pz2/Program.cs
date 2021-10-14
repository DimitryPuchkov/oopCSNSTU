using System;
using System.Collections.Generic;
using pz2.functions;
namespace pz2
{
   class Program
   {
      static void Main(string[] args)
      {
         //Console.WriteLine("Hello World!");
         var zero = new Constant(0);
         var ctanh = new Coth(zero);
         var dict =  new Dictionary<string, double>{ };
         ctanh.Compute(dict);
      }
   }
}
