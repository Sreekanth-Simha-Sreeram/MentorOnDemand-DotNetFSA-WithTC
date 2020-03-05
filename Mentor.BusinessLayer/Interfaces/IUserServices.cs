using Mentor.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace Mentor.BusinessLayer.Interfaces
{
    public interface IUserServices
    {
        bool AddProfile(User User);
        User GetProfile(long UserId);
        User EditProfile(long UserId);
        List<MentorDetails> SearchMentor(string Technology);
        MentorDetails SelectMentor(long MentorId);
        bool SendProposal(User User,long MentorId);
        bool AssignRating(int Rating);
        List<TrainingDetails> GetTrainings(string status);

        List<MentorDetails> GetMentorDetails(string Technology);
    }
}
