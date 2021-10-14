﻿using System;
using System.Collections.Generic;
using System.Text;

namespace pz2.operations
{
   class Div : BinaryOperation 
   {
      private IExpr a;
      private IExpr b;
      public Div(IExpr _a, IExpr _b) : base(_a, _b) { }
      public override double Compute(IReadOnlyDictionary<string, double> variablesValues) => a.Compute(variablesValues) / b.Compute(variablesValues);
      public override bool IsConstant { get => a.IsConstant && b.IsConstant; }
      public override bool IsPolynom { get => a.IsPolynom && b.IsPolynom; } //??????????????
      public override string ToString() => $"({a.ToString()} / {b.ToString()})";
   }
}
