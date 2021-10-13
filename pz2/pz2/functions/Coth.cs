using System;
using System.Collections.Generic;
using System.Text;

namespace pz2.functions
{
   class Coth : Function
   {
      private IExpr a;
      public override bool IsConstant { get => false; }
      public override bool IsPolynom { get => false; }
      public Coth(IExpr _a) : base(_a) { }
      public override double Compute(IReadOnlyDictionary<string, double> variablesValues) => 1/Math.Tanh(a.Compute(variablesValues));
   }
}
