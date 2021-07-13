using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("DCRecipients")]
    public partial class Dcrecipient
    {
        public Dcrecipient()
        {
            Dcanswers = new HashSet<Dcanswer>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("DCHeadingID")]
        public int DcheadingId { get; set; }
        [StringLength(100)]
        public string Recipients { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastChange { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FinishedDate { get; set; }
        public int? Status { get; set; }
        [StringLength(500)]
        public string Message { get; set; }
        [StringLength(500)]
        public string Comments { get; set; }
        [Column("email")]
        [StringLength(100)]
        public string Email { get; set; }
        [Column("USR_ID")]
        public long? UsrId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastMailDate { get; set; }

        [ForeignKey(nameof(DcheadingId))]
        [InverseProperty("Dcrecipients")]
        public virtual Dcheading Dcheading { get; set; }
        [InverseProperty(nameof(Dcanswer.Dcrecip))]
        public virtual ICollection<Dcanswer> Dcanswers { get; set; }
    }
}
