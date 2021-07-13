using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("EPDDefaultA2")]
    public partial class EpddefaultA2
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("COM_ID")]
        public int ComId { get; set; }
        [Column("EPDA2ID")]
        public int Epda2id { get; set; }
        [Column("EPDA2km")]
        public int? Epda2km { get; set; }
        [Column("EPDA2Filling")]
        public int? Epda2filling { get; set; }
        [Column("EPDA2Return")]
        public int? Epda2return { get; set; }
        [Column("EPDA2Reuse")]
        public int? Epda2reuse { get; set; }
        [Column("EPDA2Name")]
        [StringLength(150)]
        public string Epda2name { get; set; }
        [StringLength(250)]
        public string Comments { get; set; }
        [Column("GroupID")]
        public int? GroupId { get; set; }
    }
}
