using System;
using System.Collections.Generic;
using System.Text;

namespace Mentor.Entities
{
   public class Skills
    {
        public virtual long Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string TOC { get; set; }
        public virtual string Prerequisites { get; set; }
    }
}
