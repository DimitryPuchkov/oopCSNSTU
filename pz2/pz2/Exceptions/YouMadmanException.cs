﻿using System;
using System.Collections.Generic;
using System.Text;

namespace pz2.Exceptions
{
   public class YouMadmanException : Exception
   {
      public YouMadmanException(string message)
        : base(message)
      {
      }
   }
}
