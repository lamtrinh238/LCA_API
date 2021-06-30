using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
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

        public int Id { get; set; }
        public string Epdnumber { get; set; }
        public string Epdname { get; set; }
        public string Epddescription { get; set; }
        public string Epdspesification { get; set; }
        public string Epdtech { get; set; }
        public string Epdmarket { get; set; }
        public long? UserId { get; set; }
        public DateTime? Epddate { get; set; }
        public DateTime? EpdapprovedDate { get; set; }
        public DateTime? EpdexpirationDate { get; set; }
        public string Epdeditor { get; set; }
        public string Epdresponsible { get; set; }
        public int? Epdstatus { get; set; }
        public string Comments { get; set; }
        public string EpdpicturePath { get; set; }
        public string Epdunit { get; set; }
        public string Epdpicture2 { get; set; }
        public string EpdintNum { get; set; }
        public string Epdpcr { get; set; }
        public string EpdproductionSite { get; set; }
        public int? Epdyear { get; set; }
        public string EpdsysBound { get; set; }
        public string Epdallocation { get; set; }
        public string EpddataQuality { get; set; }
        public string EpdcutOff { get; set; }
        public string EpdaddTech { get; set; }
        public string EpdindoorEnv { get; set; }
        public string Epdbibllio { get; set; }
        public long? ComId { get; set; }
        public decimal? EpdunitCalc { get; set; }
        public string A1 { get; set; }
        public string A2 { get; set; }
        public string A3 { get; set; }
        public string A4 { get; set; }
        public string A5 { get; set; }
        public string B1 { get; set; }
        public string B2 { get; set; }
        public string B3 { get; set; }
        public string B4 { get; set; }
        public string B5 { get; set; }
        public string B6 { get; set; }
        public string B7 { get; set; }
        public string C1 { get; set; }
        public string C2 { get; set; }
        public string C3 { get; set; }
        public string C4 { get; set; }
        public string D1 { get; set; }
        public int? Epdlayout { get; set; }
        public string EpdproductLife { get; set; }
        public string EpdbuildingLife { get; set; }
        public int? GroupId { get; set; }
        public int? ProductionSiteId { get; set; }
        public int? Epddangerous { get; set; }
        public string Epdscenarios { get; set; }
        public Guid? Guid { get; set; }
        public int? Version { get; set; }
        public int? EpddefaultEpdid { get; set; }
        public string Epdlanguage { get; set; }
        public DateTime? LastUpdate { get; set; }
        public int? NoEdit { get; set; }
        public int? EpdsubType { get; set; }
        public int? EpdpcrId { get; set; }
        public Guid? ProductFlowDatasetId { get; set; }
        public Guid? PdfsourceDatasetId { get; set; }
        public string EpdcomOnEnvImp { get; set; }
        public string EpdfuncUnitDesc { get; set; }
        public int? ManufacturerId { get; set; }

        public virtual Company Com { get; set; }
        public virtual ICollection<Epddangerou> EpddangerousNavigation { get; set; }
        public virtual ICollection<EpddataSetDocumentationRegistration> EpddataSetDocumentationRegistrations { get; set; }
        public virtual ICollection<Epdlink> Epdlinks { get; set; }
        public virtual ICollection<EpdregistrationA1> EpdregistrationA1s { get; set; }
        public virtual ICollection<EpdregistrationA3> EpdregistrationA3s { get; set; }
        public virtual ICollection<EpdregistrationA4> EpdregistrationA4s { get; set; }
        public virtual ICollection<EpdregistrationA5> EpdregistrationA5s { get; set; }
        public virtual ICollection<EpdregistrationB1> EpdregistrationB1s { get; set; }
        public virtual ICollection<EpdregistrationB2> EpdregistrationB2s { get; set; }
        public virtual ICollection<EpdregistrationB3> EpdregistrationB3s { get; set; }
        public virtual ICollection<EpdregistrationB4> EpdregistrationB4s { get; set; }
        public virtual ICollection<EpdregistrationB5> EpdregistrationB5s { get; set; }
        public virtual ICollection<EpdregistrationB6> EpdregistrationB6s { get; set; }
        public virtual ICollection<EpdregistrationB7> EpdregistrationB7s { get; set; }
        public virtual ICollection<EpdregistrationC1> EpdregistrationC1s { get; set; }
        public virtual ICollection<EpdregistrationC2> EpdregistrationC2s { get; set; }
        public virtual ICollection<EpdregistrationC3> EpdregistrationC3s { get; set; }
        public virtual ICollection<EpdregistrationC4> EpdregistrationC4s { get; set; }
        public virtual ICollection<EpdregistrationD1> EpdregistrationD1s { get; set; }
        public virtual ICollection<EpdregistrationFase> EpdregistrationFases { get; set; }
        public virtual ICollection<Epdshare> Epdshares { get; set; }
    }
}
