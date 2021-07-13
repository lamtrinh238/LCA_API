using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("EPDHeading")]
    public partial class Epdheading
    {
        public Epdheading()
        {
            EpddangerousNavigation = new HashSet<Epddangerou>();
            EpddataSetDocumentationRegistrations = new HashSet<EpddataSetDocumentationRegistration>();
            Epdlinks = new HashSet<Epdlink>();
            EpdregistrationA1s = new HashSet<EpdregistrationA1>();
            EpdregistrationA3s = new HashSet<EpdregistrationA3>();
            EpdregistrationA4s = new HashSet<EpdregistrationA4>();
            EpdregistrationA5s = new HashSet<EpdregistrationA5>();
            EpdregistrationB1s = new HashSet<EpdregistrationB1>();
            EpdregistrationB2s = new HashSet<EpdregistrationB2>();
            EpdregistrationB3s = new HashSet<EpdregistrationB3>();
            EpdregistrationB4s = new HashSet<EpdregistrationB4>();
            EpdregistrationB5s = new HashSet<EpdregistrationB5>();
            EpdregistrationB6s = new HashSet<EpdregistrationB6>();
            EpdregistrationB7s = new HashSet<EpdregistrationB7>();
            EpdregistrationC1s = new HashSet<EpdregistrationC1>();
            EpdregistrationC2s = new HashSet<EpdregistrationC2>();
            EpdregistrationC3s = new HashSet<EpdregistrationC3>();
            EpdregistrationC4s = new HashSet<EpdregistrationC4>();
            EpdregistrationD1s = new HashSet<EpdregistrationD1>();
            EpdregistrationFases = new HashSet<EpdregistrationFase>();
            Epdshares = new HashSet<Epdshare>();
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
        [Column(TypeName = "datetime")]
        public DateTime? LastUpdate { get; set; }
        [Column("NO_Edit")]
        public int? NoEdit { get; set; }
        [Column("EPDSubType")]
        public int? EpdsubType { get; set; }
        [Column("EPDPCR_ID")]
        public int? EpdpcrId { get; set; }
        [Column("ProductFlowDatasetID")]
        public Guid? ProductFlowDatasetId { get; set; }
        [Column("PDFSourceDatasetID")]
        public Guid? PdfsourceDatasetId { get; set; }
        [Column("EPDComOnEnvImp")]
        [StringLength(5000)]
        public string EpdcomOnEnvImp { get; set; }
        [Column("EPDFuncUnitDesc")]
        [StringLength(5000)]
        public string EpdfuncUnitDesc { get; set; }
        [Column("ManufacturerID")]
        public int? ManufacturerId { get; set; }

        [ForeignKey(nameof(ComId))]
        [InverseProperty(nameof(Company.Epdheadings))]
        public virtual Company Com { get; set; }
        [InverseProperty(nameof(Epddangerou.Epdheading))]
        public virtual ICollection<Epddangerou> EpddangerousNavigation { get; set; }
        [InverseProperty(nameof(EpddataSetDocumentationRegistration.Epdheading))]
        public virtual ICollection<EpddataSetDocumentationRegistration> EpddataSetDocumentationRegistrations { get; set; }
        [InverseProperty(nameof(Epdlink.Epdheading))]
        public virtual ICollection<Epdlink> Epdlinks { get; set; }
        [InverseProperty(nameof(EpdregistrationA1.Epdheading))]
        public virtual ICollection<EpdregistrationA1> EpdregistrationA1s { get; set; }
        [InverseProperty(nameof(EpdregistrationA3.Epdheading))]
        public virtual ICollection<EpdregistrationA3> EpdregistrationA3s { get; set; }
        [InverseProperty(nameof(EpdregistrationA4.Epdheading))]
        public virtual ICollection<EpdregistrationA4> EpdregistrationA4s { get; set; }
        [InverseProperty(nameof(EpdregistrationA5.Epdheading))]
        public virtual ICollection<EpdregistrationA5> EpdregistrationA5s { get; set; }
        [InverseProperty(nameof(EpdregistrationB1.Epdheading))]
        public virtual ICollection<EpdregistrationB1> EpdregistrationB1s { get; set; }
        [InverseProperty(nameof(EpdregistrationB2.Epdheading))]
        public virtual ICollection<EpdregistrationB2> EpdregistrationB2s { get; set; }
        [InverseProperty(nameof(EpdregistrationB3.Epdheading))]
        public virtual ICollection<EpdregistrationB3> EpdregistrationB3s { get; set; }
        [InverseProperty(nameof(EpdregistrationB4.Epdheading))]
        public virtual ICollection<EpdregistrationB4> EpdregistrationB4s { get; set; }
        [InverseProperty(nameof(EpdregistrationB5.Epdheading))]
        public virtual ICollection<EpdregistrationB5> EpdregistrationB5s { get; set; }
        [InverseProperty(nameof(EpdregistrationB6.Epdheading))]
        public virtual ICollection<EpdregistrationB6> EpdregistrationB6s { get; set; }
        [InverseProperty(nameof(EpdregistrationB7.Epdheading))]
        public virtual ICollection<EpdregistrationB7> EpdregistrationB7s { get; set; }
        [InverseProperty(nameof(EpdregistrationC1.Epdheading))]
        public virtual ICollection<EpdregistrationC1> EpdregistrationC1s { get; set; }
        [InverseProperty(nameof(EpdregistrationC2.Epdheading))]
        public virtual ICollection<EpdregistrationC2> EpdregistrationC2s { get; set; }
        [InverseProperty(nameof(EpdregistrationC3.Epdheading))]
        public virtual ICollection<EpdregistrationC3> EpdregistrationC3s { get; set; }
        [InverseProperty(nameof(EpdregistrationC4.Epdheading))]
        public virtual ICollection<EpdregistrationC4> EpdregistrationC4s { get; set; }
        [InverseProperty(nameof(EpdregistrationD1.Epdheading))]
        public virtual ICollection<EpdregistrationD1> EpdregistrationD1s { get; set; }
        [InverseProperty(nameof(EpdregistrationFase.Epdheading))]
        public virtual ICollection<EpdregistrationFase> EpdregistrationFases { get; set; }
        [InverseProperty(nameof(Epdshare.Epdheading))]
        public virtual ICollection<Epdshare> Epdshares { get; set; }
    }
}
