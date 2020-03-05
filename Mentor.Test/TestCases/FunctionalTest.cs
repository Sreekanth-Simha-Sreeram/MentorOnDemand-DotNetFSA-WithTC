using Mentor.BusinessLayer.Services;
using Mentor.DataLayer.NHibernateConfigurations;
using Mentor.Entities;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Mentor.Test
{
   public class FunctionalTest
    {

        private readonly UserServices User_Service;
        private readonly MentorServices Mentor_service;
        private readonly LoginServices Login_service;
        private readonly IMapperSession _Session = Substitute.For<IMapperSession>();

        public FunctionalTest()
        {
            User_Service = new UserServices(_Session);
            Mentor_service = new MentorServices(_Session);
            Login_service = new LoginServices(_Session);
        }

        [Fact]
        public void Test_for_SearchMentor()
        {
            //Arrange
            MentorDetails mentor = new MentorDetails()
            { 
                Technology = ".net" 
            };
            
           //Action
            var result = User_Service.SearchMentor(mentor.Technology);
            var getSearchMentor = User_Service.GetMentorDetails(mentor.Technology);
           
            //Assert
            Assert.Equal(result, getSearchMentor);
        }

        [Fact]
        public void Test_for_SendProposal()
        {
            //Arrange
            User user = new User()
            {
                Id = 1,
                UserName = "aaa",
                FirstName = "aaa",
                LastName = "bbb",
                ContactNumber = 1111111111,
                Experience = 2,

            };

            MentorDetails mentor = new MentorDetails
            {
                Id = 1,
            };


            var result = User_Service.SendProposal(user, mentor.Id);


            Assert.True(result);

        }

        [Fact]
        public void Test_for_AssignRating()
        {
            MentorDetails mentor = new MentorDetails() 
            { 
                Rating = 5 
            };
            
            var IsAdded = User_Service.AssignRating(mentor.Rating);
            Assert.True(IsAdded);

        }

        [Fact]
        public void Test_for_AddProfileUser()
        {
            User user = new User()
            {
                Id = 1,
                UserName = "aaa",
                FirstName = "aaa",
                LastName = "bbb",
                ContactNumber = 1111111111,
                Experience = 2,
            };

            var result = User_Service.AddProfile(user);

            Assert.True(result);
        }

        [Fact]
        public void Test_for_EditProfile()
        {
            User user = new User()
            {
                Id = 1,
                
            };

            var EditProfile = User_Service.EditProfile(user.Id);
            var GetProfile = User_Service.GetProfile(user.Id);

            Assert.Equal(EditProfile, GetProfile);
        }

        [Fact]
        public void Test_for_AddProfileMentor()
        {
            MentorDetails mentordetails = new MentorDetails()
            {
                Id = 1,
                Email = "aa@gmail.com",
                Technology = "sss",
                Role = "bbb",
                Exprience = 2,
                Facilities="qqq",
                Fees=2000,
                WorkHours=4

            };

            var AddProfile = Mentor_service.AddProfile(mentordetails);

            Assert.True(AddProfile);
        }

        [Fact]
        public void Test_for_AcceptProposal()
        {
            User user = new User()
            {
                Id = 1,
            };

            var Acceptproposal = Mentor_service.AcceptProposal(user.Id);

            Assert.True(Acceptproposal);
        } 

        [Fact]
        public void Test_for_MentorEditProfile()
        {
            MentorDetails mentor=new MentorDetails()
            {
                Id = 1,
                

            };

            var EditmentorProfile = Mentor_service.EditProfile(mentor.Id);
            var GetmentorProfile = Mentor_service.ViewProfile(mentor.Id);

            Assert.Equal(EditmentorProfile, GetmentorProfile);

        }


        [Fact]
        public void Test_for_UserLoginSingup()
        {
            User user = new User()
            {
                Role = "aaa",
                UserName = "1qq",
                Password = "111",
                ContactNumber = 111111111

            };

            var signUp = Login_service.SignUp(user.Role, user.UserName, user.Password, user.ContactNumber);

            Assert.True(signUp);
        }

        [Fact]
        public void Test_for_MentorLoginSingup()
        {
            MentorDetails mentordetail = new MentorDetails()
            {
                Role = "aaa",
                UserName = "1qq",
                Password = "111",
                ContactNumber = 111111111

            };

            var signUp = Login_service.SignUp(mentordetail.Role, mentordetail.UserName, mentordetail.Password, mentordetail.ContactNumber);

            Assert.True(signUp);
        }

        [Fact]
        public void Test_for_UserLoginSingIn()
        {
            User user = new User()
            {
                
                UserName = "1qq",
                Password = "111",
                

            };

            var signIn = Login_service.SignIn(user.UserName, user.Password);

            Assert.True(signIn);
        }

        [Fact]
        public void Test_for_MentorLoginSingIn()
        {
            MentorDetails mentordetail = new MentorDetails()
            {
               
                UserName = "1qq",
                Password = "111",
               

            };

            var signIn = Login_service.SignIn(mentordetail.UserName, mentordetail.Password);

            Assert.True(signIn);
        }


    }
}
