using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("DCAnswer")]
    public partial class Dcanswer
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("DCRecipID")]
        public int? DcrecipId { get; set; }
        [Column("DCAnswerLine")]
        public int? DcanswerLine { get; set; }
        [Column("DCAnswer1")]
        [StringLength(500)]
        public string Dcanswer1 { get; set; }
        [Column("DCAnswer2")]
        [StringLength(500)]
        public string Dcanswer2 { get; set; }
        [Column("DCAnswer3")]
        [StringLength(500)]
        public string Dcanswer3 { get; set; }
        [Column("DCAnswer4")]
        [StringLength(2500)]
        public string Dcanswer4 { get; set; }
        [Column("DCAnswer5")]
        [StringLength(500)]
        public string Dcanswer5 { get; set; }

        [ForeignKey(nameof(DcrecipId))]
        [InverseProperty(nameof(Dcrecipient.Dcanswers))]
        public virtual Dcrecipient Dcrecip { get; set; }
    }
}
