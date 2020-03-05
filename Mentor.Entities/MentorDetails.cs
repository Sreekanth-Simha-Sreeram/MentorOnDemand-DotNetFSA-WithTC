using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Mentor.Entities
{
   public class MentorDetails
    {
        public virtual int Id { get; set; }
        public virtual string Email { get; set; }
        [Required(ErrorMessage = "Required")]
        public virtual string UserName { get; set; }
        public virtual string Technology { get; set; }
        public virtual string Role { get; set; }
        public virtual float Exprience { get; set; }
        public virtual string Facilities { get; set; }
        public virtual float Fees { get; set; }
        public virtual float WorkHours { get; set; }
        public virtual int Rating { get; set; }
        public virtual string Password { get; set; }
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Wrong mobile")]
        public virtual int ContactNumber { get; set; }
    }
}
