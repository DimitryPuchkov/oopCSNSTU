using System;
using System.Collections.Generic;
using System.Text;
using static pz2.Functions;

namespace pz2.functions
{
   public class Cosh : Function
   {
      public Cosh(Expr a) : base(a) { }
      public override double Compute(IReadOnlyDictionary<string, double> variablesValues) => Math.Cosh(a.Compute(variablesValues));
      public override string ToString() => $"Cosh({a})";
      public override Expr Deriv() =>  Sinh(a) * a.Deriv();
      public override Expr Deriv(string v) =>  Sinh(a) * a.Deriv(v);
   }
}
