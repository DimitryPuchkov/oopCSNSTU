using System;
using System.Collections.Generic;
using System.Text;
using pz2.Exceptions;
using static pz2.Functions;

namespace pz2.functions
{
   class Sch: Function
   {
      public Sch(Expr a) : base(a) { }
      
      public override double Compute(IReadOnlyDictionary<string, double> variablesValues)
      {
         var r = Math.Sinh(a.Compute(variablesValues));
         if (r == 0)
            throw new YouMadmanException("You are madman! Sch(0) is impossible");
         return 1 / r;
      }
      public override string ToString() => $"Sch({a})";
        public override Expr Deriv() => (-Coth(a)/Sinh(a))*a.Deriv();
        public override Expr Deriv(string v) => (-Coth(a)/Sinh(a))*a.Deriv(v);
   }
}
