using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Keyless]
    [Table("EPDSubType")]
    public partial class EpdsubType
    {
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
    }
}
