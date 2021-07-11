using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("EPDMaterialList")]
    public partial class EpdmaterialList
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("EPDHeadingID")]
        public int EpdheadingId { get; set; }
        [StringLength(500)]
        public string Name { get; set; }
        [StringLength(150)]
        public string Range { get; set; }
        [Column("fase")]
        public int? Fase { get; set; }
        [StringLength(50)]
        public string Unit { get; set; }
        [StringLength(150)]
        public string Value { get; set; }
    }
}
