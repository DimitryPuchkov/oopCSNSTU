using System;
using System.Collections.Generic;
using System.Text;
using static pz2.Functions;

namespace pz2.functions
{
   class Tanh : Function
   {
      public override bool IsConstant { get => a.IsConstant; }
      public override bool IsPolynom { get => false; }
      public Tanh(Expr a) : base(a) { }
      public override double Compute(IReadOnlyDictionary<string, double> variablesValues) => Math.Tanh(a.Compute(variablesValues));
      public override string ToString() => $"Tanh({a})";
      public override Expr Deriv() => (1.0 / Coth(a)) * a.Deriv();
   }
}
