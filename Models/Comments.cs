using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TecnoService.Models
{
    public partial class Comments
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public int? RequestId { get; set; }
        public int? Staffid { get; set; }

        public virtual Requests Request { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
