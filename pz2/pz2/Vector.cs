using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pz2.Exceptions;

namespace pz2
{
   class Vector 
   {
      private List<Expr> value; // значения элементов вектора
      public Vector(List<Expr> val) => value = val;
      public string VCompute(IReadOnlyDictionary<string, double> variablesValues)
      {
         //List<double> r = new List<double>();
         for (int i = 0; i < value.Count; i++)
           value[i] = value[i].Compute(variablesValues);

         return this.ToString();
      }
      public override string ToString()
      {
         string r = "";
         foreach (var i in value)
            r += $"{i}, ";
         return "[ "+r+"]";
      }

      public  Expr Deriv() => new Constant(0);
      public static Vector operator +(Vector a, Vector b)
      {
         if (a.value.Count != b.value.Count)
            throw new YouMadmanException("You madman! Vectors must be same demition! ");
         List<Expr> val = a.value;
         for (int i = 0; i < val.Count; i++) val[i] += b.value[i];
         return new Vector(val);
      }
      public static Vector operator *(Vector a, Expr b)
      {
         List<Expr> val = a.value;
         for (int i = 0; i < val.Count; i++) val[i] *= b;
         return new Vector(val);
      }
   }
}
