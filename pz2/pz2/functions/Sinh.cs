using System;
using System.Collections.Generic;
using System.Text;
using static pz2.Functions;

namespace pz2.functions
{
   public class Sinh : Function
   {
      public Sinh(Expr a): base(a) {}
      public override double Compute(IReadOnlyDictionary<string, double> variablesValues) => Math.Sinh(a.Compute(variablesValues));
      public override string ToString() => $"Sinh({a})";
      public override Expr Deriv() =>  Cosh(a) * a.Deriv();
      public override Expr Deriv(string v) =>  Cosh(a) * a.Deriv(v);
   }
}

