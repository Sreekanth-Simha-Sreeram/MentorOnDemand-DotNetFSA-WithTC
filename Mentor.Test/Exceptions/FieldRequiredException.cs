using System;
using System.Collections.Generic;
using System.Text;

namespace Mentor.Test.Exceptions
{
   public  class FieldRequiredException:Exception
   {
        public string Message;

        public FieldRequiredException()
        {
            this.Message = ("UserName is Could not be empty");
        }
        public FieldRequiredException(string message)
        {
            this.Message = message;
        }
    }
}
