using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class Dbtransport
    {
        public int Id { get; set; }
        public string Transport { get; set; }
        public long? AvId { get; set; }
        public string AvNavn { get; set; }
        public int? Ruter { get; set; }
        public long? Frekvens { get; set; }
        public long? UtenLast { get; set; }
        public long? IRute { get; set; }
        public long? TilTomming { get; set; }
        public long? AnalyseId { get; set; }
        public long? Samlast { get; set; }
        public decimal? Gjennomsnitt { get; set; }
        public short? BehandlingId { get; set; }
        public string Sted { get; set; }
    }
}
