using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("DBAnalyseSite")]
    public partial class DbanalyseSite
    {
        public DbanalyseSite()
        {
            DbrestSites = new HashSet<DbrestSite>();
        }

        [Key]
        [Column("ID")]
        public long Id { get; set; }
        [Column("AnalyseID")]
        public long AnalyseId { get; set; }
        [Column("AV_ID")]
        public short AvId { get; set; }
        [Column("BehandlingID")]
        public short? BehandlingId { get; set; }
        [Column("mengde", TypeName = "numeric(20, 2)")]
        public decimal? Mengde { get; set; }
        [Column("AV_Navn")]
        [StringLength(150)]
        public string AvNavn { get; set; }
        [StringLength(150)]
        public string Sted { get; set; }
        [Column("Avfallbehandling_res", TypeName = "numeric(20, 2)")]
        public decimal? AvfallbehandlingRes { get; set; }
        [Column("Material_Energi_res", TypeName = "numeric(20, 2)")]
        public decimal? MaterialEnergiRes { get; set; }
        [Column("Transport_2", TypeName = "numeric(20, 1)")]
        public decimal? Transport2 { get; set; }
        [Column("Transport_2_res", TypeName = "numeric(20, 1)")]
        public decimal? Transport2Res { get; set; }
        [Column("Transport_3", TypeName = "numeric(20, 1)")]
        public decimal? Transport3 { get; set; }
        [Column("Transport_3_res", TypeName = "numeric(20, 1)")]
        public decimal? Transport3Res { get; set; }
        [Column("Optibag_res", TypeName = "numeric(20, 2)")]
        public decimal? OptibagRes { get; set; }
        public int? Ruter { get; set; }
        [Column("frekvens")]
        public long? Frekvens { get; set; }
        [Column("uten_last")]
        public long? UtenLast { get; set; }
        [Column("i_rute")]
        public long? IRute { get; set; }
        [Column("til_tomming")]
        public long? TilTomming { get; set; }
        public long? Samlast { get; set; }
        [Column(TypeName = "decimal(20, 5)")]
        public decimal? Gjennomsnitt { get; set; }
        [StringLength(50)]
        public string Transport { get; set; }

        [ForeignKey(nameof(AnalyseId))]
        [InverseProperty(nameof(Dbanalyse.DbanalyseSites))]
        public virtual Dbanalyse Analyse { get; set; }
        [InverseProperty(nameof(DbrestSite.DbanalyseSite))]
        public virtual ICollection<DbrestSite> DbrestSites { get; set; }
    }
}
