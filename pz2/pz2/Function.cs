using System;
using System.Collections.Generic;
using System.Text;

namespace pz2
{
   abstract class Function : Expr
   {
      protected Expr a;
      public override IEnumerable<string> Variables  => a.Variables; 
	  public override bool IsConstant => a.IsConstant;
	  public override bool IsPolynom => false;
	  public Function(Expr a) => this.a = a;
   }
}
