using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("EPDAnalysisFases")]
    public partial class EpdanalysisFase
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("EPDHeadingID")]
        public int EpdheadingId { get; set; }
        [Column("EPDRecID")]
        public int EpdrecId { get; set; }
        [Column("EPDName")]
        [StringLength(500)]
        public string Epdname { get; set; }
        [Column("EPDQuantity", TypeName = "decimal(38, 12)")]
        public decimal? Epdquantity { get; set; }
        [StringLength(250)]
        public string Comments { get; set; }
        [Column("EPDUnit")]
        [StringLength(50)]
        public string Epdunit { get; set; }
        [Column("EPDFilling", TypeName = "decimal(18, 9)")]
        public decimal? Epdfilling { get; set; }
        [Column("EPDReuse", TypeName = "decimal(18, 9)")]
        public decimal? Epdreuse { get; set; }
        [Column("EPDReturn", TypeName = "decimal(18, 9)")]
        public decimal? Epdreturn { get; set; }
        [Column("EPDBit")]
        public int? Epdbit { get; set; }
        [Column("OldID")]
        public int? OldId { get; set; }
        [Column("type")]
        public int? Type { get; set; }
        [Column("Unit_calc", TypeName = "decimal(38, 12)")]
        public decimal? UnitCalc { get; set; }
        [Column("GWP", TypeName = "decimal(38, 12)")]
        public decimal? Gwp { get; set; }
        [Column("ODP", TypeName = "decimal(38, 12)")]
        public decimal? Odp { get; set; }
        [Column("AP", TypeName = "decimal(38, 12)")]
        public decimal? Ap { get; set; }
        [Column("EP", TypeName = "decimal(38, 12)")]
        public decimal? Ep { get; set; }
        [Column("POCP", TypeName = "decimal(38, 12)")]
        public decimal? Pocp { get; set; }
        [Column(TypeName = "decimal(38, 12)")]
        public decimal? Abiotic { get; set; }
        [Column("Abiotic_Fossil", TypeName = "decimal(38, 12)")]
        public decimal? AbioticFossil { get; set; }
        [Column(TypeName = "decimal(38, 12)")]
        public decimal? Extra { get; set; }
        [Column("RP_EnergyCarrier", TypeName = "decimal(38, 12)")]
        public decimal? RpEnergyCarrier { get; set; }
        [Column("RP_Material", TypeName = "decimal(38, 12)")]
        public decimal? RpMaterial { get; set; }
        [Column("SUM1", TypeName = "decimal(38, 12)")]
        public decimal? Sum1 { get; set; }
        [Column("NRP_EnergyCarrier", TypeName = "decimal(38, 12)")]
        public decimal? NrpEnergyCarrier { get; set; }
        [Column("NRP_Material", TypeName = "decimal(38, 12)")]
        public decimal? NrpMaterial { get; set; }
        [Column("SUM2", TypeName = "decimal(38, 12)")]
        public decimal? Sum2 { get; set; }
        [Column("Secondary_Materials", TypeName = "decimal(38, 12)")]
        public decimal? SecondaryMaterials { get; set; }
        [Column("RS_Fuels_Energy", TypeName = "decimal(38, 12)")]
        public decimal? RsFuelsEnergy { get; set; }
        [Column("NRS_Fuels", TypeName = "decimal(38, 12)")]
        public decimal? NrsFuels { get; set; }
        [Column("Net_Fresh_Water", TypeName = "decimal(38, 12)")]
        public decimal? NetFreshWater { get; set; }
        [Column("HW_Disposal", TypeName = "decimal(38, 12)")]
        public decimal? HwDisposal { get; set; }
        [Column("NHW_Disposal", TypeName = "decimal(38, 12)")]
        public decimal? NhwDisposal { get; set; }
        [Column("RW_Disposed", TypeName = "decimal(38, 12)")]
        public decimal? RwDisposed { get; set; }
        [Column("Com_Reuse", TypeName = "decimal(38, 12)")]
        public decimal? ComReuse { get; set; }
        [Column("Materials_Recycling", TypeName = "decimal(38, 12)")]
        public decimal? MaterialsRecycling { get; set; }
        [Column("ME_Recovery", TypeName = "decimal(38, 12)")]
        public decimal? MeRecovery { get; set; }
        [Column("Exported_Energy_EL", TypeName = "decimal(38, 12)")]
        public decimal? ExportedEnergyEl { get; set; }
        [Column("Exported_Energy_Heat", TypeName = "decimal(38, 12)")]
        public decimal? ExportedEnergyHeat { get; set; }
        [Column("GroupID")]
        public int? GroupId { get; set; }
        [Column("Unit_calcT", TypeName = "decimal(38, 12)")]
        public decimal? UnitCalcT { get; set; }
        public int? Fase { get; set; }
        [Column("EPDRefID")]
        public int? EpdrefId { get; set; }
        [Column("EPDRefName")]
        [StringLength(500)]
        public string EpdrefName { get; set; }
        public int? Sen { get; set; }
        public int? Level { get; set; }
        [Column("GWPIOBC", TypeName = "decimal(21, 12)")]
        public decimal? Gwpiobc { get; set; }
        [Column("GWPBC", TypeName = "decimal(21, 12)")]
        public decimal? Gwpbc { get; set; }
        [Column(TypeName = "decimal(21, 12)")]
        public decimal? ReCyclePer { get; set; }

        [ForeignKey(nameof(EpdheadingId))]
        [InverseProperty(nameof(EpdanalysisList.EpdanalysisFases))]
        public virtual EpdanalysisList Epdheading { get; set; }
    }
}
