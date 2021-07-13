using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("ePackHeading")]
    public partial class EPackHeading
    {
        public EPackHeading()
        {
            ProductsLines = new HashSet<ProductsLine>();
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

        [ForeignKey(nameof(ComId))]
        [InverseProperty(nameof(Company.EPackHeadings))]
        public virtual Company Com { get; set; }
        [InverseProperty(nameof(ProductsLine.Head))]
        public virtual ICollection<ProductsLine> ProductsLines { get; set; }
    }
}
