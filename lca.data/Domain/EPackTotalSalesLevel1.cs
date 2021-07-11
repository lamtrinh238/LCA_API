using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Keyless]
    public partial class EPackTotalSalesLevel1
    {
        [Column("HeadID")]
        public int? HeadId { get; set; }
        [Column("MaterialGroupID")]
        public int? MaterialGroupId { get; set; }
        [Column("SUM3")]
        public double? Sum3 { get; set; }
    }
}
