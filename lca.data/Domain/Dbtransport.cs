using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("DBTransport")]
    public partial class Dbtransport
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(50)]
        public string Transport { get; set; }
        [Column("AV_ID")]
        public long? AvId { get; set; }
        [Column("AV_NAVN")]
        [StringLength(50)]
        public string AvNavn { get; set; }
        public int? Ruter { get; set; }
        [Column("frekvens")]
        public long? Frekvens { get; set; }
        [Column("uten_last")]
        public long? UtenLast { get; set; }
        [Column("i_rute")]
        public long? IRute { get; set; }
        [Column("til_tomming")]
        public long? TilTomming { get; set; }
        [Column("AnalyseID")]
        public long? AnalyseId { get; set; }
        public long? Samlast { get; set; }
        [Column(TypeName = "decimal(20, 5)")]
        public decimal? Gjennomsnitt { get; set; }
        [Column("BehandlingID")]
        public short? BehandlingId { get; set; }
        [StringLength(150)]
        public string Sted { get; set; }
    }
}
