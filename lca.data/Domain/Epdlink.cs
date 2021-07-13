using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("EPDLinks")]
    public partial class Epdlink
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("EPDHeadingID")]
        public int? EpdheadingId { get; set; }
        [Column("EPD_ID")]
        public int? EpdId { get; set; }
        [Column("type")]
        public int? Type { get; set; }

        [ForeignKey(nameof(EpdheadingId))]
        [InverseProperty("Epdlinks")]
        public virtual Epdheading Epdheading { get; set; }
    }
}
