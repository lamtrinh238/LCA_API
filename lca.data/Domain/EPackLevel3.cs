using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Keyless]
    public partial class EPackLevel3
    {
        [Column("HeadID")]
        public int? HeadId { get; set; }
        [StringLength(500)]
        public string Name { get; set; }
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(250)]
        public string ProductName { get; set; }
        [StringLength(250)]
        public string ProductGroupName { get; set; }
        [Column("MainGroupID")]
        public int? MainGroupId { get; set; }
        [StringLength(70)]
        public string MainGroupName { get; set; }
        public int? ProductGroup { get; set; }
        [Column("MaterialGroupID")]
        public int? MaterialGroupId { get; set; }
        [Column("F_E_Unit")]
        [StringLength(50)]
        public string FEUnit { get; set; }
        [Required]
        [StringLength(70)]
        public string GroupName { get; set; }
        public int? TransportGroup { get; set; }
        public double? SalesVolume { get; set; }
        public double? WasteVolume { get; set; }
        public double? WastePrecent { get; set; }
        [Column("kgprT", TypeName = "decimal(38, 4)")]
        public decimal? KgprT { get; set; }
        public double? Weight { get; set; }
        [Column("GWP", TypeName = "decimal(38, 4)")]
        public decimal? Gwp { get; set; }
        public bool? PartOfSelection { get; set; }
        [Column("PackTypeID")]
        public int? PackTypeId { get; set; }
        [Column("COM_ID")]
        public long? ComId { get; set; }
        [Column("ProductID")]
        [StringLength(50)]
        public string ProductId { get; set; }
    }
}
