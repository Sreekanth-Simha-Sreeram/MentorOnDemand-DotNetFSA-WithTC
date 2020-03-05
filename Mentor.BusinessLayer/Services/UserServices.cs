using Mentor.BusinessLayer.Interfaces;
using Mentor.DataLayer.NHibernateConfigurations;
using Mentor.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mentor.BusinessLayer.Services
{
    

    public class UserServices : IUserServices
    {

        private readonly IMapperSession _session;

        public UserServices(IMapperSession session)
        {
            _session = session;
        }

        public bool AddProfile(User User)
        {
           
            return true;

        }


        public bool AssignRating(int Rating)
        {
            if (true)
            {
                return true;
            }
            else
            {

            }
        }

        public User EditProfile(long UserId)
        {
            User user = new User();
            return user;

        }

        public List<MentorDetails> GetMentorDetails(string Technology)
        {
            List<MentorDetails> getmentordetails = new List<MentorDetails>();
            return getmentordetails;
        }

        public List<MentorDetails> SearchMentor(string Technology)
        {
            List<MentorDetails> mentor = new List<MentorDetails>();
            return mentor;
        }

        public MentorDetails SelectMentor(long MentorId)
        {
            MentorDetails mentor = new MentorDetails();
            return mentor;

        }

        public bool SendProposal(User User, long MentorId)
        {
              if (true)
              {
                    return true;
              }
              else
              {
                    return false;
              }
        }

        
        public User GetProfile(long UserId)
        {
            User user = new User();
            return user;

        }

        public List<TrainingDetails> GetTrainings(string status)
        {
            List<TrainingDetails> TrainingDetails = new List<TrainingDetails>();
            return TrainingDetails;
        }
    }
}
