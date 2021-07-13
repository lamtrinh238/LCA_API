using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("PackElementer")]
    public partial class PackElementer
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("ProductID")]
        public int? ProductId { get; set; }
        [Column("PETypeID")]
        public int? PetypeId { get; set; }
        [Column("PEMatID")]
        public int? PematId { get; set; }
        [Column("PENettovekt")]
        public double? Penettovekt { get; set; }
    }
}
