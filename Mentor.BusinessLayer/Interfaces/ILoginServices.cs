using Mentor.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mentor.BusinessLayer.Interfaces
{
    public interface ILoginServices
    {
        bool SignUp(string Role,string UserName,string Password,long ContactNumber);
        bool SignIn( string UserName,string Password);
    }
}
