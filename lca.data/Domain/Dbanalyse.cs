using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("DBAnalyse")]
    public partial class Dbanalyse
    {
        public Dbanalyse()
        {
            DbanalyseSites = new HashSet<DbanalyseSite>();
        }

        [Key]
        [Column("AnalyseID")]
        public long AnalyseId { get; set; }
        [StringLength(50)]
        public string Navn { get; set; }
        [StringLength(500)]
        public string Beskrivelse { get; set; }
        [StringLength(50)]
        public string Ansvarlig { get; set; }
        [StringLength(50)]
        public string Innlogget { get; set; }
        [Column("dato", TypeName = "datetime")]
        public DateTime? Dato { get; set; }
        [Column("status")]
        public short? Status { get; set; }
        [Column("UserID")]
        public long? UserId { get; set; }
        [Column("ComID")]
        public long? ComId { get; set; }

        [InverseProperty(nameof(DbanalyseSite.Analyse))]
        public virtual ICollection<DbanalyseSite> DbanalyseSites { get; set; }
    }
}
