using System;
using System.Collections.Generic;
using System.Text;

namespace pz2
{
   class Variable: Expr
   {
      private string name; // имя переменной, например x
      public override bool IsConstant { get => false; }
      public override bool IsPolynom { get => true; }
      public Variable(string _name) => name = _name;
      public override double Compute(IReadOnlyDictionary<string, double> variablesValues) => variablesValues[name];
      public override IEnumerable<string> Variables { get => new List<string> { name }; }
      public override string ToString() => name;
   }
}
