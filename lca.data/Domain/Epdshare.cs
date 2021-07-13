using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("EPDShare")]
    public partial class Epdshare
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("EPDHeadingID")]
        public int? EpdheadingId { get; set; }
        [Column("COMID")]
        public int? Comid { get; set; }
        [Column("type")]
        public int? Type { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        [StringLength(10)]
        public string Status { get; set; }
        [StringLength(30)]
        public string Contact { get; set; }
        [Column("Full_Single_Share")]
        public int? FullSingleShare { get; set; }

        [ForeignKey(nameof(EpdheadingId))]
        [InverseProperty("Epdshares")]
        public virtual Epdheading Epdheading { get; set; }
    }
}
