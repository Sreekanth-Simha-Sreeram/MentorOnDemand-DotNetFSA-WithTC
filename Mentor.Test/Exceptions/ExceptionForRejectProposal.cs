using System;
using System.Collections.Generic;
using System.Text;

namespace Mentor.Test.Exceptions
{
   public class ExceptionForRejectProposal:Exception
    {
        public string Message;

        public ExceptionForRejectProposal()
        {
            this.Message = ("Rejected the Proposal");
        }
        public ExceptionForRejectProposal(string message)
        {
            this.Message = message;
        }
    }
}
