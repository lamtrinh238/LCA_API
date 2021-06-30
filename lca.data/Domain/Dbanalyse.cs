using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class Dbanalyse
    {
        public Dbanalyse()
        {
            DbanalyseSites = new HashSet<DbanalyseSite>();
        }

        public long AnalyseId { get; set; }
        public string Navn { get; set; }
        public string Beskrivelse { get; set; }
        public string Ansvarlig { get; set; }
        public string Innlogget { get; set; }
        public DateTime? Dato { get; set; }
        public short? Status { get; set; }
        public long? UserId { get; set; }
        public long? ComId { get; set; }

        public virtual ICollection<DbanalyseSite> DbanalyseSites { get; set; }
    }
}
