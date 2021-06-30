using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class Epdanalysis
    {
        public Epdanalysis()
        {
            EpdanalysisLists = new HashSet<EpdanalysisList>();
        }

        public int Id { get; set; }
        public string Ananumber { get; set; }
        public string Ananame { get; set; }
        public string Anadescription1 { get; set; }
        public string Anaspesification { get; set; }
        public string Anatech { get; set; }
        public string Anamarket { get; set; }
        public long? UserId { get; set; }
        public DateTime? Epddate { get; set; }
        public long ComId { get; set; }
        public int? RefId { get; set; }
        public int? AnaId { get; set; }

        public virtual Company Com { get; set; }
        public virtual ICollection<EpdanalysisList> EpdanalysisLists { get; set; }
    }
}
