using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class DbanalyseSite
    {
        public DbanalyseSite()
        {
            DbrestSites = new HashSet<DbrestSite>();
        }

        public long Id { get; set; }
        public long AnalyseId { get; set; }
        public short AvId { get; set; }
        public short? BehandlingId { get; set; }
        public decimal? Mengde { get; set; }
        public string AvNavn { get; set; }
        public string Sted { get; set; }
        public decimal? AvfallbehandlingRes { get; set; }
        public decimal? MaterialEnergiRes { get; set; }
        public decimal? Transport2 { get; set; }
        public decimal? Transport2Res { get; set; }
        public decimal? Transport3 { get; set; }
        public decimal? Transport3Res { get; set; }
        public decimal? OptibagRes { get; set; }
        public int? Ruter { get; set; }
        public long? Frekvens { get; set; }
        public long? UtenLast { get; set; }
        public long? IRute { get; set; }
        public long? TilTomming { get; set; }
        public long? Samlast { get; set; }
        public decimal? Gjennomsnitt { get; set; }
        public string Transport { get; set; }

        public virtual Dbanalyse Analyse { get; set; }
        public virtual ICollection<DbrestSite> DbrestSites { get; set; }
    }
}
