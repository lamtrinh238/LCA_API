using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("EPDMaterialsSIMASubProcess")]
    public partial class EpdmaterialsSimasubProcess
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("MainID")]
        public int? MainId { get; set; }
        [Column("SubID")]
        public int? SubId { get; set; }
        [Column("COM_ID")]
        public int? ComId { get; set; }
        [StringLength(10)]
        public string Fase { get; set; }
        [Column(TypeName = "decimal(18, 9)")]
        public decimal? Value { get; set; }
    }
}
