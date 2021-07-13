using LCA.Data.Context;
using LCA.Service.Interface;
using LCA.Service.Models.filters;
using LCA.Services.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
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
                if (sort.Length == 2) {
                    switch (sort[0])
                    {
                        case "ID":
                            if (sort[1] == "desc")
                            {
                                query = query.OrderByDescending(client => client.ComId);
                            } else
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
    }
}
