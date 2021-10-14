using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace pz2
{
   abstract class BinaryOperation : IExpr
   {
      private IExpr a;
      private IExpr b;
      public BinaryOperation(IExpr _a, IExpr _b)
      {
         a = _a;
         b = _b;
      }
      public virtual double Compute(IReadOnlyDictionary<string, double> variablesValues) => 0;
      public IEnumerable<string> Variables  { get => a.Variables.Concat(b.Variables); }
      public virtual bool IsConstant { get; }
      public virtual bool IsPolynom { get; }
   }
}
