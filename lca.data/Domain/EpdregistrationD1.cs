using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class EpdregistrationD1
    {
        public int Id { get; set; }
        public int EpdheadingId { get; set; }
        public int Epdd1id { get; set; }
        public string Epdd1name { get; set; }
        public decimal? Epdd1quantity { get; set; }
        public string Comments { get; set; }
        public string Epdd1unit { get; set; }
        public decimal? UnitCalc { get; set; }
        public int? Type { get; set; }
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
        public int? SenD1 { get; set; }
        public decimal? UnitCalcT { get; set; }

        public virtual Epdheading Epdheading { get; set; }
    }
}
