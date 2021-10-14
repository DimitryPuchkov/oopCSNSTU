using System;
using System.Collections.Generic;
using System.Text;

namespace pz2
{
   class Constant:IExpr
   {
      private readonly double value; // значение константы
      public Constant(double _value) => value = _value;
      public bool IsConstant { get => true; }
      public bool IsPolynom { get => false; }
      public IEnumerable<string> Variables { get => new List<string> {}; }
      public double Compute(IReadOnlyDictionary<string, double> variablesValues) => value;
   }
}
