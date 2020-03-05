using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mentor.Entities;
using Microsoft.AspNetCore.Mvc;

namespace L2_MentorOnDemand.Controllers
{
    public class MentorController : Controller
    {
        public bool AcceptProposal(int UserId)
        {
            //write a code for acceptpraposal
            return true;
        }

        

        public bool AddProfile(MentorDetails mentor)
        {
            //write a code for Addprofile
            MentorDetails mentordetails = new MentorDetails();
            return true;

        }

        public IActionResult EditProfile(long MentorId)
        {
            //write a code for EditProfile
            MentorDetails mentor = new MentorDetails();
            return View();

        }


        public IActionResult ViewMentor(long Id)
        {
            //write a code for viewMentor
            MentorDetails mentordetails = new MentorDetails();
            return View();
        }

        public IActionResult ViewProfile(long MentorId)
        {
            //write a code for viewprofile
            MentorDetails mentor = new MentorDetails();
            return View();

        }

        public IActionResult ViewProposal(long UserId)
        {
            //write a code for viewproposal
            User user = new User();
            return View();

        }
    }
}
