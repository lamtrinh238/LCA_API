using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("DBPlukkliste")]
    public partial class Dbplukkliste
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("PlukkID")]
        public long PlukkId { get; set; }
        [Column("AV_ID")]
        public short? AvId { get; set; }
        [Column("AV_NAVN")]
        [StringLength(50)]
        public string AvNavn { get; set; }
        [Column("prosent", TypeName = "decimal(5, 2)")]
        public decimal? Prosent { get; set; }

        [ForeignKey(nameof(PlukkId))]
        [InverseProperty(nameof(DbplukkHead.Dbplukklistes))]
        public virtual DbplukkHead Plukk { get; set; }
    }
}
