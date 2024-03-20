using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TecnoService.Models
{
    public partial class Staff
    {
        public Staff()
        {
            Comments = new HashSet<Comments>();
            Processing = new HashSet<Processing>();
        }

        public int Id { get; set; }
        public string FullName { get; set; }

        public virtual ICollection<Comments> Comments { get; set; }
        public virtual ICollection<Processing> Processing { get; set; }
    }
}
