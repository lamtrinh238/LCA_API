using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("EPDRegistrationFasesDigi")]
    public partial class EpdregistrationFasesDigi
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("EPDHeadingID")]
        public int EpdheadingId { get; set; }
        [Column("EPDRecID")]
        public int EpdrecId { get; set; }
        [Column("EPDName")]
        [StringLength(500)]
        public string Epdname { get; set; }
        [Column("EPDQuantity", TypeName = "decimal(29, 9)")]
        public decimal? Epdquantity { get; set; }
        [StringLength(250)]
        public string Comments { get; set; }
        [Column("EPDUnit")]
        [StringLength(50)]
        public string Epdunit { get; set; }
        [Column("type")]
        public int? Type { get; set; }
        [Column("Unit_calc", TypeName = "decimal(29, 9)")]
        public decimal? UnitCalc { get; set; }
        [Column(TypeName = "decimal(21, 12)")]
        public decimal? A1 { get; set; }
        [Column(TypeName = "decimal(21, 12)")]
        public decimal? A2 { get; set; }
        [Column(TypeName = "decimal(21, 12)")]
        public decimal? A3 { get; set; }
        [Column(TypeName = "decimal(21, 12)")]
        public decimal? A4 { get; set; }
        [Column(TypeName = "decimal(21, 12)")]
        public decimal? A5 { get; set; }
        [Column(TypeName = "decimal(21, 12)")]
        public decimal? B1 { get; set; }
        [Column(TypeName = "decimal(21, 12)")]
        public decimal? B2 { get; set; }
        [Column(TypeName = "decimal(21, 12)")]
        public decimal? B3 { get; set; }
        [Column(TypeName = "decimal(21, 12)")]
        public decimal? B4 { get; set; }
        [Column(TypeName = "decimal(21, 12)")]
        public decimal? B5 { get; set; }
        [Column(TypeName = "decimal(21, 12)")]
        public decimal? B6 { get; set; }
        [Column(TypeName = "decimal(21, 12)")]
        public decimal? B7 { get; set; }
        [Column(TypeName = "decimal(21, 12)")]
        public decimal? C1 { get; set; }
        [Column(TypeName = "decimal(21, 12)")]
        public decimal? C2 { get; set; }
        [Column(TypeName = "decimal(21, 12)")]
        public decimal? C3 { get; set; }
        [Column(TypeName = "decimal(21, 12)")]
        public decimal? C4 { get; set; }
        [Column(TypeName = "decimal(21, 12)")]
        public decimal? D1 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastUpdate { get; set; }

        [ForeignKey(nameof(EpdheadingId))]
        [InverseProperty(nameof(EpdheadingDigi.EpdregistrationFasesDigis))]
        public virtual EpdheadingDigi Epdheading { get; set; }
    }
}
