using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("COMPANY")]
    public partial class Company
    {
        public Company()
        {
            Calheadings = new HashSet<Calheading>();
            ComPcrlinks = new HashSet<ComPcrlink>();
            ComProcessLinks = new HashSet<ComProcessLink>();
            Comlinks = new HashSet<Comlink>();
            Comsws = new HashSet<Comsw>();
            Dcheadings = new HashSet<Dcheading>();
            EPackCertificates = new HashSet<EPackCertificate>();
            EPackHeadings = new HashSet<EPackHeading>();
            Epdanalyses = new HashSet<Epdanalysis>();
            Epdco2headings = new HashSet<Epdco2heading>();
            EpdcustomerLines = new HashSet<EpdcustomerLine>();
            EpdheadingDigis = new HashSet<EpdheadingDigi>();
            Epdheadings = new HashSet<Epdheading>();
            EpdprojectHeadings = new HashSet<EpdprojectHeading>();
            TransportExpHeaders = new HashSet<TransportExpHeader>();
        }

        [Key]
        [Column("COM_ID")]
        public long ComId { get; set; }
        [Column("COM_TYPE")]
        public int? ComType { get; set; }
        [Column("COM_COMPANYVAT")]
        [StringLength(20)]
        public string ComCompanyvat { get; set; }
        [Column("COM_COMPANYNAME")]
        [StringLength(100)]
        public string ComCompanyname { get; set; }
        [Column("COM_EMAIL")]
        [StringLength(100)]
        public string ComEmail { get; set; }
        [Column("COM_ADD")]
        [StringLength(100)]
        public string ComAdd { get; set; }
        [Column("COM_PROID")]
        [StringLength(5)]
        public string ComProid { get; set; }
        [Column("COM_ZIP")]
        [StringLength(10)]
        public string ComZip { get; set; }
        [Column("COM_CITY")]
        [StringLength(50)]
        public string ComCity { get; set; }
        [Column("COM_PHONE1")]
        [StringLength(20)]
        public string ComPhone1 { get; set; }
        [Column("COM_STATUS")]
        public bool? ComStatus { get; set; }
        [Column("COM_CREATEDTTM", TypeName = "datetime")]
        public DateTime? ComCreatedttm { get; set; }
        [Column("COM_CREATEDBY")]
        public long? ComCreatedby { get; set; }
        [Column("COM_EPDInfo1")]
        [StringLength(250)]
        public string ComEpdinfo1 { get; set; }
        [Column("COM_EPDInfo2")]
        [StringLength(250)]
        public string ComEpdinfo2 { get; set; }
        [Column("COM_EPDInfo3")]
        [StringLength(250)]
        public string ComEpdinfo3 { get; set; }
        [Column("COM_EPDInfo4")]
        [StringLength(250)]
        public string ComEpdinfo4 { get; set; }
        [Column("COM_EPDPicture1")]
        [StringLength(50)]
        public string ComEpdpicture1 { get; set; }
        [Column("COM_EPDPicture2")]
        [StringLength(50)]
        public string ComEpdpicture2 { get; set; }
        [Column("COM_Logo")]
        [StringLength(50)]
        public string ComLogo { get; set; }
        [Column("COM_Dir")]
        [StringLength(150)]
        public string ComDir { get; set; }
        [Column("COM_PageText")]
        [StringLength(3500)]
        public string ComPageText { get; set; }
        [Column("COM_BannerLogo")]
        [StringLength(150)]
        public string ComBannerLogo { get; set; }
        [Column("COM_MainContact")]
        [StringLength(150)]
        public string ComMainContact { get; set; }
        [Column("COM_ManagmentSys")]
        [StringLength(250)]
        public string ComManagmentSys { get; set; }
        [Column("COM_WEB")]
        [StringLength(150)]
        public string ComWeb { get; set; }
        [Column("COM_PHONE2")]
        [StringLength(20)]
        public string ComPhone2 { get; set; }
        [Column("COM_System")]
        public int? ComSystem { get; set; }
        [Column("COM_Startup")]
        [StringLength(250)]
        public string ComStartup { get; set; }
        [Column("COM_PaidTO", TypeName = "date")]
        public DateTime? ComPaidTo { get; set; }
        [Column("COM_GUID")]
        public Guid? ComGuid { get; set; }
        [Column("COM_Country")]
        public int? ComCountry { get; set; }
        [Column("COM_Token")]
        public string ComToken { get; set; }
        [Column("COM_Modul_SubFase")]
        public int? ComModulSubFase { get; set; }
        [Column("COM_Modul_Sharing")]
        public int? ComModulSharing { get; set; }
        [Column("COM_ProgramOperator")]
        public long? ComProgramOperator { get; set; }

        [InverseProperty(nameof(Calheading.Com))]
        public virtual ICollection<Calheading> Calheadings { get; set; }
        [InverseProperty(nameof(ComPcrlink.Com))]
        public virtual ICollection<ComPcrlink> ComPcrlinks { get; set; }
        [InverseProperty(nameof(ComProcessLink.Com))]
        public virtual ICollection<ComProcessLink> ComProcessLinks { get; set; }
        [InverseProperty(nameof(Comlink.Com))]
        public virtual ICollection<Comlink> Comlinks { get; set; }
        [InverseProperty(nameof(Comsw.Com))]
        public virtual ICollection<Comsw> Comsws { get; set; }
        [InverseProperty(nameof(Dcheading.Com))]
        public virtual ICollection<Dcheading> Dcheadings { get; set; }
        [InverseProperty(nameof(EPackCertificate.Com))]
        public virtual ICollection<EPackCertificate> EPackCertificates { get; set; }
        [InverseProperty(nameof(EPackHeading.Com))]
        public virtual ICollection<EPackHeading> EPackHeadings { get; set; }
        [InverseProperty(nameof(Epdanalysis.Com))]
        public virtual ICollection<Epdanalysis> Epdanalyses { get; set; }
        [InverseProperty(nameof(Epdco2heading.Com))]
        public virtual ICollection<Epdco2heading> Epdco2headings { get; set; }
        [InverseProperty(nameof(EpdcustomerLine.Com))]
        public virtual ICollection<EpdcustomerLine> EpdcustomerLines { get; set; }
        [InverseProperty(nameof(EpdheadingDigi.Com))]
        public virtual ICollection<EpdheadingDigi> EpdheadingDigis { get; set; }
        [InverseProperty(nameof(Epdheading.Com))]
        public virtual ICollection<Epdheading> Epdheadings { get; set; }
        [InverseProperty(nameof(EpdprojectHeading.Com))]
        public virtual ICollection<EpdprojectHeading> EpdprojectHeadings { get; set; }
        [InverseProperty(nameof(TransportExpHeader.Com))]
        public virtual ICollection<TransportExpHeader> TransportExpHeaders { get; set; }
    }
}
