using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Keyless]
    public partial class EPackLevel1
    {
        [Column("HeadID")]
        public int? HeadId { get; set; }
        [StringLength(500)]
        public string Name { get; set; }
        [Column("MainGroupID")]
        public int? MainGroupId { get; set; }
        [Required]
        [StringLength(70)]
        public string GroupName { get; set; }
        [Column("MaterialGroupID")]
        public int? MaterialGroupId { get; set; }
        [Required]
        [StringLength(70)]
        public string ProductGroup { get; set; }
        [Column("F_E_Unit")]
        [StringLength(50)]
        public string FEUnit { get; set; }
        [Column("kgprT")]
        public double? KgprT { get; set; }
        [Column("GWP")]
        public double? Gwp { get; set; }
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
