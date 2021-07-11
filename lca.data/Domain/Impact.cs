using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Keyless]
    [Table("Impact")]
    public partial class Impact
    {
        [Column("ImpactID")]
        [StringLength(50)]
        public string ImpactId { get; set; }
        [Column("ProcessID")]
        [StringLength(50)]
        public string ProcessId { get; set; }
        [StringLength(50)]
        public string ImpactCategory { get; set; }
        [StringLength(50)]
        public string ImpactScalar { get; set; }
    }
}
