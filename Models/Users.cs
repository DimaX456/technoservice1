using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TecnoService.Models
{
    public partial class Users
    {
        public Users()
        {
            Requests = new HashSet<Requests>();
        }

        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Requests> Requests { get; set; }
    }
}
