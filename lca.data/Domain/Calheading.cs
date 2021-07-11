using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("CALHeading")]
    public partial class Calheading
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("CALStatus")]
        public int? Calstatus { get; set; }
        [Column("CALName")]
        [StringLength(1000)]
        public string Calname { get; set; }
        [Column("CALDate", TypeName = "date")]
        public DateTime? Caldate { get; set; }
        [Column("CALquantity", TypeName = "decimal(18, 0)")]
        public decimal? Calquantity { get; set; }
        [Column("CALdistance", TypeName = "decimal(18, 0)")]
        public decimal? Caldistance { get; set; }
        [Column("CALbiogass")]
        public int? Calbiogass { get; set; }
        [Column("CALbiorest")]
        public int? Calbiorest { get; set; }
        [Column("CALstorage")]
        public int? Calstorage { get; set; }
        [Column("CALbiopig", TypeName = "decimal(18, 0)")]
        public decimal? Calbiopig { get; set; }
        [Column("CALbiomeet", TypeName = "decimal(18, 0)")]
        public decimal? Calbiomeet { get; set; }
        [Column("CALreference")]
        public int? Calreference { get; set; }
        [Column("CALburnrate")]
        public int? Calburnrate { get; set; }
        [Column("CALdistance2", TypeName = "decimal(18, 0)")]
        public decimal? Caldistance2 { get; set; }
        [Column("UserID")]
        public long? UserId { get; set; }
        [StringLength(5000)]
        public string Comments { get; set; }
        [Column("COM_ID")]
        public long? ComId { get; set; }
        [StringLength(50)]
        public string CalBiogassTxt { get; set; }
        [StringLength(50)]
        public string CalBiorestTxt { get; set; }
        [StringLength(50)]
        public string CalstorageTxt { get; set; }
        [StringLength(50)]
        public string CalreferenceTxt { get; set; }
        [StringLength(50)]
        public string CalburnrateTxt { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? Caldistance3 { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? Caldistance4 { get; set; }

        [ForeignKey(nameof(ComId))]
        [InverseProperty(nameof(Company.Calheadings))]
        public virtual Company Com { get; set; }
    }
}
