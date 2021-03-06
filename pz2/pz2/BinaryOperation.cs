using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using pz2.Exceptions;

namespace pz2
{
   public abstract class BinaryOperation : Expr
   {
      protected Expr a;
      protected Expr b;
      public BinaryOperation(Expr a, Expr b)
      {
         if (a==null || b == null)
                throw new YouMadmanException("The expressions cannot be null!");
         this.a = a;
         this.b = b;
      }
	  public override IEnumerable<string> Variables => a.Variables.Concat(b.Variables).Distinct().ToList();
      public override bool IsPolynom => a.IsPolynom && b.IsPolynom;
      public override bool IsConstant => a.IsConstant && b.IsConstant;
   }
}
