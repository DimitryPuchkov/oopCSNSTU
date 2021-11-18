using System;
using System.Collections.Generic;
using System.Text;

namespace pz2
{
   public abstract class UnaryOperation : Expr
   {
      protected Expr a;
      public override IEnumerable<string> Variables => a.Variables;
      public override bool IsConstant => a.IsConstant;
      public override bool IsPolynom => a.IsPolynom;
      public UnaryOperation(Expr a) => this.a = a;

   }
}
