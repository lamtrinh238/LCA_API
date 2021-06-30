using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class EpdanalysisList
    {
        public EpdanalysisList()
        {
            EpdanalysisFases = new HashSet<EpdanalysisFase>();
        }

        public int Id { get; set; }
        public int? EpdanalysisId { get; set; }
        public int? AnaId { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public decimal? UnitCalc { get; set; }

        public virtual Epdanalysis Epdanalysis { get; set; }
        public virtual ICollection<EpdanalysisFase> EpdanalysisFases { get; set; }
    }
}
