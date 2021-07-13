using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("EPDMaterialsCEPE")]
    public partial class EpdmaterialsCepe
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("GroupID")]
        public int? GroupId { get; set; }
        [Column("CustomerID")]
        public int? CustomerId { get; set; }
        [Column("EPDMaterialID")]
        [StringLength(150)]
        public string EpdmaterialId { get; set; }
        [Column("EPDMaterialName")]
        [StringLength(250)]
        public string EpdmaterialName { get; set; }
        [Column("GWP", TypeName = "decimal(18, 9)")]
        public decimal? Gwp { get; set; }
        [Column("ODP", TypeName = "decimal(18, 9)")]
        public decimal? Odp { get; set; }
        [Column("AP", TypeName = "decimal(18, 9)")]
        public decimal? Ap { get; set; }
        [Column("EP", TypeName = "decimal(18, 9)")]
        public decimal? Ep { get; set; }
        [Column("POCP", TypeName = "decimal(18, 9)")]
        public decimal? Pocp { get; set; }
        [Column(TypeName = "decimal(18, 9)")]
        public decimal? Abiotic { get; set; }
        [Column("Abiotic_Fossil", TypeName = "decimal(18, 9)")]
        public decimal? AbioticFossil { get; set; }
        [Column(TypeName = "decimal(18, 9)")]
        public decimal? Extra { get; set; }
        [Column("RP_EnergyCarrier", TypeName = "decimal(18, 9)")]
        public decimal? RpEnergyCarrier { get; set; }
        [Column("RP_Material", TypeName = "decimal(18, 9)")]
        public decimal? RpMaterial { get; set; }
        [Column("SUM1", TypeName = "decimal(18, 9)")]
        public decimal? Sum1 { get; set; }
        [Column("NRP_EnergyCarrier", TypeName = "decimal(18, 9)")]
        public decimal? NrpEnergyCarrier { get; set; }
        [Column("NRP_Material", TypeName = "decimal(18, 9)")]
        public decimal? NrpMaterial { get; set; }
        [Column("SUM2", TypeName = "decimal(18, 9)")]
        public decimal? Sum2 { get; set; }
        [Column("Secondary_Materials", TypeName = "decimal(18, 9)")]
        public decimal? SecondaryMaterials { get; set; }
        [Column("RS_Fuels_Energy", TypeName = "decimal(18, 9)")]
        public decimal? RsFuelsEnergy { get; set; }
        [Column("NRS_Fuels", TypeName = "decimal(18, 9)")]
        public decimal? NrsFuels { get; set; }
        [Column("Net_Fresh_Water", TypeName = "decimal(18, 9)")]
        public decimal? NetFreshWater { get; set; }
        [Column("HW_Disposal", TypeName = "decimal(18, 9)")]
        public decimal? HwDisposal { get; set; }
        [Column("NHW_Disposal", TypeName = "decimal(18, 9)")]
        public decimal? NhwDisposal { get; set; }
        [Column("RW_Disposed", TypeName = "decimal(18, 9)")]
        public decimal? RwDisposed { get; set; }
        [Column("Com_Reuse", TypeName = "decimal(18, 9)")]
        public decimal? ComReuse { get; set; }
        [Column("Materials_Recycling", TypeName = "decimal(18, 9)")]
        public decimal? MaterialsRecycling { get; set; }
        [Column("ME_Recovery", TypeName = "decimal(18, 9)")]
        public decimal? MeRecovery { get; set; }
        [Column("Exported_Energy_EL", TypeName = "decimal(18, 9)")]
        public decimal? ExportedEnergyEl { get; set; }
        [Column("Exported_Energy_Heat", TypeName = "decimal(18, 9)")]
        public decimal? ExportedEnergyHeat { get; set; }
        public int? Version { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }
        [Column("UserID")]
        public int? UserId { get; set; }
        [Column("MaterialGroupID")]
        public int? MaterialGroupId { get; set; }
        [Column("type")]
        public int? Type { get; set; }
        [Column("unit")]
        [StringLength(50)]
        public string Unit { get; set; }
        [StringLength(700)]
        public string HelpText { get; set; }
        [Column("Internal_Comments")]
        [StringLength(500)]
        public string InternalComments { get; set; }
        [Column("F_E_consumption", TypeName = "decimal(18, 9)")]
        public decimal? FEConsumption { get; set; }
        [Column("F_E_Unit")]
        [StringLength(50)]
        public string FEUnit { get; set; }
        [Column("Unit_calc", TypeName = "decimal(18, 4)")]
        public decimal? UnitCalc { get; set; }
        [Column("Year_study")]
        public int? YearStudy { get; set; }
        [StringLength(250)]
        public string DataQuality { get; set; }
        [StringLength(250)]
        public string DataSource { get; set; }
        public int? A1 { get; set; }
        public int? A2 { get; set; }
        public int? A3 { get; set; }
        public int? A4 { get; set; }
        public int? A5 { get; set; }
        public int? B1 { get; set; }
        public int? B2 { get; set; }
        public int? B3 { get; set; }
        public int? B4 { get; set; }
        public int? B5 { get; set; }
        public int? B6 { get; set; }
        public int? B7 { get; set; }
        public int? C1 { get; set; }
        public int? C2 { get; set; }
        public int? C3 { get; set; }
        public int? C4 { get; set; }
        public int? D1 { get; set; }
        [Column("Sen_A5")]
        public int? SenA5 { get; set; }
        [Column("Sen_B1")]
        public int? SenB1 { get; set; }
        [Column("Sen_B2B3")]
        public int? SenB2b3 { get; set; }
        [Column("Sen_C1C3C4")]
        public int? SenC1c3c4 { get; set; }
        [Column("Sen_C2")]
        public int? SenC2 { get; set; }
        [Column("Sen_D")]
        public int? SenD { get; set; }
        [Column("Fuel_Energy", TypeName = "decimal(18, 4)")]
        public decimal? FuelEnergy { get; set; }
        [Column("Load_Cap", TypeName = "decimal(18, 4)")]
        public decimal? LoadCap { get; set; }
        [Column("Sen_A4")]
        public int? SenA4 { get; set; }
        [Column("PEF_GWP", TypeName = "decimal(18, 9)")]
        public decimal? PefGwp { get; set; }
        [Column("PEF_ODP", TypeName = "decimal(18, 9)")]
        public decimal? PefOdp { get; set; }
        [Column("PEF_HTNC", TypeName = "decimal(18, 9)")]
        public decimal? PefHtnc { get; set; }
        [Column("PEF_HTC", TypeName = "decimal(18, 9)")]
        public decimal? PefHtc { get; set; }
        [Column("PEF_PM", TypeName = "decimal(18, 9)")]
        public decimal? PefPm { get; set; }
        [Column("PEF_IRHH", TypeName = "decimal(18, 9)")]
        public decimal? PefIrhh { get; set; }
        [Column("PEF_IRE", TypeName = "decimal(18, 9)")]
        public decimal? PefIre { get; set; }
        [Column("PEF_POCP", TypeName = "decimal(18, 9)")]
        public decimal? PefPocp { get; set; }
        [Column("PEF_AP", TypeName = "decimal(18, 9)")]
        public decimal? PefAp { get; set; }
        [Column("PEF_TEP", TypeName = "decimal(18, 9)")]
        public decimal? PefTep { get; set; }
        [Column("PEF_FEP", TypeName = "decimal(18, 9)")]
        public decimal? PefFep { get; set; }
        [Column("PEF_MEP", TypeName = "decimal(18, 9)")]
        public decimal? PefMep { get; set; }
        [Column("PEF_ECOTOX", TypeName = "decimal(18, 9)")]
        public decimal? PefEcotox { get; set; }
        [Column("PEF_LANDUSE", TypeName = "decimal(18, 9)")]
        public decimal? PefLanduse { get; set; }
        [Column("PEF_WATER", TypeName = "decimal(18, 9)")]
        public decimal? PefWater { get; set; }
        [Column("PEF_FOSDEP", TypeName = "decimal(18, 9)")]
        public decimal? PefFosdep { get; set; }
        [Column("Sen_B2")]
        public int? SenB2 { get; set; }
    }
}
