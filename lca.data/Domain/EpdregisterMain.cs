using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("EPDRegisterMain")]
    public partial class EpdregisterMain
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(150)]
        public string Name { get; set; }
        public int? Type { get; set; }
        [Column("COM_ID")]
        public int? ComId { get; set; }
        [StringLength(500)]
        public string Comments { get; set; }
        public int? Register { get; set; }
        public int? MenuFunction { get; set; }
        [StringLength(500)]
        public string Fase { get; set; }
        [StringLength(50)]
        public string Fase2 { get; set; }
    }
}
