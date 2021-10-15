using System;
using System.Collections.Generic;
using System.Text;
using pz2.operations;
using pz2.unaryOpreations;
using pz2.functions;

namespace pz2
{
   abstract class Expr
   {
      public virtual bool IsConstant { get; }
      public virtual bool IsPolynom { get; }
      public virtual double Compute(IReadOnlyDictionary<string, double> variablesValues) => 0; // передаем словарь имя переменной - значение, получаем значение выражения
      public virtual IEnumerable<string> Variables { get; }
      public static Expr operator +(Expr a, Expr b) =>new  Sum(a, b);
      public static Expr operator -(Expr a, Expr b) =>new  Sub(a, b);
      public static Expr operator *(Expr a, Expr b) =>new  Mult(a, b);
      public static Expr operator /(Expr a, Expr b) =>new  Div(a, b);
      public static Expr operator -(Expr a) =>new  UnaryMinus(a);
   }
}
