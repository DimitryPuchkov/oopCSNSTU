﻿using System;
using System.Collections.Generic;
using System.Text;

namespace pz2.functions
{
   class Cosh : Function
   {
      public override bool IsConstant { get => a.IsConstant; }
      public override bool IsPolynom { get => false; }
      public Cosh(Expr a) : base(a) { }
      public override double Compute(IReadOnlyDictionary<string, double> variablesValues) => Math.Cosh(a.Compute(variablesValues));
      public override string ToString() => $"Cosh({a})";
   }
}
