using System;
using System.Collections.Generic;
using System.Text;

namespace pz2
{
   class Constant
   {
      private readonly double value;
      public Constant(double _value) => value = _value;
      public bool IsConstant { get => true; }
      public bool IsPolynom { get => false; }
      public IEnumerable<string> Variables { get => new List<string> { value.ToString() }; }
      public double Compute(IReadOnlyDictionary<string, double> variablesValues) => value;
   }
}
