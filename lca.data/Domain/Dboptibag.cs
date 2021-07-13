using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("DBOptibag")]
    public partial class Dboptibag
    {
        [Key]
        [Column("OPTIID")]
        public short Optiid { get; set; }
        [Column("OPTICO2", TypeName = "decimal(8, 4)")]
        public decimal? Optico2 { get; set; }
        [Column("OPTINavn")]
        [StringLength(50)]
        public string Optinavn { get; set; }
    }
}
