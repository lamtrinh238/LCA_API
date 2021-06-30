using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class DbrestSite
    {
        public int Id { get; set; }
        public long AnalyseId { get; set; }
        public long PlukkId { get; set; }
        public short? AvId { get; set; }
        public string AvNavn { get; set; }
        public decimal? Prosent { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Avfallsbehandling { get; set; }
        public decimal? MaterialEnergi { get; set; }
        public short? BehandlingId { get; set; }
        public string Sted { get; set; }
        public long? DbanalyseSiteId { get; set; }

        public virtual DbanalyseSite DbanalyseSite { get; set; }
    }
}
