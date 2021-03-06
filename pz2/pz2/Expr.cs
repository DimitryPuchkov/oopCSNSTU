using System;
using System.Collections.Generic;
using System.Text;
using pz2.operations;
using pz2.unaryOpreations;
using pz2.functions;
using System.Linq;

namespace pz2
{
   public abstract class Expr
   {
      public abstract bool IsConstant { get; }
      public abstract bool IsPolynom { get; }
      abstract public double Compute(IReadOnlyDictionary<string, double> variablesValues); // передаем словарь имя переменной - значение, получаем значение выражения
      public virtual IEnumerable<string> Variables { get; }
      abstract public Expr Deriv();
      abstract public Expr Deriv(string v);
      public Vector Grad()
      {
         List<Expr> val = new List<Expr>();
         foreach( var i in Variables)
            val.Add(Deriv(i));
         return new Vector(val);
      }
      public double Integral(Variable v, Expr l, Expr u, int n, IReadOnlyDictionary<string, double> variableValues)
      {
         var a = l.Compute(variableValues);
         var b = u.Compute(variableValues);
         double h = (b - a) / n;
         double sum = 0;
         var dict = new Dictionary<string, double> { [v.ToString()] = a + 0.5 * h };
         dict = dict.Concat(variableValues.Where(x => !dict.ContainsKey(x.Key))).ToDictionary(x => x.Key, x => x.Value);
            for (int i = 0; i < n; i++)
            {
               sum += Compute(dict) * h;
               dict[v.ToString()] += h;
            }
            return sum;
         
      }
      public static Expr operator +(Expr a, Expr b) =>new  Sum(a, b);
      public static Expr operator -(Expr a, Expr b) =>new  Sub(a, b);
      public static Expr operator *(Expr a, Expr b) =>new  Mult(a, b);
      public static Expr operator /(Expr a, Expr b) =>new  Div(a, b);
      public static Expr operator -(Expr a) =>new  UnaryMinus(a);
      public static implicit operator Expr(double a) => new Constant(a);
   }

   public static class Functions
   {
      public static Expr Sinh(Expr a) => new Sinh(a);
      public static Expr Cosh(Expr a) => new Cosh(a);
      public static Expr Tanh(Expr a) => new Tanh(a);
      public static Expr Coth(Expr a) => new Coth(a);
      public static Expr Sch(Expr a) => new Sch(a);
      public static Expr Csch(Expr a) => new Csch(a);
   }
}
