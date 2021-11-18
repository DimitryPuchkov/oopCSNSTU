using System;
using System.Collections.Generic;
using System.Text;

namespace pz2.operations
{
   public class Sub : BinaryOperation
   {
	  public Sub(Expr a, Expr b) : base(a, b) { }
      public override double Compute(IReadOnlyDictionary<string, double> variablesValues) => a.Compute(variablesValues) - b.Compute(variablesValues);
      public override string ToString() => $"({a} - {b})";
      public override Expr Deriv() => a.Deriv() - b.Deriv();
      public override Expr Deriv(string v) => a.Deriv(v) - b.Deriv(v);
   }
}
