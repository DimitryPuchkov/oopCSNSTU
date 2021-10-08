using System;
using System.Collections.Generic;
using System.Text;

namespace pz2
{
   abstract class BinaryOperation : IExpr
   {
      public double Compute(IReadOnlyDictionary<string, double> variablesValues)
      {
         return 0;
      }
      public IEnumerable<string> Variables { get; }
      public bool IsConstant { get; }
      public bool IsPolynom { get; }
   }
}
