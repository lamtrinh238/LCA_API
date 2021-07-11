using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("XMLUnit")]
    public partial class Xmlunit
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(50)]
        public string FactorName { get; set; }
        [Column(TypeName = "decimal(12, 6)")]
        public decimal? FactorUnit { get; set; }
    }
}
