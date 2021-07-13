using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("TransportExp")]
    public partial class TransportExp
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("EPDA1ID")]
        public int? Epda1id { get; set; }
        [Column("EPDA1NAME")]
        [StringLength(150)]
        public string Epda1name { get; set; }
        [Column("EPDA2ID")]
        public int? Epda2id { get; set; }
        [Column("EPDA2NAME")]
        [StringLength(150)]
        public string Epda2name { get; set; }
        [Column("EPDA2km", TypeName = "decimal(18, 9)")]
        public decimal? Epda2km { get; set; }
        [StringLength(5000)]
        public string Comments { get; set; }
        [Column("Head_ID")]
        public int? HeadId { get; set; }
        [Column("EPDA1kg", TypeName = "decimal(18, 9)")]
        public decimal? Epda1kg { get; set; }
        [Column("type")]
        [StringLength(20)]
        public string Type { get; set; }
        [Column("CO2", TypeName = "decimal(18, 9)")]
        public decimal? Co2 { get; set; }
        [Column("line_ID")]
        public int? LineId { get; set; }
    }
}
