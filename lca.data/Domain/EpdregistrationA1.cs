using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class EpdregistrationA1
    {
        public EpdregistrationA1()
        {
            EpdregistrationA2s = new HashSet<EpdregistrationA2>();
        }

        public int Id { get; set; }
        public int EpdheadingId { get; set; }
        public int Epda1id { get; set; }
        public string Epda1name { get; set; }
        public decimal? Epda1quantity { get; set; }
        public string Comments { get; set; }
        public string Epda1unit { get; set; }
        public int? OldA1id { get; set; }
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

        public virtual Epdheading Epdheading { get; set; }
        public virtual ICollection<EpdregistrationA2> EpdregistrationA2s { get; set; }
    }
}
