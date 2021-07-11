using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Keyless]
    public partial class StandardCategory
    {
        [Column("CategoryID")]
        public int CategoryId { get; set; }
        [StringLength(255)]
        public string CategoryName { get; set; }
        [StringLength(255)]
        public string F3 { get; set; }
    }
}
