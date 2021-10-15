using System;
using System.Collections.Generic;
using System.Text;

namespace pz2
{
   class Constant:Expr
   {
      private readonly double value; // значение константы
      public Constant(double _value) => value = _value;
      public override bool IsConstant { get => true; }
      public override bool IsPolynom { get => false; }
      public override IEnumerable<string> Variables { get => new List<string> {}; }
      public override double Compute(IReadOnlyDictionary<string, double> variablesValues) => value;
      public override string ToString() => value.ToString();
   }
}
