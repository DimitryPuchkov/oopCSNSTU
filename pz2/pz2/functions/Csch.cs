using System;
using System.Collections.Generic;
using System.Text;
using pz2.Exceptions;
using static pz2.Functions;

namespace pz2.functions
{
   public class Csch : Function
   {
      public Csch(Expr a) : base(a) { }
      public override double Compute(IReadOnlyDictionary<string, double> variablesValues)
      {
         var r = Math.Cosh(a.Compute(variablesValues));
         return 1 / r;
      }
      public override string ToString() => $"Csch({a})";
      public override Expr Deriv() => (-Tanh(a)/Cosh(a))* a.Deriv();
      public override Expr Deriv(string v) => (-Tanh(a)/Cosh(a))* a.Deriv(v);
   }
}
