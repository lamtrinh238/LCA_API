using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Keyless]
    public partial class EpdcalculationB5bak
    {
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(150)]
        public string Name { get; set; }
        [Column("GWP", TypeName = "decimal(38, 6)")]
        public decimal? Gwp { get; set; }
        [Column("ODP", TypeName = "decimal(38, 6)")]
        public decimal? Odp { get; set; }
        [Column("AP", TypeName = "decimal(38, 6)")]
        public decimal? Ap { get; set; }
        [Column("EP", TypeName = "decimal(38, 6)")]
        public decimal? Ep { get; set; }
        [Column("POCP", TypeName = "decimal(38, 6)")]
        public decimal? Pocp { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? Abiotic { get; set; }
        [Column("Abiotic_Fossil", TypeName = "decimal(38, 6)")]
        public decimal? AbioticFossil { get; set; }
        [Column("RP_EnergyCarrier", TypeName = "decimal(38, 6)")]
        public decimal? RpEnergyCarrier { get; set; }
        [Column("RP_Material", TypeName = "decimal(38, 6)")]
        public decimal? RpMaterial { get; set; }
        [Column("SUM1", TypeName = "decimal(38, 6)")]
        public decimal? Sum1 { get; set; }
        [Column("NRP_EnergyCarrier", TypeName = "decimal(38, 6)")]
        public decimal? NrpEnergyCarrier { get; set; }
        [Column("NRP_Material", TypeName = "decimal(38, 6)")]
        public decimal? NrpMaterial { get; set; }
        [Column("SUM2", TypeName = "decimal(38, 6)")]
        public decimal? Sum2 { get; set; }
        [Column("Secondary_Materials", TypeName = "decimal(38, 6)")]
        public decimal? SecondaryMaterials { get; set; }
        [Column("RS_Fuels_Energy", TypeName = "decimal(38, 6)")]
        public decimal? RsFuelsEnergy { get; set; }
        [Column("NRS_Fuels", TypeName = "decimal(38, 6)")]
        public decimal? NrsFuels { get; set; }
        [Column("Net_Fresh_Water", TypeName = "decimal(38, 6)")]
        public decimal? NetFreshWater { get; set; }
        [Column("HW_Disposal", TypeName = "decimal(38, 6)")]
        public decimal? HwDisposal { get; set; }
        [Column("NHW_Disposal", TypeName = "decimal(38, 6)")]
        public decimal? NhwDisposal { get; set; }
        [Column("RW_Disposed", TypeName = "decimal(38, 6)")]
        public decimal? RwDisposed { get; set; }
        [Column("Com_Reuse", TypeName = "decimal(38, 6)")]
        public decimal? ComReuse { get; set; }
        [Column("Materials_Recycling", TypeName = "decimal(38, 6)")]
        public decimal? MaterialsRecycling { get; set; }
        [Column("ME_Recovery", TypeName = "decimal(38, 6)")]
        public decimal? MeRecovery { get; set; }
        [Column("Exported_Energy_EL", TypeName = "decimal(38, 6)")]
        public decimal? ExportedEnergyEl { get; set; }
        [Column("Exported_Energy_Heat", TypeName = "decimal(38, 6)")]
        public decimal? ExportedEnergyHeat { get; set; }
        [Column(TypeName = "decimal(18, 9)")]
        public decimal? Quantity { get; set; }
        [StringLength(50)]
        public string Unit { get; set; }
        [Column("Sen_B4B5")]
        public int? SenB4b5 { get; set; }
    }
}
