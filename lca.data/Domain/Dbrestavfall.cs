using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("DBRestavfall")]
    public partial class Dbrestavfall
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("RestavfallsID")]
        public short? RestavfallsId { get; set; }
        [StringLength(50)]
        public string Restavfallsnavn { get; set; }
        [Column("BehandlingsstedID")]
        public short? BehandlingsstedId { get; set; }
        [StringLength(50)]
        public string Behandlingssted { get; set; }
        [Column("BehandlingsmateID")]
        public short? BehandlingsmateId { get; set; }
        [StringLength(50)]
        public string Behandlingsmate { get; set; }
        [Column(TypeName = "numeric(10, 4)")]
        public decimal? Avfallsbehandling { get; set; }
        [Column("Erstattet_energi", TypeName = "numeric(10, 4)")]
        public decimal? ErstattetEnergi { get; set; }
        [Column("dato_sist_endret", TypeName = "date")]
        public DateTime? DatoSistEndret { get; set; }
        [Column("userID")]
        [StringLength(50)]
        public string UserId { get; set; }
    }
}
