﻿using System;
using System.Collections.Generic;
using System.Text;
using pz2.Exceptions;
using pz2.operations;

namespace pz2.functions
{
   class Coth : Function
   {
      public override bool IsConstant { get => a.IsConstant; }
      public override bool IsPolynom { get => false; }
      public Coth(Expr a) : base(a) { }
      public override double Compute(IReadOnlyDictionary<string, double> variablesValues)
      {
         var r = a.Compute(variablesValues);
         if (r == 0)
            throw new YouMadmanException("You madman! Coth(0) is impossible! ");
         return  1 / Math.Tanh(a.Compute(variablesValues));
      }
      public override string ToString() => $"Coth({a})";
      public override Expr Deriv() => (-1 / new Coth(a)) * a.Deriv() ;
   }
}
