using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("DBBehandlingsmate")]
    public partial class Dbbehandlingsmate
    {
        [Key]
        [Column("BehandID")]
        public short BehandId { get; set; }
        [StringLength(50)]
        public string Behandling { get; set; }
        [Column("CO2", TypeName = "decimal(8, 4)")]
        public decimal? Co2 { get; set; }
    }
}
