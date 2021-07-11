using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Keyless]
    public partial class EPackGwplevel2
    {
        [Column("COM_ID")]
        public long? ComId { get; set; }
        [Column("HeadID")]
        public int? HeadId { get; set; }
        [StringLength(500)]
        public string Name { get; set; }
        public int? ProductGroup { get; set; }
        [Column("EPDMaterialName")]
        [StringLength(250)]
        public string EpdmaterialName { get; set; }
        [Required]
        [StringLength(70)]
        public string MainGroupName { get; set; }
        public double? SalesVolume { get; set; }
        [Required]
        [Column("GWPName")]
        [StringLength(14)]
        public string Gwpname { get; set; }
        [Required]
        [Column("F_E_Unit")]
        [StringLength(6)]
        public string FEUnit { get; set; }
        [Column("GWP")]
        public double? Gwp { get; set; }
    }
}
