using System.Collections.Generic;
using LCA.Data.Context;
using LCA.Service.Models.filters;
using LCA.Services.Models;
using LCA.Service.Helpers;
using System.Linq;
using LCA.Service.Interface;

namespace LCA.Service.Implementation
{
    public class CompanyReadService: ICompanyReadService
    {
        readonly LcaDbContext _dbContext;

        public CompanyReadService(LcaDbContext dbContext)
        {
            this._dbContext = dbContext;
        }


        public IEnumerable<CompanyModel> Filter(BaseFilter testFilter)
        {
            var query = from company in _dbContext.Companies
                select new CompanyModel()
                {
                    ComId = company.ComId,
                    ComType = company.ComType,
                    ComCompanyvat = company.ComCompanyvat,
                    ComCompanyname = company.ComCompanyname,
                    ComEmail = company.ComEmail,
                    ComAdd = company.ComAdd,
                    ComProid = company.ComProid,
                    ComZip = company.ComZip,
                    ComCity = company.ComCity,
                    ComPhone1 = company.ComPhone1,
                    ComStatus = company.ComStatus,
                    ComCreatedttm = company.ComCreatedttm,
                    ComCreatedby = company.ComCreatedby,
                    ComEpdinfo1 = company.ComEpdinfo1,
                    ComEpdinfo2 = company.ComEpdinfo2,
                    ComEpdinfo3 = company.ComEpdinfo3,
                    ComEpdinfo4 = company.ComEpdinfo4,
                    ComEpdpicture1 = company.ComEpdpicture1,
                    ComEpdpicture2 = company.ComEpdpicture2,
                    ComLogo = company.ComLogo,
                    ComDir = company.ComDir,
                    ComPageText = company.ComPageText,
                    ComBannerLogo = company.ComBannerLogo,
                    ComMainContact = company.ComMainContact,
                    ComManagmentSys = company.ComManagmentSys,
                    ComWeb = company.ComWeb,
                    ComPhone2 = company.ComPhone2,
                    ComSystem = company.ComSystem,
                    ComStartup = company.ComStartup,
                    ComPaidTo = company.ComPaidTo,
                    ComGuid = company.ComGuid,
                    ComCountry = company.ComCountry,
                    ComToken = company.ComToken,
                    ComModulSubFase = company.ComModulSubFase,
                    ComModulSharing = company.ComModulSharing,
                    ComProgramOperator = company.ComProgramOperator,
                };
            string sqlStr = query.ApplyFilterToQueryString(testFilter);
            List<CompanyModel> Company = _dbContext.RawSqlQuery(sqlStr).ConvertDataTable<CompanyModel>();
            return Company;
        }
        
    }
    
    
    
}