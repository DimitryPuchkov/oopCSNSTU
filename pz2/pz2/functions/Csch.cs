using System;
using System.Collections.Generic;
using System.Text;
using pz2.Exceptions;

namespace pz2.functions
{
   class Csch : Function
   {
      public override bool IsConstant { get => a.IsConstant; }
      public override bool IsPolynom { get => false; }
      public Csch(Expr a) : base(a) { }
      public override double Compute(IReadOnlyDictionary<string, double> variablesValues)
      {
         var r = Math.Cosh(a.Compute(variablesValues));
         if (r == 0)
            throw new YouMadmanException("You are madman! Csch(0) is impossible");
         return 1 / r;
      }
      public override string ToString() => $"Csch({a})";
   }
}
