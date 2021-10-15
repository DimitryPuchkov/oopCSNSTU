﻿using System;
using System.Collections.Generic;
using System.Text;

namespace pz2.operations
{
   class Div : BinaryOperation 
   {
      public override bool IsConstant { get => a.IsConstant && b.IsConstant; }
      public override bool IsPolynom { get => a.IsPolynom && b.IsPolynom; } //??????????????
      public Div(Expr a, Expr b) : base(a, b) { }
      public override double Compute(IReadOnlyDictionary<string, double> variablesValues) => a.Compute(variablesValues) / b.Compute(variablesValues);

      public override string ToString() => $"({a} / {b})";
   }
}
