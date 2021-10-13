using System;
using System.Collections.Generic;
using System.Text;

namespace pz2
{
   abstract class Function : IExpr
   {
      private IExpr a;
      public virtual IEnumerable<string> Variables { get => a.Variables; }
      public virtual bool IsConstant { get; }
      public virtual bool IsPolynom { get; }
      public Function(IExpr _a) => a = _a;
      public virtual double Compute(IReadOnlyDictionary<string, double> variablesValues) => 0;
   }
}
