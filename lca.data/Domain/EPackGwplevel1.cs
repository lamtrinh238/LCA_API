using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Keyless]
    public partial class EPackGwplevel1
    {
        [Column("HeadID")]
        public int? HeadId { get; set; }
        [StringLength(500)]
        public string Name { get; set; }
        [Required]
        [StringLength(70)]
        public string MainGroupName { get; set; }
        [Required]
        [Column("GWPName")]
        [StringLength(14)]
        public string Gwpname { get; set; }
        [Required]
        [Column("F_E_Unit")]
        [StringLength(6)]
        public string FEUnit { get; set; }
        public double? SalesVolume { get; set; }
        [Column("GWP", TypeName = "decimal(12, 2)")]
        public decimal? Gwp { get; set; }
        [Column("COM_ID")]
        public long? ComId { get; set; }
    }
}
