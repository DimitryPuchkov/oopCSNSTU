using System;
using System.Collections.Generic;
using System.Text;

namespace pz2.Exceptions
{
   class YouMadman : Exception
   {
      public YouMadman(string message)
        : base(message)
      {
      }
   }
}
