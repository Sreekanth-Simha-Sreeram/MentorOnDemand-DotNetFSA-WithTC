using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Mentor.Entities
{
  public class User
    {
        public virtual int Id { get; set; }
        [Required(ErrorMessage = "Required")]
        public virtual string UserName { get; set; }
        public virtual string Password { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Wrong mobile")]
        public virtual long ContactNumber { get; set; }
        public virtual string Role { get; set; }
        public virtual string LinkedinURL { get; set; }
        public virtual int Experience { get; set; }
        public virtual bool Active { get; set; }
        public virtual bool ConfirmedSignUp { get; set; }
        public virtual bool ResetPassword { get; set; }
        public virtual DateTime ResetPasswordDate { get; set; }
    }
}
