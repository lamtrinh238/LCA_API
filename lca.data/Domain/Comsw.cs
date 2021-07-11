using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("COMSW")]
    public partial class Comsw
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("COM_ID")]
        public long ComId { get; set; }
        [Column("SW_type")]
        public int? SwType { get; set; }
        [Column("SW_ID")]
        public int? SwId { get; set; }

        [ForeignKey(nameof(ComId))]
        [InverseProperty(nameof(Company.Comsws))]
        public virtual Company Com { get; set; }
    }
}
