using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Keyless]
    public partial class EPackLevel2
    {
        [Column("HeadID")]
        public int? HeadId { get; set; }
        [StringLength(500)]
        public string Name { get; set; }
        public int? ProductGroup { get; set; }
        [Column("EPDMaterialName")]
        [StringLength(250)]
        public string EpdmaterialName { get; set; }
        [Column("MaterialGroupID")]
        public int? MaterialGroupId { get; set; }
        [Required]
        [StringLength(70)]
        public string GroupName { get; set; }
        [Column("F_E_Unit")]
        [StringLength(50)]
        public string FEUnit { get; set; }
        public int? TransportGroup { get; set; }
        [Column("kgprT")]
        public double? KgprT { get; set; }
        [Column("GWP")]
        public double? Gwp { get; set; }
        [Column("MainGroupID")]
        public int? MainGroupId { get; set; }
        [Required]
        [StringLength(70)]
        public string MainGroupName { get; set; }
        public double? WastePrecent { get; set; }
        public double? SalesVolume { get; set; }
        [Column("COM_ID")]
        public long? ComId { get; set; }
        public bool? PartOfSelection { get; set; }
        [Column("PackTypeID")]
        public int? PackTypeId { get; set; }
        public long? Expr1 { get; set; }
    }
}
