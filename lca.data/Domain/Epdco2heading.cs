﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("EPDCO2Heading")]
    public partial class Epdco2heading
    {
        public Epdco2heading()
        {
            Epdco2fases = new HashSet<Epdco2fase>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("EPDNumber")]
        [StringLength(50)]
        public string Epdnumber { get; set; }
        [Column("EPDName")]
        [StringLength(1000)]
        public string Epdname { get; set; }
        [Column("EPDDescription")]
        [StringLength(5000)]
        public string Epddescription { get; set; }
        [Column("EPDSpesification")]
        [StringLength(5000)]
        public string Epdspesification { get; set; }
        [Column("EPDTech")]
        [StringLength(5000)]
        public string Epdtech { get; set; }
        [Column("EPDMarket")]
        [StringLength(5000)]
        public string Epdmarket { get; set; }
        [Column("UserID")]
        public long? UserId { get; set; }
        [Column("EPDDate", TypeName = "date")]
        public DateTime? Epddate { get; set; }
        [Column("EPDApprovedDate", TypeName = "date")]
        public DateTime? EpdapprovedDate { get; set; }
        [Column("EPDexpirationDate", TypeName = "date")]
        public DateTime? EpdexpirationDate { get; set; }
        [Column("EPDEditor")]
        [StringLength(150)]
        public string Epdeditor { get; set; }
        [Column("EPDResponsible")]
        [StringLength(150)]
        public string Epdresponsible { get; set; }
        [Column("EPDStatus")]
        public int? Epdstatus { get; set; }
        [StringLength(5000)]
        public string Comments { get; set; }
        [Column("EPDPicturePath")]
        [StringLength(150)]
        public string EpdpicturePath { get; set; }
        [Column("EPDUnit")]
        [StringLength(50)]
        public string Epdunit { get; set; }
        [Column("EPDPicture2")]
        [StringLength(150)]
        public string Epdpicture2 { get; set; }
        [Column("EPDIntNum")]
        [StringLength(50)]
        public string EpdintNum { get; set; }
        [Column("EPDPCR")]
        [StringLength(250)]
        public string Epdpcr { get; set; }
        [Column("EPDProductionSite")]
        [StringLength(5000)]
        public string EpdproductionSite { get; set; }
        [Column("EPDYear")]
        public int? Epdyear { get; set; }
        [Column("EPDSysBound")]
        [StringLength(5000)]
        public string EpdsysBound { get; set; }
        [Column("EPDAllocation")]
        [StringLength(5000)]
        public string Epdallocation { get; set; }
        [Column("EPDDataQuality")]
        [StringLength(5000)]
        public string EpddataQuality { get; set; }
        [Column("EPDCutOff")]
        [StringLength(5000)]
        public string EpdcutOff { get; set; }
        [Column("EPDAddTech")]
        [StringLength(5000)]
        public string EpdaddTech { get; set; }
        [Column("EPDIndoorEnv")]
        [StringLength(5000)]
        public string EpdindoorEnv { get; set; }
        [Column("EPDBibllio")]
        [StringLength(5000)]
        public string Epdbibllio { get; set; }
        [Column("COM_ID")]
        public long? ComId { get; set; }
        [Column("EPDUnit_Calc", TypeName = "decimal(18, 4)")]
        public decimal? EpdunitCalc { get; set; }
        [StringLength(3)]
        public string A1 { get; set; }
        [StringLength(3)]
        public string A2 { get; set; }
        [StringLength(3)]
        public string A3 { get; set; }
        [StringLength(3)]
        public string A4 { get; set; }
        [StringLength(3)]
        public string A5 { get; set; }
        [StringLength(3)]
        public string B1 { get; set; }
        [StringLength(3)]
        public string B2 { get; set; }
        [StringLength(3)]
        public string B3 { get; set; }
        [StringLength(3)]
        public string B4 { get; set; }
        [StringLength(3)]
        public string B5 { get; set; }
        [StringLength(3)]
        public string B6 { get; set; }
        [StringLength(3)]
        public string B7 { get; set; }
        [StringLength(3)]
        public string C1 { get; set; }
        [StringLength(3)]
        public string C2 { get; set; }
        [StringLength(3)]
        public string C3 { get; set; }
        [StringLength(3)]
        public string C4 { get; set; }
        [StringLength(3)]
        public string D1 { get; set; }
        [Column("EPDLayout")]
        public int? Epdlayout { get; set; }
        [Column("EPDProductLife")]
        [StringLength(500)]
        public string EpdproductLife { get; set; }
        [Column("EPDBuildingLife")]
        [StringLength(500)]
        public string EpdbuildingLife { get; set; }
        [Column("GroupID")]
        public int? GroupId { get; set; }
        [Column("ProductionSiteID")]
        public int? ProductionSiteId { get; set; }
        [Column("EPDDangerous")]
        public int? Epddangerous { get; set; }
        [Column("EPDScenarios")]
        [StringLength(5000)]
        public string Epdscenarios { get; set; }
        [Column("GUID")]
        public Guid? Guid { get; set; }
        public int? Version { get; set; }
        [Column("EPDDefaultEPDID")]
        public int? EpddefaultEpdid { get; set; }
        [Column("EPDLanguage")]
        [StringLength(100)]
        public string Epdlanguage { get; set; }

        [ForeignKey(nameof(ComId))]
        [InverseProperty(nameof(Company.Epdco2headings))]
        public virtual Company Com { get; set; }
        [InverseProperty(nameof(Epdco2fase.Epdheading))]
        public virtual ICollection<Epdco2fase> Epdco2fases { get; set; }
    }
}
