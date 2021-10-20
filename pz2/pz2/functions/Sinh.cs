using System;
using System.Collections.Generic;
using System.Text;
using static pz2.Functions;

namespace pz2.functions
{
   class Sinh : Function
   {
      public override bool IsConstant { get=>a.IsConstant; }
      public override bool IsPolynom { get=>false; }
      public Sinh(Expr a): base(a) {}
      public override double Compute(IReadOnlyDictionary<string, double> variablesValues) => Math.Sinh(a.Compute(variablesValues));
      public override string ToString() => $"Sinh({a})";
      public override Expr Deriv() =>  Cosh(a) * a.Deriv();
   }
}

