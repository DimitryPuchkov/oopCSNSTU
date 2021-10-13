using System;
using System.Collections.Generic;
using System.Text;

namespace pz2.functions
{
   class Tanh : Function
   {
      private IExpr a;
      public override bool IsConstant { get => false; }
      public override bool IsPolynom { get => false; }
      public Tanh(IExpr _a) : base(_a) { }
      public override double Compute(IReadOnlyDictionary<string, double> variablesValues) => Math.Tanh(a.Compute(variablesValues));
   }
}
