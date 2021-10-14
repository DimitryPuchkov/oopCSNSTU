using System;
using System.Collections.Generic;
using System.Text;

namespace pz2.operations
{
   class Mult : BinaryOperation 
   {
      private IExpr a;
      private IExpr b;
      public Mult(IExpr _a, IExpr _b) : base(_a, _b) { }
      public override double Compute(IReadOnlyDictionary<string, double> variablesValues) => a.Compute(variablesValues) * b.Compute(variablesValues);
      public override bool IsConstant { get => a.IsConstant && b.IsConstant; }
      public override bool IsPolynom { get => a.IsPolynom && b.IsPolynom; } //??????????????
      public override string ToString() => $"({a.ToString()} * {b.ToString()})";
   }
}
