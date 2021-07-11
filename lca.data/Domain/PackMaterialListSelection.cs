using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("PackMaterialListSelection")]
    public partial class PackMaterialListSelection
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("ProductLineID")]
        public int? ProductLineId { get; set; }
        [Column("PackTypeID")]
        public int? PackTypeId { get; set; }
        [Column("PackMaterialID")]
        public int? PackMaterialId { get; set; }
        public double? PackNetWeight { get; set; }
        [StringLength(500)]
        public string Comments { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? KgprT { get; set; }
        [Column("GWP", TypeName = "decimal(18, 4)")]
        public decimal? Gwp { get; set; }
        [Column(TypeName = "decimal(5, 1)")]
        public decimal? PrecentResirk { get; set; }

        [ForeignKey(nameof(ProductLineId))]
        [InverseProperty(nameof(ProductsLine.PackMaterialListSelections))]
        public virtual ProductsLine ProductLine { get; set; }
    }
}
