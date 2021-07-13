using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("CO2MaterialsSIMA")]
    public partial class Co2materialsSima
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
        [Column("GWP", TypeName = "decimal(22, 12)")]
        public decimal? Gwp { get; set; }
        [Column("ODP", TypeName = "decimal(22, 12)")]
        public decimal? Odp { get; set; }
        [Column("AP", TypeName = "decimal(22, 12)")]
        public decimal? Ap { get; set; }
        [Column("EP", TypeName = "decimal(22, 12)")]
        public decimal? Ep { get; set; }
        [Column("POCP", TypeName = "decimal(22, 12)")]
        public decimal? Pocp { get; set; }
        [Column(TypeName = "decimal(22, 12)")]
        public decimal? Abiotic { get; set; }
        [Column("Abiotic_Fossil", TypeName = "decimal(22, 12)")]
        public decimal? AbioticFossil { get; set; }
        [Column(TypeName = "decimal(22, 12)")]
        public decimal? Extra { get; set; }
        [Column("RP_EnergyCarrier", TypeName = "decimal(22, 12)")]
        public decimal? RpEnergyCarrier { get; set; }
        [Column("RP_Material", TypeName = "decimal(22, 12)")]
        public decimal? RpMaterial { get; set; }
        [Column("SUM1", TypeName = "decimal(22, 12)")]
        public decimal? Sum1 { get; set; }
        [Column("NRP_EnergyCarrier", TypeName = "decimal(22, 12)")]
        public decimal? NrpEnergyCarrier { get; set; }
        [Column("NRP_Material", TypeName = "decimal(22, 12)")]
        public decimal? NrpMaterial { get; set; }
        [Column("SUM2", TypeName = "decimal(22, 12)")]
        public decimal? Sum2 { get; set; }
        [Column("Secondary_Materials", TypeName = "decimal(22, 12)")]
        public decimal? SecondaryMaterials { get; set; }
        [Column("RS_Fuels_Energy", TypeName = "decimal(22, 12)")]
        public decimal? RsFuelsEnergy { get; set; }
        [Column("NRS_Fuels", TypeName = "decimal(22, 12)")]
        public decimal? NrsFuels { get; set; }
        [Column("Net_Fresh_Water", TypeName = "decimal(22, 12)")]
        public decimal? NetFreshWater { get; set; }
        [Column("HW_Disposal", TypeName = "decimal(22, 12)")]
        public decimal? HwDisposal { get; set; }
        [Column("NHW_Disposal", TypeName = "decimal(22, 12)")]
        public decimal? NhwDisposal { get; set; }
        [Column("RW_Disposed", TypeName = "decimal(22, 12)")]
        public decimal? RwDisposed { get; set; }
        [Column("Com_Reuse", TypeName = "decimal(22, 12)")]
        public decimal? ComReuse { get; set; }
        [Column("Materials_Recycling", TypeName = "decimal(22, 12)")]
        public decimal? MaterialsRecycling { get; set; }
        [Column("ME_Recovery", TypeName = "decimal(22, 12)")]
        public decimal? MeRecovery { get; set; }
        [Column("Exported_Energy_EL", TypeName = "decimal(22, 12)")]
        public decimal? ExportedEnergyEl { get; set; }
        [Column("Exported_Energy_Heat", TypeName = "decimal(22, 12)")]
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
        public int? Scope1 { get; set; }
        public int? Scope2 { get; set; }
        [Column("Scope3_1")]
        public int? Scope31 { get; set; }
        [Column("Scope3_2")]
        public int? Scope32 { get; set; }
        [Column("Scope3_3")]
        public int? Scope33 { get; set; }
        [Column("Scope3_4")]
        public int? Scope34 { get; set; }
        [Column("Scope3_5")]
        public int? Scope35 { get; set; }
        [Column("Scope3_6")]
        public int? Scope36 { get; set; }
        [Column("Scope3_7")]
        public int? Scope37 { get; set; }
        [Column("Scope3_8")]
        public int? Scope38 { get; set; }
        [Column("Scope3_9")]
        public int? Scope39 { get; set; }
        [Column("Scope3_10")]
        public int? Scope310 { get; set; }
        [Column("Scope3_11")]
        public int? Scope311 { get; set; }
        [Column("Scope3_12")]
        public int? Scope312 { get; set; }
        [Column("Scope3_13")]
        public int? Scope313 { get; set; }
        [Column("Scope3_14")]
        public int? Scope314 { get; set; }
        [Column("Scope3_15")]
        public int? Scope315 { get; set; }
        [Column("Fuel_Energy", TypeName = "decimal(18, 4)")]
        public decimal? FuelEnergy { get; set; }
        [Column("Load_Cap", TypeName = "decimal(18, 4)")]
        public decimal? LoadCap { get; set; }
        [Column("Used_cap", TypeName = "decimal(18, 3)")]
        public decimal? UsedCap { get; set; }
        [Column("GWPIOBC", TypeName = "decimal(22, 12)")]
        public decimal? Gwpiobc { get; set; }
        [Column("GWPBC", TypeName = "decimal(22, 12)")]
        public decimal? Gwpbc { get; set; }
        [Column("ReCycleID")]
        public int? ReCycleId { get; set; }
    }
}
