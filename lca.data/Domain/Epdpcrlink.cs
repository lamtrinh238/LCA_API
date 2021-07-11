using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("EPDPCRLink")]
    public partial class Epdpcrlink
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("PCRID")]
        public int? Pcrid { get; set; }
        [Column("ProcessID")]
        public int? ProcessId { get; set; }
        [Column("COM_ID")]
        public int? ComId { get; set; }
        [StringLength(10)]
        public string Fase { get; set; }
        [Column("EPDQuantity", TypeName = "decimal(29, 9)")]
        public decimal? Epdquantity { get; set; }
    }
}
