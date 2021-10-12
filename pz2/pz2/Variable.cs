using System;
using System.Collections.Generic;
using System.Text;

namespace pz2
{
   class Variable: IExpr
   {
      private string name;
      public bool IsConstant { get => false; }
      public bool IsPolynom { get => true; }
      public Variable(string _name) => name = _name;
      public double Compute(IReadOnlyDictionary<string, double> variablesValues) => variablesValues[name];
      public IEnumerable<string> Variables { get => new List<string> { name }; }
   }
}
