using LCA.Data.Context;
using LCA.Service.Helpers;
using LCA.Service.Interface;
using LCA.Service.Models.filters;
using LCA.Services.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace LCA.Services.Implementation
{
    public class ClientService : IClientService
    {
        private readonly LcaDbContext _dbContext;
        public ClientService(LcaDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public IEnumerable<ClientModel> Filter(BaseFilter testFilter)
        {
            var query = from com in _dbContext.Companies
                       join ctr in _dbContext.Countries on com.ComCountry equals ctr.Int
                       join sw in _dbContext.Comsws on com.ComId equals sw.ComId
                        select new ClientModel() {
                            ComId = com.ComId,
                            ComType = com.ComType,
                            ComCompanyvat = com.ComCompanyvat,
                            ComCompanyname = com.ComCompanyname,
                            ComEmail = com.ComEmail,
                            ComAdd = com.ComAdd,
                            ComProid = com.ComProid,
                            ComZip = com.ComZip,
                            ComCity = com.ComCity,
                            ComPhone1 = com.ComPhone1,
                            ComStatus = com.ComStatus,
                            ComCreatedttm = com.ComCreatedttm,
                            ComCreatedby = com.ComCreatedby,
                            ComEpdinfo1 = com.ComEpdinfo1,
                            ComEpdinfo2 = com.ComEpdinfo2,
                            ComEpdinfo3 = com.ComEpdinfo3,
                            ComEpdinfo4 = com.ComEpdinfo4,
                            ComEpdpicture1 = com.ComEpdpicture1,
                            ComEpdpicture2 = com.ComEpdpicture2,
                            ComLogo = com.ComLogo,
                            ComDir = com.ComDir,
                            ComPageText = com.ComPageText,
                            ComBannerLogo = com.ComBannerLogo,
                            ComMainContact = com.ComMainContact,
                            ComManagmentSys = com.ComManagmentSys,
                            ComWeb = com.ComWeb,
                            ComPhone2 = com.ComPhone2,
                            ComSystem = com.ComSystem,
                            ComStartup = com.ComStartup,
                            ComPaidTo = com.ComPaidTo,
                            ComGuid = com.ComGuid,
                            ComCountry = com.ComCountry,
                            ComToken = com.ComToken,
                            ComModulSubFase = com.ComModulSubFase,
                            ComModulSharing = com.ComModulSharing,
                            ComProgramOperator = com.ComProgramOperator,
                            CountryName = ctr.CountryName,
                            ComSW = sw.SwId
                    };
            string sqlStr = query.ApplyFilterToQueryString(testFilter);
            List<ClientModel> clients = _dbContext.RawSqlQuery(sqlStr).ConvertDataTable<ClientModel>();
            return clients;
        }

    }
}
