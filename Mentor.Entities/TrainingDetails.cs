using System;
using System.Collections.Generic;
using System.Text;

namespace Mentor.Entities
{
   public class TrainingDetails
    {
        public virtual long Id { get; set; }
        public virtual string Status { get; set; }
        public virtual int Progress { get; set; }
        public virtual float Fees { get; set; }
        public virtual float CommissionAmount { get; set; }
        public virtual int Rating { get; set; }
        public virtual string StartDate { get; set; }
        public virtual string EndDate { get; set; }
        public virtual string StartTime { get; set; }
        public virtual string EndTime { get; set; }
        public virtual float AmountReceived { get; set; }
        public virtual int UserId { get; set; }
        public virtual int MentorId { get; set; }
        public virtual int SkillId { get; set; }

    }
}
