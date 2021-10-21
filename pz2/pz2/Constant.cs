using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pz2
{
   class Constant:Expr
   {
      private readonly double value; // значение константы
      public Constant(double val) => value = val;
      public override bool IsConstant { get => true; }
      public override bool IsPolynom { get => false; }
      public override IEnumerable<string> Variables => Enumerable.Empty<string>(); 
      public override double Compute(IReadOnlyDictionary<string, double> variablesValues) => value;
      public override string ToString() => value.ToString();
      public override Expr Deriv() => new Constant(0);
   }
}
