using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("DBRestSite")]
    public partial class DbrestSite
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("AnalyseID")]
        public long AnalyseId { get; set; }
        [Column("PlukkID")]
        public long PlukkId { get; set; }
        [Column("AV_ID")]
        public short? AvId { get; set; }
        [Column("AV_NAVN")]
        [StringLength(50)]
        public string AvNavn { get; set; }
        [Column("prosent", TypeName = "decimal(6, 2)")]
        public decimal? Prosent { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Quantity { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? Avfallsbehandling { get; set; }
        [Column("Material_energi", TypeName = "decimal(10, 2)")]
        public decimal? MaterialEnergi { get; set; }
        [Column("BehandlingID")]
        public short? BehandlingId { get; set; }
        [StringLength(150)]
        public string Sted { get; set; }
        [Column("DBAnalyseSiteID")]
        public long? DbanalyseSiteId { get; set; }

        [ForeignKey(nameof(DbanalyseSiteId))]
        [InverseProperty("DbrestSites")]
        public virtual DbanalyseSite DbanalyseSite { get; set; }
    }
}
