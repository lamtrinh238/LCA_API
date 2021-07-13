using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("DBAvfallstyper")]
    public partial class Dbavfallstyper
    {
        [Key]
        [Column("AV_ID")]
        public short AvId { get; set; }
        [Column("AV_NAME")]
        [StringLength(50)]
        public string AvName { get; set; }
        [Column("CO2", TypeName = "decimal(8, 4)")]
        public decimal? Co2 { get; set; }
        public bool? Sjekk { get; set; }
    }
}
