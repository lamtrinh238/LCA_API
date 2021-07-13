using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("DBPlukkHead")]
    public partial class DbplukkHead
    {
        public DbplukkHead()
        {
            Dbplukklistes = new HashSet<Dbplukkliste>();
        }

        [Key]
        [Column("PlukkID")]
        public long PlukkId { get; set; }
        [StringLength(50)]
        public string Navn { get; set; }
        [StringLength(250)]
        public string Beskrivelse { get; set; }
        [StringLength(50)]
        public string Ansvarlig { get; set; }
        [StringLength(50)]
        public string Innlogget { get; set; }
        [Column("dato", TypeName = "date")]
        public DateTime? Dato { get; set; }
        [Column("status")]
        public short? Status { get; set; }
        [Column("UserID")]
        public long? UserId { get; set; }

        [InverseProperty(nameof(Dbplukkliste.Plukk))]
        public virtual ICollection<Dbplukkliste> Dbplukklistes { get; set; }
    }
}
