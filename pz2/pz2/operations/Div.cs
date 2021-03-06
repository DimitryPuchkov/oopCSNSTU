using System;
using System.Collections.Generic;
using System.Text;
using pz2.Exceptions;

namespace pz2.operations
{
   public class Div : BinaryOperation 
   {
      public override bool IsPolynom => a.IsPolynom && b.IsConstant;
      public Div(Expr a, Expr b) : base(a, b) { }
      public override double Compute(IReadOnlyDictionary<string, double> variablesValues)
      {
         if (b.Compute(variablesValues) == 0)
            throw new YouMadmanException("You are madman! Division by 0!");
         return a.Compute(variablesValues) / b.Compute(variablesValues);
      }

      public override string ToString() => $"({a} / {b})";
      public override Expr Deriv() => (a.Deriv()*b - b.Deriv() * a)/(b*b);
      public override Expr Deriv(string v) => (a.Deriv(v)*b - b.Deriv(v) * a)/(b*b);
   }
}
