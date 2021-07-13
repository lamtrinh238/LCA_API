using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("EPDDefaultA4")]
    public partial class EpddefaultA4
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("COM_ID")]
        public int ComId { get; set; }
        [Column("EPDA4ID")]
        public int Epda4id { get; set; }
        [Column("EPDA4km")]
        public int? Epda4km { get; set; }
        [Column("EPDA4Filling")]
        public int? Epda4filling { get; set; }
        [Column("EPDA4Return")]
        public int? Epda4return { get; set; }
        [Column("EPDA4Reuse")]
        public int? Epda4reuse { get; set; }
        [Column("EPDA4Name")]
        [StringLength(150)]
        public string Epda4name { get; set; }
        [StringLength(250)]
        public string Comments { get; set; }
        [Column("GroupID")]
        public int? GroupId { get; set; }
    }
}
