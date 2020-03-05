using Mentor.BusinessLayer.Interfaces;
using Mentor.DataLayer.NHibernateConfigurations;
using Mentor.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mentor.BusinessLayer.Services
{
  
   
     public class LoginServices : ILoginServices
    {
        private readonly IMapperSession _session;

        public LoginServices(IMapperSession session)
        {
            _session = session;
        }
        public bool SignIn( string UserName, string Password)
        {
            return true;
        }

        public bool SignUp (string Role, string UserName, string Password, long ContactNumber)
        {
            return true;
        }
    }
}
