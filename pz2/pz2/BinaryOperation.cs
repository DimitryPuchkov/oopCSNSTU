using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace pz2
{
   abstract class BinaryOperation : Expr
   {
      protected Expr a;
      protected Expr b;
      public BinaryOperation(Expr a, Expr b)
      {
         
         this.a = a;
         this.b = b;
      }
      //public override double Compute(IReadOnlyDictionary<string, double> variablesValues) => 0;
      public override IEnumerable<string> Variables  { get => a.Variables.Concat(b.Variables).Distinct().ToList(); }
      public override bool IsConstant { get => a.IsConstant && b.IsConstant; }
      public override bool IsPolynom { get; }
   }
}
