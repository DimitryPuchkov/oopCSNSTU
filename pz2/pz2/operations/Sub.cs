﻿using System;
using System.Collections.Generic;
using System.Text;

namespace pz2.operations
{
   class Sub : BinaryOperation
   {
	  public override bool IsPolynom => a.IsPolynom && b.IsPolynom;
	  public Sub(Expr a, Expr b) : base(a, b) { }
      public override double Compute(IReadOnlyDictionary<string, double> variablesValues) => a.Compute(variablesValues) - b.Compute(variablesValues);
      public override string ToString() => $"({a} - {b})";
      public override Expr Deriv() => a.Deriv() - b.Deriv();
   }
}
