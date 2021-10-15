using System;
using System.Collections.Generic;
using System.Text;

namespace pz2
{
   abstract class Function : Expr
   {
      protected Expr a;
      public override IEnumerable<string> Variables { get => a.Variables; }
      public override bool IsConstant { get; }
      public override bool IsPolynom { get; }
      public Function(Expr a) => this.a = a;
      //public override double Compute(IReadOnlyDictionary<string, double> variablesValues) => 0;
   }
}
