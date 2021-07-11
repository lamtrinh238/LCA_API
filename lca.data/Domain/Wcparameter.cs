using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Keyless]
    [Table("WCParameter")]
    public partial class Wcparameter
    {
        [StringLength(100)]
        public string Sector { get; set; }
        [Column("Waste_precent", TypeName = "decimal(18, 8)")]
        public decimal? WastePrecent { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? Revenue { get; set; }
        [Column("Waste_Tonne", TypeName = "decimal(28, 16)")]
        public decimal? WasteTonne { get; set; }
        [Column("Calc_Key_num", TypeName = "decimal(28, 16)")]
        public decimal? CalcKeyNum { get; set; }
        [Column(TypeName = "decimal(28, 16)")]
        public decimal? Cost { get; set; }
        [Column("CO2", TypeName = "decimal(28, 16)")]
        public decimal? Co2 { get; set; }
    }
}
