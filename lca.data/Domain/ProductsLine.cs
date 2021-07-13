using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("ProductsLine")]
    public partial class ProductsLine
    {
        public ProductsLine()
        {
            PackMaterialListSelections = new HashSet<PackMaterialListSelection>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("HeadID")]
        public int? HeadId { get; set; }
        [Column("ProductID")]
        [StringLength(50)]
        public string ProductId { get; set; }
        [StringLength(250)]
        public string ProductName { get; set; }
        public int? ProductGroup { get; set; }
        public int? FpakDpak { get; set; }
        public int? DpakPall { get; set; }
        public double? NetWeight { get; set; }
        public double? SalesVolume { get; set; }
        public double? WasteVolume { get; set; }
        public double? WastePrecent { get; set; }
        [StringLength(500)]
        public string Comments { get; set; }
        public int? TransportGroup { get; set; }
        [Column("USR_ID")]
        public int? UsrId { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? NoFpakT { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? NoDpakT { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? NoPallT { get; set; }
        [Column("NS_EN")]
        public int? NsEn { get; set; }
        public bool? PartOfSelection { get; set; }

        [ForeignKey(nameof(HeadId))]
        [InverseProperty(nameof(EPackHeading.ProductsLines))]
        public virtual EPackHeading Head { get; set; }
        [InverseProperty(nameof(PackMaterialListSelection.ProductLine))]
        public virtual ICollection<PackMaterialListSelection> PackMaterialListSelections { get; set; }
    }
}
