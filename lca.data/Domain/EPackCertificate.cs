using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("ePackCertificate")]
    public partial class EPackCertificate
    {
        public EPackCertificate()
        {
            EPackCertificateLines = new HashSet<EPackCertificateLine>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(500)]
        public string Name { get; set; }
        [StringLength(500)]
        public string Comments { get; set; }
        [Column("COM_ID")]
        public long? ComId { get; set; }
        public int? Status { get; set; }
        [Column("Time_Created", TypeName = "datetime")]
        public DateTime? TimeCreated { get; set; }
        [Column("Time_LastChange", TypeName = "datetime")]
        public DateTime? TimeLastChange { get; set; }

        [ForeignKey(nameof(ComId))]
        [InverseProperty(nameof(Company.EPackCertificates))]
        public virtual Company Com { get; set; }
        [InverseProperty(nameof(EPackCertificateLine.Certificate))]
        public virtual ICollection<EPackCertificateLine> EPackCertificateLines { get; set; }
    }
}
