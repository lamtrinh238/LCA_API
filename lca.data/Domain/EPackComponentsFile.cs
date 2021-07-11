using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("ePackComponentsFiles")]
    public partial class EPackComponentsFile
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("CompID")]
        public int? CompId { get; set; }
        [StringLength(250)]
        public string FileName { get; set; }
        [StringLength(500)]
        public string Comments { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ValidTo { get; set; }
        [StringLength(250)]
        public string ShareName { get; set; }
    }
}
