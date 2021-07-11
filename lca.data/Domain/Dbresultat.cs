using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("DBResultat")]
    public partial class Dbresultat
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("AnalyseID")]
        public long AnalyseId { get; set; }
        [Column("AV_ID")]
        public long? AvId { get; set; }
        [Column("AV_NAVN")]
        [StringLength(50)]
        public string AvNavn { get; set; }
        [Column("T1_Til", TypeName = "decimal(20, 1)")]
        public decimal? T1Til { get; set; }
        [Column("T1_I", TypeName = "decimal(20, 1)")]
        public decimal? T1I { get; set; }
        [Column("T1_Fra", TypeName = "decimal(20, 1)")]
        public decimal? T1Fra { get; set; }
        [Column(TypeName = "decimal(20, 1)")]
        public decimal? T2 { get; set; }
        [Column(TypeName = "decimal(20, 1)")]
        public decimal? T3 { get; set; }
        [Column(TypeName = "decimal(20, 1)")]
        public decimal? Avfallbehandling { get; set; }
        [Column("Energi_material", TypeName = "decimal(20, 1)")]
        public decimal? EnergiMaterial { get; set; }
        [Column("BehandlingID")]
        public short? BehandlingId { get; set; }
        [StringLength(150)]
        public string Sted { get; set; }
    }
}
