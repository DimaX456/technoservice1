using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TecnoService.Models
{
    public partial class Requests
    {
        public Requests()
        {
            Comments = new HashSet<Comments>();
            Processing = new HashSet<Processing>();
            Reports = new HashSet<Reports>();
            Service = new HashSet<Service>();
        }

        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public int? EqupmentTypeId { get; set; }
        public int? MalfunctionId { get; set; }
        public string Description { get; set; }
        public int? ClientId { get; set; }
        public string Status { get; set; }

        public virtual Users Client { get; set; }
        public virtual EquipmentTypes EqupmentType { get; set; }
        public virtual Malfunctions Malfunction { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }
        public virtual ICollection<Processing> Processing { get; set; }
        public virtual ICollection<Reports> Reports { get; set; }
        public virtual ICollection<Service> Service { get; set; }
    }
}
