using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pz2.Exceptions;

namespace pz2
{
   class Vector 
   {
      private readonly List<Expr> value; // значения элементов вектора
      public Vector(List<Expr> val) => value = val;
      public List<double> VCompute(IReadOnlyDictionary<string, double> variablesValues)
      {
         List<double> r = new List<double>();
         for (int i = 0; i < value.Count; i++)
           r.Add(value[i].Compute(variablesValues));
         return r;
      }
      public override string ToString()
      {
         string r = "";
         foreach (var i in value)
            r += $"{i} ";
         return "[ "+r+"]";
      }

      public Expr Deriv() => new Constant(0);
      public static Vector operator +(Vector a, Vector b)
      {
         if (a.value.Count != b.value.Count)
            throw new YouMadmanException("You madman! Vectors must be same demition! ");
         List<Expr> r = new List<Expr>();
         for (int i = 0; i < a.value.Count; i++)
            r.Add(a.value[i] + b.value[i]);
         return new Vector(r);
      }
      public static Vector operator -(Vector a, Vector b)
      {
         if (a.value.Count != b.value.Count)
            throw new YouMadmanException("You madman! Vectors must be same demition! ");
         List<Expr> r = new List<Expr>();
         for (int i = 0; i < a.value.Count; i++)
            r.Add(a.value[i] - b.value[i]);
         return new Vector(r);
      }
      public static Vector operator -(Vector a)
      {
         List<Expr> r = new List<Expr>();
         for (int i = 0; i < a.value.Count; i++) r.Add(- a.value[i]);
         return new Vector(r);
      }
      public static Vector operator *(Vector a, Expr b)
      {
         List<Expr> r = new List<Expr>();
         for (int i = 0; i < a.value.Count; i++) r.Add(a.value[i] *b);
         return new Vector(r);
      }
   }
}
