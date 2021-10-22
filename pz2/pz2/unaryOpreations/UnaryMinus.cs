using System;
using System.Collections.Generic;
using System.Text;
using pz2.operations;

namespace pz2.unaryOpreations
{
   class UnaryMinus:UnaryOperation
   {
      public UnaryMinus(Expr a) : base(a) { }
      public override double Compute(IReadOnlyDictionary<string, double> variablesValues) => new Mult(new Constant(-1), a).Compute(variablesValues);
      public override string ToString() => $"(-{a})";
      public override Expr Deriv() => -a.Deriv();
      public override Expr Deriv(string v) => -a.Deriv(v);

   }
}
