using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace L2_MentorOnDemand.Controllers
{
    public class LoginController : Controller
    {
        public bool SignIn(string UserName, string Password)
        {
            //write a code to check for login
            return true;
        }

        public bool SignUp(string Role, string UserName, string Password, long ContactNumber)
        {
            //write a code to check for signup
            return true;
        }
    }
}