using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("COMLinks")]
    public partial class Comlink
    {
        [Key]
        [Column("ID")]
        public long Id { get; set; }
        [Column("COM_ID")]
        public long ComId { get; set; }
        [Column("LINK_ID")]
        public long LinkId { get; set; }
        public int? Type { get; set; }

        [ForeignKey(nameof(ComId))]
        [InverseProperty(nameof(Company.Comlinks))]
        public virtual Company Com { get; set; }
    }
}
