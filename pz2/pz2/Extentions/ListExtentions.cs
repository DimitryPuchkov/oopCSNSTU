using System;
using System.Collections.Generic;
using System.Text;

namespace pz2.Extentions
{
   public static class ListExtentions
   {
      public static string ListToString(this List<double> l)
      {
         string res = "";
         foreach (var i in l)
            res += i.ToString() + " ";
         return res;
      }
   }
}
