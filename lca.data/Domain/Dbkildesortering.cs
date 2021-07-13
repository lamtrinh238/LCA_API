using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("DBKildesortering")]
    public partial class Dbkildesortering
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("AvfallsID")]
        public short? AvfallsId { get; set; }
        [StringLength(50)]
        public string Avfallsnavn { get; set; }
        [Column("BehandlingsstedID")]
        public short? BehandlingsstedId { get; set; }
        [StringLength(50)]
        public string Behandlingssted { get; set; }
        [Column("BehandlingsmateID")]
        public short? BehandlingsmateId { get; set; }
        [StringLength(50)]
        public string Behandlingsmate { get; set; }
        [Column("Trans_uten_last", TypeName = "decimal(10, 4)")]
        public decimal? TransUtenLast { get; set; }
        [Column("Trans_rute", TypeName = "decimal(10, 4)")]
        public decimal? TransRute { get; set; }
        [Column("Trans_sted", TypeName = "decimal(10, 4)")]
        public decimal? TransSted { get; set; }
        [Column(TypeName = "decimal(10, 4)")]
        public decimal? Transport2 { get; set; }
        [Column(TypeName = "decimal(10, 4)")]
        public decimal? Transport3 { get; set; }
        [Column(TypeName = "decimal(10, 4)")]
        public decimal? Avfallbehandling { get; set; }
        [Column("Erstattet_energi", TypeName = "decimal(10, 4)")]
        public decimal? ErstattetEnergi { get; set; }
        [Column("dato_sist_endret", TypeName = "date")]
        public DateTime? DatoSistEndret { get; set; }
        [Column("userID")]
        [StringLength(50)]
        public string UserId { get; set; }
    }
}
