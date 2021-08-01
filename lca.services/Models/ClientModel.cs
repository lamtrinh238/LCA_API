using LCA.Data.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LCA.Services.Models
{
    public class ClientModel
    {
        public ClientModel()
        {
        }

        public ClientModel(Company company, Country coutry)
        {
            ComId = company.ComId;
            ComType = company.ComType;
            ComCompanyvat = company.ComCompanyvat;
            ComCompanyname = company.ComCompanyname;
            ComEmail = company.ComEmail;
            ComAdd = company.ComAdd;
            ComProid = company.ComProid;
            ComZip = company.ComZip;
            ComCity = company.ComCity;
            ComPhone1 = company.ComPhone1;
            ComStatus = company.ComStatus;
            ComCreatedttm = company.ComCreatedttm;
            ComCreatedby = company.ComCreatedby;
            ComEpdinfo1 = company.ComEpdinfo1;
            ComEpdinfo2 = company.ComEpdinfo2;
            ComEpdinfo3 = company.ComEpdinfo3;
            ComEpdinfo4 = company.ComEpdinfo4;
            ComEpdpicture1 = company.ComEpdpicture1;
            ComEpdpicture2 = company.ComEpdpicture2;
            ComLogo = company.ComLogo;
            ComDir = company.ComDir;
            ComPageText = company.ComPageText;
            ComBannerLogo = company.ComBannerLogo;
            ComMainContact = company.ComMainContact;
            ComManagmentSys = company.ComManagmentSys;
            ComWeb = company.ComWeb;
            ComPhone2 = company.ComPhone2;
            ComSystem = company.ComSystem;
            ComStartup = company.ComStartup;
            ComPaidTo = company.ComPaidTo;
            ComGuid = company.ComGuid;
            ComCountry = company.ComCountry;
            ComToken = company.ComToken;
            ComModulSubFase = company.ComModulSubFase;
            ComModulSharing = company.ComModulSharing;
            ComProgramOperator = company.ComProgramOperator;
            CountryName = coutry.CountryName;
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
        public string CountryName { get; set; }
        public int? ComSW { get; set; }
    }



    public class ClientGeneralModel : ClientModel
    {
        public ClientGeneralModel(
            Company company,
            Country coutry,
            ICollection<ComSWCom> comsws,
            ICollection<ComPCRLinkCom> comPCRLink) : base(company, coutry)
        {
            this.Comsws = comsws;
            this.ComPCRLink = comPCRLink;
        }
        public ICollection<ComSWCom> Comsws { get; set; }
        public ICollection<ComPCRLinkCom> ComPCRLink { get; set; }
    }

    public class ComSWCom
    {
        public ComSWCom(Comsw comsw)
        {
            this.Id = comsw.Id;
            this.SwType = comsw.SwType;
            this.SwId = comsw.SwId;
        }
        public int Id { get; set; }
        public int? SwType { get; set; }
        public int? SwId { get; set; }
    }

    public class ComPCRLinkCom
    {
        public ComPCRLinkCom(ComPcrlink comPcrlink)
        {
            this.Id = comPcrlink.Id;
            this.PcrId = comPcrlink.PcrId;
        }
        public int Id { get; set; }
        public int? PcrId { get; set; }
    }

    public class ClientUpdateModel : ClientModel
    {
        public ClientUpdateModel()
        {
        }

        public ClientUpdateModel(Company company) : base(company, null)
        {
        }

        public int[] ComSws { get; set; }
        public int[] ComPcrs { get; set; }
    }

    public class CompanyLinkModel
    {
        public CompanyLinkModel() { }
        public CompanyLinkModel(Comlink comlink)
        {
            this.ComId = comlink.ComId;
            this.LinkId = comlink.LinkId;
            this.Type = comlink.Type;

        }

        public long Id { get; set; }
        public long ComId { get; set; }
        public long LinkId { get; set; }
        public int? Type { get; set; }
    }
}
