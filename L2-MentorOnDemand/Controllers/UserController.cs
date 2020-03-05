using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mentor.Entities;
using Microsoft.AspNetCore.Mvc;

namespace L2_MentorOnDemand.Controllers
{
    public class UserController : Controller
    {
        public bool AddProfile(User User)
        {
            //write a code for Addprofile
            return true;

        }


        public bool AssignRating(int Rating)
        {
            //write a code for AssignRating
            if (true)
            {
                return true;
            }
            else
            {

            }
        }

        public IActionResult EditProfile(long UserId)
        {
            //write a code for editprofile
            User user = new User();
            return View();

        }

        public IActionResult GetMentorDetails(string Technology)
        {
            //write a code for getmentordetail
            List<MentorDetails> getmentordetails = new List<MentorDetails>();
            return View();
        }

        public IActionResult SearchMentor(string Technology)
        {
            //write a code for searchmentor
            List<MentorDetails> mentor = new List<MentorDetails>();
            return View();
        }

        public IActionResult SelectMentor(long MentorId)
        {
            //write a code for selectmentor
            MentorDetails mentor = new MentorDetails();
            return View();

        }

        public bool SendProposal(User User, long MentorId)
        {
            //write a code for sendproposal
            if (true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public IActionResult GetProfile(long UserId)
        {
            //write a code for getprofile
            User user = new User();
            return View();

        }

        public IActionResult GetTrainings(string status)
        {
            //write a code for editTraining
            List<TrainingDetails> TrainingDetails = new List<TrainingDetails>();
            return View();
        }
    }
}