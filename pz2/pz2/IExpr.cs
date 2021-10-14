using System;
using System.Collections.Generic;
using System.Text;

namespace pz2
{
   interface IExpr
   {
      bool IsConstant { get; }
      bool IsPolynom { get; }
      double Compute(IReadOnlyDictionary<string, double> variablesValues);// передаем словарь имя переменной - значение, получаем значение выражения
      IEnumerable<string> Variables { get; }
   }
}
