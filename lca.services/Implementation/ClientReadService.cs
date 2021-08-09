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
    public class ClientReadService : IClientReadService
    {
        private readonly LcaDbContext _dbContext;
        public ClientReadService(LcaDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public ClientGeneralModel GetClientByID(int clientID)
        {
            var sws = from sw in _dbContext.Comsws
                      where sw.ComId == clientID
                      select new ComSWCom(sw);

            var prcLinks = from prc in _dbContext.ComPcrlinks
                           where prc.ComId == clientID
                           select new ComPCRLinkCom(prc);

            var client = from com in _dbContext.Companies
                         join ctr in _dbContext.Countries on com.ComCountry equals ctr.Int
                         where com.ComId == clientID
                         select new ClientGeneralModel(com, ctr, sws.ToHashSet(), prcLinks.ToHashSet());

            return client.FirstOrDefault();
        }

        public IEnumerable<ClientModel> Filter(ClientFilter filter)
        {
            var query = this._dbContext.Companies.Select(client => client);

            if (filter.ID != null)
            {
                query = query.Where(client => client.ComId == filter.ID);
            }

            if (filter.VAT != null)
            {
                query = query.Where(client => client.ComCompanyvat.Contains(filter.VAT));
            }

            if (filter.Name != null)
            {
                query = query.Where(client => client.ComCompanyname.Contains(filter.Name));
            }

            if (filter.Email != null)
            {
                query = query.Where(client => client.ComEmail.Contains(filter.Email));
            }

            if (filter.Address != null)
            {
                query = query.Where(client => client.ComAdd.Contains(filter.Address));
            }

            if (filter.Zip != null)
            {
                query = query.Where(client => client.ComZip.Contains(filter.Zip));
            }

            if (filter.City != null)
            {
                query = query.Where(client => client.ComCity.Contains(filter.City));
            }

            if (filter.Phone != null)
            {
                query = query.Where(client => client.ComPhone1.Contains(filter.Phone));
            }

            if (filter.MainContact != null)
            {
                query = query.Where(client => client.ComMainContact.Contains(filter.MainContact));
            }

            if (filter.WEB != null)
            {
                query = query.Where(client => client.ComWeb.Contains(filter.WEB));
            }

            if (filter.Coutry != null)
            {
                query = query.Where(client => client.ComCountry == filter.Coutry);
            }

            if (filter.Search != null)
            {
                query = query.Where(client =>
                EF.Functions.Like(client.ComId.ToString(), "%" + filter.Search + "%")
                || EF.Functions.Like(client.ComCompanyvat, "%" + filter.Search + "%")
                || EF.Functions.Like(client.ComCompanyname, "%" + filter.Search + "%")
                || EF.Functions.Like(client.ComEmail, "%" + filter.Search + "%")
                || EF.Functions.Like(client.ComAdd, "%" + filter.Search + "%")
                || EF.Functions.Like(client.ComZip, "%" + filter.Search + "%")
                || EF.Functions.Like(client.ComCity, "%" + filter.Search + "%")
                || EF.Functions.Like(client.ComPhone1, "%" + filter.Search + "%")
                || EF.Functions.Like(client.ComMainContact, "%" + filter.Search + "%")
                || EF.Functions.Like(client.ComWeb, "%" + filter.Search + "%")
                );
            }

            if (filter.ComSW != null)
            {
                query = query.Join(this._dbContext.Comsws,
                    comp => comp.ComId,
                    link => link.Com.ComId,
                    (comp, link) => new
                    {
                        Company = comp,
                        SwId = link.SwId
                    }).Where(comSW => comSW.SwId == filter.ComSW).Select(compUser => compUser.Company);
            }

            if (filter.Sort != null)
            {
                string[] sort = filter.Sort.Split(".");
                if (sort.Length == 2)
                {
                    switch (sort[0])
                    {
                        case "ID":
                            if (sort[1] == "desc")
                            {
                                query = query.OrderByDescending(client => client.ComId);
                            }
                            else
                            {
                                query = query.OrderBy(client => client.ComId);
                            }
                            break;
                        case "VAT":
                            if (sort[1] == "desc")
                            {
                                query = query.OrderByDescending(client => client.ComCompanyvat);
                            }
                            else
                            {
                                query = query.OrderBy(client => client.ComCompanyvat);
                            }
                            break;
                        case "Name":
                            if (sort[1] == "desc")
                            {
                                query = query.OrderByDescending(client => client.ComCompanyname);
                            }
                            else
                            {
                                query = query.OrderBy(client => client.ComCompanyname);
                            }
                            break;
                        case "Email":
                            if (sort[1] == "desc")
                            {
                                query = query.OrderByDescending(client => client.ComEmail);
                            }
                            else
                            {
                                query = query.OrderBy(client => client.ComEmail);
                            }
                            break;
                        case "Address":
                            if (sort[1] == "desc")
                            {
                                query = query.OrderByDescending(client => client.ComAdd);
                            }
                            else
                            {
                                query = query.OrderBy(client => client.ComAdd);
                            }
                            break;
                        case "Zip":
                            if (sort[1] == "desc")
                            {
                                query = query.OrderByDescending(client => client.ComZip);
                            }
                            else
                            {
                                query = query.OrderBy(client => client.ComZip);
                            }
                            break;
                        case "City":
                            if (sort[1] == "desc")
                            {
                                query = query.OrderByDescending(client => client.ComCity);
                            }
                            else
                            {
                                query = query.OrderBy(client => client.ComCity);
                            }
                            break;
                        case "Phone":
                            if (sort[1] == "desc")
                            {
                                query = query.OrderByDescending(client => client.ComPhone1);
                            }
                            else
                            {
                                query = query.OrderBy(client => client.ComPhone1);
                            }
                            break;
                        case "MainContact":
                            if (sort[1] == "desc")
                            {
                                query = query.OrderByDescending(client => client.ComMainContact);
                            }
                            else
                            {
                                query = query.OrderBy(client => client.ComMainContact);
                            }
                            break;
                        case "WEB":
                            if (sort[1] == "desc")
                            {
                                query = query.OrderByDescending(client => client.ComWeb);
                            }
                            else
                            {
                                query = query.OrderBy(client => client.ComWeb);
                            }
                            break;
                        default:
                            if (sort[1] == "desc")
                            {
                                query = query.OrderBy(client => client.ComId);
                            }
                            break;
                    }
                }
            }

            return query.Skip(filter.SkipSize).Take(filter.PageSize)
                .Join(this._dbContext.Countries,
                comp => comp.ComCountry,
                link => link.Int,
                (comp, link) => new
                {
                    Company = comp,
                    Contry = link,
                }).Select(c => new ClientModel(c.Company, c.Contry)).AsNoTracking().AsEnumerable();
        }

        public IEnumerable<ClientModel> Filter(BaseFilter testFilter)
        {
            var filterItems = testFilter.GetFilterItems()
                .Find(c => string.Equals(c.FieldName, "comsw", StringComparison.OrdinalIgnoreCase));
            int comSWFilter = filterItems == null ? 0 : int.Parse(filterItems.Value.ToString());

            var query = from com in _dbContext.Companies
                        join ctr in _dbContext.Countries on com.ComCountry equals ctr.Int
                        where _dbContext.Comsws.Where(c => (comSWFilter != 0 ? c.SwId == comSWFilter : c.SwId != 0) && c.ComId == com.ComId).Any()
                        select new ClientModel()
                        {
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
                            ComSW = comSWFilter
                        };

            string sqlStr = query.ApplyFilterToQueryString(testFilter);
            List<ClientModel> clients = _dbContext.RawSqlQuery(sqlStr).ConvertDataTable<ClientModel>();
            return clients;
        }

        public IEnumerable<ClientModel> FilterCompany(int clientID, BaseFilter filter)
        {
            var filterItems = filter.GetFilterItems()
                .Find(c => string.Equals(c.FieldName, "linkType", StringComparison.OrdinalIgnoreCase));
            int linkType = filterItems == null ? 0 : int.Parse(filterItems.Value.ToString());

            var query = from com in _dbContext.Companies
                        where _dbContext.Comlinks.Where(l => l.ComId == clientID && l.Type == linkType && l.LinkId == com.ComId).Any()
                        select new ClientModel()
                        {
                            ComId = com.ComId,
                            ComType = com.ComType,
                            ComCompanyvat = com.ComCompanyvat,
                            ComCompanyname = com.ComCompanyname,
                            ComEmail = com.ComEmail,
                            ComAdd = com.ComAdd,
                            ComZip = com.ComZip,
                            ComCity = com.ComCity,
                            ComPhone1 = com.ComPhone1,
                        };

            List<ClientModel> clients = query.Select(com => com).ToList();
            return clients;
        }

        public IEnumerable<EPDDefaultA2Model> FilterEPDDefaultA2(int clientID, BaseFilter filter)
        {
            var query = from a2 in _dbContext.EpddefaultA2s
                        where a2.ComId == clientID
                        select new EPDDefaultA2Model()
                        {
                            Id = a2.Id,
                            ComId = a2.ComId,
                            Epda2id = a2.Epda2id,
                            Epda2km = a2.Epda2km,
                            Epda2filling = a2.Epda2filling,
                            Epda2return = a2.Epda2return,
                            Epda2reuse = a2.Epda2reuse,
                            Epda2name = a2.Epda2name,
                            Comments = a2.Comments,
                            GroupId = a2.GroupId,
                        };
            List<EPDDefaultA2Model> a2s = query.Select(a2 => a2).ToList();
            return a2s;
        }
    }
}
