using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("TransportHead")]
    public partial class TransportHead
    {
        [Key]
        [Column("TransportID")]
        public int TransportId { get; set; }
        [StringLength(200)]
        public string TransportName { get; set; }
        [StringLength(5000)]
        public string TransportComments { get; set; }
    }
}
