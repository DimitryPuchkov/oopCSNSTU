using System;
using System.Collections.Generic;
using System.Text;

namespace pz2.functions
{
   class Tanh : Function
   {
      private IExpr a;
      public override bool IsConstant { get => a.IsConstant; }
      public override bool IsPolynom { get => false; }
      public Tanh(IExpr _a) { a = _a; }
      public override double Compute(IReadOnlyDictionary<string, double> variablesValues) => Math.Tanh(a.Compute(variablesValues));
      public override string ToString() => $"Tanh({a.ToString()})";
   }
}
