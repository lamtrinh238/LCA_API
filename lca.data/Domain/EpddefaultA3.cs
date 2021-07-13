using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("EPDDefaultA3")]
    public partial class EpddefaultA3
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("COM_ID")]
        public int ComId { get; set; }
        [Column("EPDA3ID")]
        public int Epda3id { get; set; }
        [Column("EPDA3Name")]
        [StringLength(150)]
        public string Epda3name { get; set; }
        [Column("EPDA3Quantity", TypeName = "decimal(18, 9)")]
        public decimal? Epda3quantity { get; set; }
        [StringLength(250)]
        public string Comments { get; set; }
        [Column("EPDA3Unit")]
        [StringLength(50)]
        public string Epda3unit { get; set; }
        [Column("GroupID")]
        public int? GroupId { get; set; }
        [Column("type")]
        public int? Type { get; set; }
        [Column("Unit_calc", TypeName = "decimal(18, 4)")]
        public decimal? UnitCalc { get; set; }
    }
}
