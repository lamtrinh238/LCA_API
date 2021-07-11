using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("TransportExpHeader")]
    public partial class TransportExpHeader
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("Com_ID")]
        public long? ComId { get; set; }
        [Column("User_ID")]
        public int? UserId { get; set; }
        [StringLength(500)]
        public string Transportname { get; set; }
        [Column("comments")]
        [StringLength(5000)]
        public string Comments { get; set; }

        [ForeignKey(nameof(ComId))]
        [InverseProperty(nameof(Company.TransportExpHeaders))]
        public virtual Company Com { get; set; }
    }
}
