using System;
using System.Collections.Generic;
using System.Text;

namespace Mentor.Test.Exceptions
{
   public class NotFoundException: ApplicationException
    {
        public string Message;

        public NotFoundException()
        {
            this.Message = ("Item is Not found in stock");
        }
        public NotFoundException(string message)
        {
            this.Message = message;
        }
    }
    
    
}
