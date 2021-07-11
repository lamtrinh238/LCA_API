using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("DBResultdetail")]
    public partial class Dbresultdetail
    {
        [Key]
        [Column("ID")]
        public long Id { get; set; }
        [Column("AnalyseID")]
        public long? AnalyseId { get; set; }
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
        [Column(TypeName = "numeric(20, 2)")]
        public decimal? T2 { get; set; }
        [Column(TypeName = "numeric(20, 2)")]
        public decimal? T3 { get; set; }
        [Column(TypeName = "numeric(20, 2)")]
        public decimal? Optibag { get; set; }
        [Column(TypeName = "numeric(20, 2)")]
        public decimal? Avfallbehandling { get; set; }
        [Column("Replaced_material", TypeName = "numeric(20, 2)")]
        public decimal? ReplacedMaterial { get; set; }
        [Column("BehandlingID")]
        public short? BehandlingId { get; set; }
        [StringLength(150)]
        public string Sted { get; set; }
    }
}
