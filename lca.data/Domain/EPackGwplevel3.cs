using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Keyless]
    public partial class EPackGwplevel3
    {
        [Column("COM_ID")]
        public long? ComId { get; set; }
        [Column("HeadID")]
        public int? HeadId { get; set; }
        [StringLength(500)]
        public string Name { get; set; }
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(250)]
        public string ProductName { get; set; }
        [StringLength(250)]
        public string ProductGroupName { get; set; }
        public double? SalesVolume { get; set; }
        [Required]
        [Column("GWPName")]
        [StringLength(14)]
        public string Gwpname { get; set; }
        [Required]
        [Column("F_E_Unit")]
        [StringLength(6)]
        public string FEUnit { get; set; }
        [Column("GWP")]
        public double? Gwp { get; set; }
    }
}
