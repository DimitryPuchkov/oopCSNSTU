using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pz2
{
   class Vector 
   {
      private readonly List<double> value; // значение константы
      public Vector(List<double> val) => value = val;
      public  bool IsConstant { get => true; }
      public  bool IsPolynom { get => true; }
      public  IEnumerable<string> Variables => Enumerable.Empty<string>();
      public  List<double> VCompute(IReadOnlyDictionary<string, double> variablesValues) => value;
      public override string ToString() => value.ToString();
      public  Expr Deriv() => new Constant(0);
   }
}
