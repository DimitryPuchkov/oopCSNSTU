using System;
using System.Collections.Generic;
using System.Text;
using pz2.Exceptions;

namespace pz2.functions
{
   class Coth : Function
   {
      private IExpr a;
      public override bool IsConstant { get => a.IsConstant; }
      public override bool IsPolynom { get => false; }
      public Coth(IExpr _a) { a = _a; }
      public override double Compute(IReadOnlyDictionary<string, double> variablesValues)
      {
         var r = a.Compute(variablesValues);
         if (r == 0)
            throw new YouMadman("You madman!");
         return  1 / Math.Tanh(a.Compute(variablesValues));
      }
      public override string ToString() => $"Coth({a.ToString()})";
   }
}
