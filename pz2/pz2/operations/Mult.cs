﻿using System;
using System.Collections.Generic;
using System.Text;

namespace pz2.operations
{
   class Mult : BinaryOperation 
   {
      public override bool IsConstant { get => a.IsConstant && b.IsConstant; }
      public override bool IsPolynom { get => a.IsPolynom && b.IsPolynom; }
      public override double Compute(IReadOnlyDictionary<string, double> variablesValues) => a.Compute(variablesValues) * b.Compute(variablesValues);
      public Mult(Expr a, Expr b) : base(a, b) { }
      public override string ToString() => $"({a} * {b})";
      public override Expr Deriv() => a.Deriv() * b + b.Deriv() * a;
      public override Expr Deriv(string v) => a.Deriv(v) * b + b.Deriv(v) * a;
   }
}
