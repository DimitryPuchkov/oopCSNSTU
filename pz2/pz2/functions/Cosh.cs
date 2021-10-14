using System;
using System.Collections.Generic;
using System.Text;

namespace pz2.functions
{
   class Cosh : Function
   {
      private IExpr a;
      public override bool IsConstant { get => a.IsConstant; }
      public override bool IsPolynom { get => false; }
      public Cosh(IExpr _a) { a = _a; }
      public override double Compute(IReadOnlyDictionary<string, double> variablesValues) => Math.Cosh(a.Compute(variablesValues));
      public override string ToString() => $"Cosh({a.ToString()})";
   }
}
