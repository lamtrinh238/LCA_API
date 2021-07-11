using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("ePackCertificateLine")]
    public partial class EPackCertificateLine
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("PackTypeID")]
        public int? PackTypeId { get; set; }
        [Column("CertificateID")]
        public int? CertificateId { get; set; }
        [StringLength(500)]
        public string Comments { get; set; }
        [Column("HelpTXT")]
        [StringLength(500)]
        public string HelpTxt { get; set; }
        [Column("DeclarationID")]
        public int? DeclarationId { get; set; }

        [ForeignKey(nameof(CertificateId))]
        [InverseProperty(nameof(EPackCertificate.EPackCertificateLines))]
        public virtual EPackCertificate Certificate { get; set; }
    }
}
