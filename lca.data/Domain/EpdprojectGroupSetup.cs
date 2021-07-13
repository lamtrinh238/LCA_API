using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("EPDProjectGroupSetup")]
    public partial class EpdprojectGroupSetup
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        public int? GroupNr { get; set; }
        [StringLength(100)]
        public string GroupName { get; set; }
        [Column("COMID")]
        public int? Comid { get; set; }
    }
}
