using Mentor.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mentor.BusinessLayer.Interfaces
{
   public interface IMentorServices
    {
        bool AddProfile(MentorDetails mentor);
        MentorDetails ViewProfile(long MentorId);
        MentorDetails EditProfile(long MentorId);
        User ViewProposal(long UserId);
        MentorDetails ViewMentor(long MentorId);
        bool AcceptProposal(int UserId);
    }
}
