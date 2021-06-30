using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class EpdmaterialsSima
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
        public int? SenA5 { get; set; }
        public int? SenB1 { get; set; }
        public int? SenB2b3 { get; set; }
        public int? SenC1c3c4 { get; set; }
        public int? SenC2 { get; set; }
        public int? SenD { get; set; }
        public decimal? FuelEnergy { get; set; }
        public decimal? LoadCap { get; set; }
        public int? SenA4 { get; set; }
        public int? SenB2 { get; set; }
        public decimal? PefGwp { get; set; }
        public decimal? PefOdp { get; set; }
        public decimal? PefHtnc { get; set; }
        public decimal? PefHtc { get; set; }
        public decimal? PefPm { get; set; }
        public decimal? PefIrhh { get; set; }
        public decimal? PefIre { get; set; }
        public decimal? PefPocp { get; set; }
        public decimal? PefAp { get; set; }
        public decimal? PefTep { get; set; }
        public decimal? PefFep { get; set; }
        public decimal? PefMep { get; set; }
        public decimal? PefEcotox { get; set; }
        public decimal? PefLanduse { get; set; }
        public decimal? PefWater { get; set; }
        public decimal? PefFosdep { get; set; }
        public int? SenB4b5 { get; set; }
        public int? SenB6b7 { get; set; }
        public decimal? UsedCap { get; set; }
        public decimal? Gwpiobc { get; set; }
        public decimal? Gwpbc { get; set; }
        public int? ReCycleId { get; set; }
    }
}
