using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Keyless]
    [Table("WCMainGroups")]
    public partial class WcmainGroup
    {
        [StringLength(150)]
        public string MainGroup { get; set; }
        [Column("CO2", TypeName = "decimal(28, 16)")]
        public decimal? Co2 { get; set; }
        [Column("Price_NET", TypeName = "decimal(18, 2)")]
        public decimal? PriceNet { get; set; }
    }
}
