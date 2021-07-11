using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("ComProcessLink")]
    public partial class ComProcessLink
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("COM_ID")]
        public long ComId { get; set; }
        [Column("Process_ID")]
        public int? ProcessId { get; set; }
        [Column("Process_Name")]
        [StringLength(250)]
        public string ProcessName { get; set; }

        [ForeignKey(nameof(ComId))]
        [InverseProperty(nameof(Company.ComProcessLinks))]
        public virtual Company Com { get; set; }
    }
}
