using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class Dcheading
    {
        public Dcheading()
        {
            Dcrecipients = new HashSet<Dcrecipient>();
        }

        public int Id { get; set; }
        public string DcrefNo { get; set; }
        public string Dcname { get; set; }
        public string Dcdescription { get; set; }
        public string Dcspesification { get; set; }
        public long? UserId { get; set; }
        public DateTime? Dcdate { get; set; }
        public DateTime? DcstartDate { get; set; }
        public DateTime? DcstopDate { get; set; }
        public int? Dcstatus { get; set; }
        public int? Dcquestions { get; set; }
        public string Comments { get; set; }
        public string Dcpicture1 { get; set; }
        public string Dcpicture2 { get; set; }
        public long? ComId { get; set; }
        public int? GroupId { get; set; }

        public virtual Company Com { get; set; }
        public virtual ICollection<Dcrecipient> Dcrecipients { get; set; }
    }
}
