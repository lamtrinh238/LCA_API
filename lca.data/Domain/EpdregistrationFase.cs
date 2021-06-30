using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class EpdregistrationFase
    {
        public int Id { get; set; }
        public int EpdheadingId { get; set; }
        public int EpdrecId { get; set; }
        public string Epdname { get; set; }
        public decimal? Epdquantity { get; set; }
        public string Comments { get; set; }
        public string Epdunit { get; set; }
        public decimal? Epdfilling { get; set; }
        public decimal? Epdreuse { get; set; }
        public decimal? Epdreturn { get; set; }
        public int? Epdbit { get; set; }
        public int? OldId { get; set; }
        public int? Type { get; set; }
        public decimal? UnitCalc { get; set; }
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
        public int? GroupId { get; set; }
        public decimal? UnitCalcT { get; set; }
        public int? Fase { get; set; }
        public int? EpdrefId { get; set; }
        public string EpdrefName { get; set; }
        public int? Sen { get; set; }
        public int? Level { get; set; }
        public decimal? Gwpiobc { get; set; }
        public decimal? Gwpbc { get; set; }
        public decimal? ReCyclePer { get; set; }
        public DateTime? LastUpdate { get; set; }
        public decimal? WastagePer { get; set; }

        public virtual Epdheading Epdheading { get; set; }
    }
}
