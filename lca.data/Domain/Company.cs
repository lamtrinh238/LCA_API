using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
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

        public long ComId { get; set; }
        public int? ComType { get; set; }
        public string ComCompanyvat { get; set; }
        public string ComCompanyname { get; set; }
        public string ComEmail { get; set; }
        public string ComAdd { get; set; }
        public string ComProid { get; set; }
        public string ComZip { get; set; }
        public string ComCity { get; set; }
        public string ComPhone1 { get; set; }
        public bool? ComStatus { get; set; }
        public DateTime? ComCreatedttm { get; set; }
        public long? ComCreatedby { get; set; }
        public string ComEpdinfo1 { get; set; }
        public string ComEpdinfo2 { get; set; }
        public string ComEpdinfo3 { get; set; }
        public string ComEpdinfo4 { get; set; }
        public string ComEpdpicture1 { get; set; }
        public string ComEpdpicture2 { get; set; }
        public string ComLogo { get; set; }
        public string ComDir { get; set; }
        public string ComPageText { get; set; }
        public string ComBannerLogo { get; set; }
        public string ComMainContact { get; set; }
        public string ComManagmentSys { get; set; }
        public string ComWeb { get; set; }
        public string ComPhone2 { get; set; }
        public int? ComSystem { get; set; }
        public string ComStartup { get; set; }
        public DateTime? ComPaidTo { get; set; }
        public Guid? ComGuid { get; set; }
        public int? ComCountry { get; set; }
        public string ComToken { get; set; }
        public int? ComModulSubFase { get; set; }
        public int? ComModulSharing { get; set; }
        public long? ComProgramOperator { get; set; }

        public virtual ICollection<Calheading> Calheadings { get; set; }
        public virtual ICollection<ComPcrlink> ComPcrlinks { get; set; }
        public virtual ICollection<ComProcessLink> ComProcessLinks { get; set; }
        public virtual ICollection<Comlink> Comlinks { get; set; }
        public virtual ICollection<Comsw> Comsws { get; set; }
        public virtual ICollection<Dcheading> Dcheadings { get; set; }
        public virtual ICollection<EPackCertificate> EPackCertificates { get; set; }
        public virtual ICollection<EPackHeading> EPackHeadings { get; set; }
        public virtual ICollection<Epdanalysis> Epdanalyses { get; set; }
        public virtual ICollection<Epdco2heading> Epdco2headings { get; set; }
        public virtual ICollection<EpdcustomerLine> EpdcustomerLines { get; set; }
        public virtual ICollection<EpdheadingDigi> EpdheadingDigis { get; set; }
        public virtual ICollection<Epdheading> Epdheadings { get; set; }
        public virtual ICollection<EpdprojectHeading> EpdprojectHeadings { get; set; }
        public virtual ICollection<TransportExpHeader> TransportExpHeaders { get; set; }
    }
}
