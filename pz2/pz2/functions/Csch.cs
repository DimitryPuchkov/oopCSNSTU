using System;
using System.Collections.Generic;
using System.Text;
using pz2.Exceptions;
using static pz2.Functions;

namespace pz2.functions
{
   class Csch : Function
   {
      public Csch(Expr a) : base(a) { }
      public override double Compute(IReadOnlyDictionary<string, double> variablesValues)
      {
         var r = Math.Cosh(a.Compute(variablesValues));
         if (r == 0)
            throw new YouMadmanException("You are madman! Csch(0) is impossible");
         return 1 / r;
      }
      public override string ToString() => $"Csch({a})";
      public override Expr Deriv() => (-Tanh(a)/Cosh(a))* a.Deriv();
   }
}
