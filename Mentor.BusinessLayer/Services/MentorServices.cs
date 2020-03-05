using Mentor.BusinessLayer.Interfaces;
using Mentor.DataLayer.NHibernateConfigurations;
using Mentor.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mentor.BusinessLayer.Services
{
    public class MentorServices : IMentorServices
    {
        private readonly IMapperSession _session;

        public MentorServices(IMapperSession session)
        {
            _session = session;
        }

        public bool AcceptProposal(int UserId)
        {
            return true;
        }

       

        public bool AddProfile(MentorDetails mentor)
        {
            MentorDetails mentordetails = new MentorDetails();
            return true;

        }

        public MentorDetails EditProfile(long MentorId)
        {
            MentorDetails mentor = new MentorDetails();
            return mentor;

        }

       
        public MentorDetails ViewMentor(long Id)
        {
            MentorDetails mentordetails = new MentorDetails();
            return mentordetails;
        }

        public MentorDetails ViewProfile(long MentorId)
        {
            MentorDetails mentor = new MentorDetails();
            return mentor;

        }

        public User ViewProposal(long UserId)
        {
            User user = new User();
            return user;

        }
    }
}
