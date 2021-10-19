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
      abstract public double Compute(IReadOnlyDictionary<string, double> variablesValues); // передаем словарь имя переменной - значение, получаем значение выражения
      public virtual IEnumerable<string> Variables { get; }
      abstract public Expr Deriv();
      public static Expr operator +(Expr a, Expr b) =>new  Sum(a, b);
      public static Expr operator -(Expr a, Expr b) =>new  Sub(a, b);
      public static Expr operator *(Expr a, Expr b) =>new  Mult(a, b);
      public static Expr operator /(Expr a, Expr b) =>new  Div(a, b);
      public static Expr operator -(Expr a) =>new  UnaryMinus(a);
      public static implicit operator Expr(double a) => new Constant(a);
   }

   static class Functions
   {
      public static Expr Sinh(Expr a) => new Sinh(a);
      public static Expr Cosh(Expr a) => new Cosh(a);
      public static Expr Tanh(Expr a) => new Tanh(a);
      public static Expr Coth(Expr a) => new Coth(a);
      public static Expr Sch(Expr a) => new Sch(a);
      public static Expr Csch(Expr a) => new Csch(a);
   }
}
