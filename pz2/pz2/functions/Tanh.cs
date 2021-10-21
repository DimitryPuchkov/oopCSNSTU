using System;
using System.Collections.Generic;
using System.Text;
using static pz2.Functions;

namespace pz2.functions
{
   class Tanh : Function
   {
      public Tanh(Expr a) : base(a) { }
      public override double Compute(IReadOnlyDictionary<string, double> variablesValues) => Math.Tanh(a.Compute(variablesValues));
      public override string ToString() => $"Tanh({a})";
      public override Expr Deriv() => (1 / (Cosh(a)*Cosh(a))) * a.Deriv();
      public override Expr Deriv(string v) => (1 / (Cosh(a)*Cosh(a))) * a.Deriv(v);
   }
}
