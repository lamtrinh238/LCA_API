using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class Dbresultdetail
    {
        public long Id { get; set; }
        public long? AnalyseId { get; set; }
        public long? AvId { get; set; }
        public string AvNavn { get; set; }
        public decimal? T1Til { get; set; }
        public decimal? T1I { get; set; }
        public decimal? T1Fra { get; set; }
        public decimal? T2 { get; set; }
        public decimal? T3 { get; set; }
        public decimal? Optibag { get; set; }
        public decimal? Avfallbehandling { get; set; }
        public decimal? ReplacedMaterial { get; set; }
        public short? BehandlingId { get; set; }
        public string Sted { get; set; }
    }
}
