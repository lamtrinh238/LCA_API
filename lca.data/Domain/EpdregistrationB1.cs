using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("EPDRegistrationB1")]
    public partial class EpdregistrationB1
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("EPDHeadingID")]
        public int EpdheadingId { get; set; }
        [Column("EPDB1ID")]
        public int Epdb1id { get; set; }
        [Column("EPDB1Name")]
        [StringLength(150)]
        public string Epdb1name { get; set; }
        [Column("EPDB1Quantity", TypeName = "decimal(18, 9)")]
        public decimal? Epdb1quantity { get; set; }
        [StringLength(250)]
        public string Comments { get; set; }
        [Column("EPDB1Unit")]
        [StringLength(50)]
        public string Epdb1unit { get; set; }
        [Column("Unit_calc", TypeName = "decimal(18, 9)")]
        public decimal? UnitCalc { get; set; }
        [Column("type")]
        public int? Type { get; set; }
        [Column("GWP", TypeName = "decimal(21, 12)")]
        public decimal? Gwp { get; set; }
        [Column("ODP", TypeName = "decimal(21, 12)")]
        public decimal? Odp { get; set; }
        [Column("AP", TypeName = "decimal(21, 12)")]
        public decimal? Ap { get; set; }
        [Column("EP", TypeName = "decimal(21, 12)")]
        public decimal? Ep { get; set; }
        [Column("POCP", TypeName = "decimal(21, 12)")]
        public decimal? Pocp { get; set; }
        [Column(TypeName = "decimal(21, 12)")]
        public decimal? Abiotic { get; set; }
        [Column("Abiotic_Fossil", TypeName = "decimal(21, 12)")]
        public decimal? AbioticFossil { get; set; }
        [Column(TypeName = "decimal(21, 12)")]
        public decimal? Extra { get; set; }
        [Column("RP_EnergyCarrier", TypeName = "decimal(21, 12)")]
        public decimal? RpEnergyCarrier { get; set; }
        [Column("RP_Material", TypeName = "decimal(21, 12)")]
        public decimal? RpMaterial { get; set; }
        [Column("SUM1", TypeName = "decimal(21, 12)")]
        public decimal? Sum1 { get; set; }
        [Column("NRP_EnergyCarrier", TypeName = "decimal(21, 12)")]
        public decimal? NrpEnergyCarrier { get; set; }
        [Column("NRP_Material", TypeName = "decimal(21, 12)")]
        public decimal? NrpMaterial { get; set; }
        [Column("SUM2", TypeName = "decimal(21, 12)")]
        public decimal? Sum2 { get; set; }
        [Column("Secondary_Materials", TypeName = "decimal(21, 12)")]
        public decimal? SecondaryMaterials { get; set; }
        [Column("RS_Fuels_Energy", TypeName = "decimal(21, 12)")]
        public decimal? RsFuelsEnergy { get; set; }
        [Column("NRS_Fuels", TypeName = "decimal(21, 12)")]
        public decimal? NrsFuels { get; set; }
        [Column("Net_Fresh_Water", TypeName = "decimal(21, 12)")]
        public decimal? NetFreshWater { get; set; }
        [Column("HW_Disposal", TypeName = "decimal(21, 12)")]
        public decimal? HwDisposal { get; set; }
        [Column("NHW_Disposal", TypeName = "decimal(21, 12)")]
        public decimal? NhwDisposal { get; set; }
        [Column("RW_Disposed", TypeName = "decimal(21, 12)")]
        public decimal? RwDisposed { get; set; }
        [Column("Com_Reuse", TypeName = "decimal(21, 12)")]
        public decimal? ComReuse { get; set; }
        [Column("Materials_Recycling", TypeName = "decimal(21, 12)")]
        public decimal? MaterialsRecycling { get; set; }
        [Column("ME_Recovery", TypeName = "decimal(21, 12)")]
        public decimal? MeRecovery { get; set; }
        [Column("Exported_Energy_EL", TypeName = "decimal(21, 12)")]
        public decimal? ExportedEnergyEl { get; set; }
        [Column("Exported_Energy_Heat", TypeName = "decimal(21, 12)")]
        public decimal? ExportedEnergyHeat { get; set; }
        [Column("Sen_B1")]
        public int? SenB1 { get; set; }
        [Column("Unit_calcT", TypeName = "decimal(21, 12)")]
        public decimal? UnitCalcT { get; set; }

        [ForeignKey(nameof(EpdheadingId))]
        [InverseProperty("EpdregistrationB1s")]
        public virtual Epdheading Epdheading { get; set; }
    }
}
