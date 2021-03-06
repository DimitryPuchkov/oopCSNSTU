using System;
using System.Collections.Generic;
using System.Text;

namespace pz2
{
   public class Variable : Expr
   {
      private string name; // имя переменной, например x
      public override bool IsConstant => false;
      public override bool IsPolynom => true;
      public Variable(string n) => name = n;
      public override double Compute(IReadOnlyDictionary<string, double> variablesValues) => variablesValues[name];
      public override IEnumerable<string> Variables => new List<string> { name };
      public override string ToString() => name;
      public override Expr Deriv() => new Constant(1);
      public override Expr Deriv(string v)
      {
         if (v == name)
            return new Constant(1);
         else
            return new Constant(0);
      }
   }
}
