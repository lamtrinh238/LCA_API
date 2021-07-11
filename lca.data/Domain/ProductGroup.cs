using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Keyless]
    public partial class ProductGroup
    {
        [Column("VgruppeID")]
        public int VgruppeId { get; set; }
        [StringLength(255)]
        public string VgruppeName { get; set; }
        [Column("HgruppeID")]
        public int? HgruppeId { get; set; }
    }
}
