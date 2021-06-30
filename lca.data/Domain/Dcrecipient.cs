using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class Dcrecipient
    {
        public Dcrecipient()
        {
            Dcanswers = new HashSet<Dcanswer>();
        }

        public int Id { get; set; }
        public int DcheadingId { get; set; }
        public string Recipients { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? LastChange { get; set; }
        public DateTime? FinishedDate { get; set; }
        public int? Status { get; set; }
        public string Message { get; set; }
        public string Comments { get; set; }
        public string Email { get; set; }
        public long? UsrId { get; set; }
        public DateTime? LastMailDate { get; set; }

        public virtual Dcheading Dcheading { get; set; }
        public virtual ICollection<Dcanswer> Dcanswers { get; set; }
    }
}
