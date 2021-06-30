using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class Co2materialsSima
    {
        public int Id { get; set; }
        public int? GroupId { get; set; }
        public int? CustomerId { get; set; }
        public string EpdmaterialId { get; set; }
        public string EpdmaterialName { get; set; }
        public decimal? Gwp { get; set; }
        public decimal? Odp { get; set; }
        public decimal? Ap { get; set; }
        public decimal? Ep { get; set; }
        public decimal? Pocp { get; set; }
        public decimal? Abiotic { get; set; }
        public decimal? AbioticFossil { get; set; }
        public decimal? Extra { get; set; }
        public decimal? RpEnergyCarrier { get; set; }
        public decimal? RpMaterial { get; set; }
        public decimal? Sum1 { get; set; }
        public decimal? NrpEnergyCarrier { get; set; }
        public decimal? NrpMaterial { get; set; }
        public decimal? Sum2 { get; set; }
        public decimal? SecondaryMaterials { get; set; }
        public decimal? RsFuelsEnergy { get; set; }
        public decimal? NrsFuels { get; set; }
        public decimal? NetFreshWater { get; set; }
        public decimal? HwDisposal { get; set; }
        public decimal? NhwDisposal { get; set; }
        public decimal? RwDisposed { get; set; }
        public decimal? ComReuse { get; set; }
        public decimal? MaterialsRecycling { get; set; }
        public decimal? MeRecovery { get; set; }
        public decimal? ExportedEnergyEl { get; set; }
        public decimal? ExportedEnergyHeat { get; set; }
        public int? Version { get; set; }
        public DateTime? Date { get; set; }
        public int? UserId { get; set; }
        public int? MaterialGroupId { get; set; }
        public int? Type { get; set; }
        public string Unit { get; set; }
        public string HelpText { get; set; }
        public string InternalComments { get; set; }
        public decimal? FEConsumption { get; set; }
        public string FEUnit { get; set; }
        public decimal? UnitCalc { get; set; }
        public int? YearStudy { get; set; }
        public string DataQuality { get; set; }
        public string DataSource { get; set; }
        public int? Scope1 { get; set; }
        public int? Scope2 { get; set; }
        public int? Scope31 { get; set; }
        public int? Scope32 { get; set; }
        public int? Scope33 { get; set; }
        public int? Scope34 { get; set; }
        public int? Scope35 { get; set; }
        public int? Scope36 { get; set; }
        public int? Scope37 { get; set; }
        public int? Scope38 { get; set; }
        public int? Scope39 { get; set; }
        public int? Scope310 { get; set; }
        public int? Scope311 { get; set; }
        public int? Scope312 { get; set; }
        public int? Scope313 { get; set; }
        public int? Scope314 { get; set; }
        public int? Scope315 { get; set; }
        public decimal? FuelEnergy { get; set; }
        public decimal? LoadCap { get; set; }
        public decimal? UsedCap { get; set; }
        public decimal? Gwpiobc { get; set; }
        public decimal? Gwpbc { get; set; }
        public int? ReCycleId { get; set; }
    }
}
