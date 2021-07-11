using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Keyless]
    public partial class EPackAnalyseGwp
    {
        [Column("ANAID")]
        public int Anaid { get; set; }
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(250)]
        public string ProductName { get; set; }
        [StringLength(250)]
        public string ProductGroupName { get; set; }
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
