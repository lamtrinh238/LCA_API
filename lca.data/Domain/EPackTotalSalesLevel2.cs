using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Keyless]
    public partial class EPackTotalSalesLevel2
    {
        [Column("HeadID")]
        public int? HeadId { get; set; }
        public int? ProductGroup { get; set; }
        [Column("SUM2")]
        public double? Sum2 { get; set; }
        [Column("SUM3")]
        public double? Sum3 { get; set; }
    }
}
