using FluentNHibernate.Conventions.Inspections;
using Mentor.BusinessLayer.Services;
using Mentor.DataLayer.NHibernateConfigurations;
using Mentor.Entities;

using Mentor.Test.Exceptions;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Mentor.Test
{
   public class ExceptionTest
    {
        private readonly UserServices User_Service;
        private readonly MentorServices Mentor_service;
        private readonly LoginServices Login_service;
        private readonly IMapperSession _Session = Substitute.For<IMapperSession>();

        public ExceptionTest()
        {
            User_Service = new UserServices(_Session);
            Mentor_service = new MentorServices(_Session);
            Login_service = new LoginServices(_Session);
        }

        [Fact]
        public void ExceptionTestForSearchItems()
        {
            //Arrange
            MentorDetails mentor = new MentorDetails()
            { 
                Technology = ".net" 
            };
            List<MentorDetails> mentorlist = new List<MentorDetails>();
            mentorlist.Add(mentor);

            
          

            //Assert
            var ex = Assert.Throws<NotFoundException>(() => User_Service.SearchMentor(mentor.Technology));
            Assert.Equal("Item is Not found in stock", ex.Message);
            //   Assert.th(mentorlist, userServices.SearchMentor(mentor.Technology));

        }

        [Fact]
        public void ExceptionTestForRquiredField()
        {
            //Arrange
            MentorDetails mentor = new MentorDetails()
            {
                UserName = " ",
                Role="aa",
                Password="aaa",
                ContactNumber=12345678,

            };
            List<MentorDetails> mentorlist = new List<MentorDetails>();
            mentorlist.Add(mentor);

            var ex = Assert.Throws<FieldRequiredException>(() => Login_service.SignUp(mentor.Role, mentor.UserName, mentor.Password, mentor.ContactNumber));
            
            Assert.Equal("UserName is Could not be empty", ex.Message);
         

        }

        [Fact]
        public void ExceptionTestForAcceptProposal()
        {
            //Arrange
            User user = new User()
            {
                Id=1

            };
            

             var ex = Assert.Throws<ExceptionForRejectProposal>(() => Mentor_service.AcceptProposal(user.Id));
             Assert.Equal("Rejected the Proposal", ex.Message);
          

        }


        

   }
}
