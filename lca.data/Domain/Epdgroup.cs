using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("EPDGroups")]
    public partial class Epdgroup
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(70)]
        public string GroupName { get; set; }
        [Column("COMID")]
        public long? Comid { get; set; }
        [Column("type")]
        public int? Type { get; set; }
    }
}
