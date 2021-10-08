using System;
using System.Collections.Generic;
using System.Text;

namespace pz2
{
   interface IExpr
   {
      double Compute(IReadOnlyDictionary<string, double> variablesValues);
      IEnumerable<string> Variables { get; }
      bool IsConstant { get; }
      bool IsPolynom { get; }

   }
}
