using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("ComPCRLink")]
    public partial class ComPcrlink
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("COM_ID")]
        public long ComId { get; set; }
        [Column("PCR_ID")]
        public int? PcrId { get; set; }

        [ForeignKey(nameof(ComId))]
        [InverseProperty(nameof(Company.ComPcrlinks))]
        public virtual Company Com { get; set; }
    }
}
