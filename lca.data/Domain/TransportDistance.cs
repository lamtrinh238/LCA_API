using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("TransportDistance")]
    public partial class TransportDistance
    {
        [Key]
        [Column("TransportDistID")]
        public int TransportDistId { get; set; }
        [Column("TransportID")]
        public int? TransportId { get; set; }
        [Column("EPDMaterialsSIMAID")]
        public int? EpdmaterialsSimaid { get; set; }
        [StringLength(200)]
        public string TransportDistName { get; set; }
        [Column("TransportDistKM", TypeName = "numeric(18, 2)")]
        public decimal? TransportDistKm { get; set; }
        [StringLength(5000)]
        public string TransportDistComment { get; set; }
    }
}
