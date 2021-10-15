using System;
using System.Collections.Generic;
using System.Text;
using pz2.Exceptions;

namespace pz2.functions
{
   class Sch: Function
   {
      public override bool IsConstant { get => a.IsConstant; }
      public override bool IsPolynom { get => false; }
      public Sch(Expr a) : base(a) { }
      public override double Compute(IReadOnlyDictionary<string, double> variablesValues)
      {
         var r = Math.Sinh(a.Compute(variablesValues));
         if (r == 0)
            throw new YouMadmanException("You are madman! Sch(0) is impossible");
         return 1 / r;
      }
      public override string ToString() => $"Sch({a})";
   }
}
