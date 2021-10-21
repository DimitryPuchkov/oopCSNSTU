using System;
using System.Collections.Generic;
using System.Text;

namespace pz2
{
   abstract class Function : Expr
   {
      protected Expr a;
      public override IEnumerable<string> Variables { get => a.Variables; }
      public override bool IsConstant { get => a.IsConstant; }
      public override bool IsPolynom { get => false; }
      public Function(Expr a) => this.a = a;
   }
}
