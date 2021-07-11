using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("EPDDangerous")]
    public partial class Epddangerou
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("EPDHeadingID")]
        public int EpdheadingId { get; set; }
        [StringLength(500)]
        public string Name { get; set; }
        [Column("CASNo")]
        [StringLength(150)]
        public string Casno { get; set; }
        [StringLength(150)]
        public string Among { get; set; }

        [ForeignKey(nameof(EpdheadingId))]
        [InverseProperty("EpddangerousNavigation")]
        public virtual Epdheading Epdheading { get; set; }
    }
}
