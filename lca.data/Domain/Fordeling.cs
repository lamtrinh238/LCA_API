using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Keyless]
    [Table("Fordeling")]
    public partial class Fordeling
    {
        [StringLength(10)]
        public string Sortering { get; set; }
        [Column("Fordeling", TypeName = "numeric(5, 2)")]
        public decimal? Fordeling1 { get; set; }
    }
}
