using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("DBBehandlingssted")]
    public partial class Dbbehandlingssted
    {
        [Key]
        [Column("BehandlingID")]
        public short BehandlingId { get; set; }
        [StringLength(50)]
        public string Behandlingssted { get; set; }
        [Column("CO2", TypeName = "decimal(8, 4)")]
        public decimal? Co2 { get; set; }
    }
}
