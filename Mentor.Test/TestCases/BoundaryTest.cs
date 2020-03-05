using Mentor.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Mentor.Test
{
    public class BoundaryTest
    {

        [Fact]
        public void BoundaryTest_ForUserPassword_Length()
        {
            User user = new User();
            var MinLength = 8;
            var MaxLength = 25;

            //Action
            var actualLength = user.Password.Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }

        [Fact]
        public void BoundaryTest_ForMentorPassword_Length()
        {
            MentorDetails Mentor = new MentorDetails();
            var MinLength = 8;
            var MaxLength = 25;

            //Action
            var actualLength = Mentor.Password.Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }

        [Fact]
        public void BoundaryTest_ForMentorContactNumber_Length()
        {
            MentorDetails Mentor = new MentorDetails();
            var MinLength = 10;
            var MaxLength = 10;
            

            //Action
            var actualLength = Mentor.ContactNumber.ToString().Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }

        [Fact]
        public void BoundaryTest_ForUserContactNumber_Length()
        {
            User User = new User();
            var MinLength = 10;
            var MaxLength = 10;


            //Action
            var actualLength = User.ContactNumber.ToString().Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }

    }
}
