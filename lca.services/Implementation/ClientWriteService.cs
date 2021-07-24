using LCA.Data.Context;
using LCA.Data.Domain;
using LCA.Service.Interface;
using LCA.Services.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCA.Service.Implementation
{
    public class ClientWriteService : DbContextService, IClientWriteService
    {
        public ClientWriteService(LcaDbContext dbContext) : base(dbContext)
        {

        }

        public long CreateClient(ClientModel clientModel)
        {
            var newClient = new Company
            {
                ComType = 0,
                ComCompanyvat = clientModel.ComCompanyvat,
                ComCompanyname = clientModel.ComCompanyname,
                ComEmail = clientModel.ComEmail,
                ComAdd = clientModel.ComAdd,
                ComZip = clientModel.ComZip,
                ComCity = clientModel.ComCity,
                ComPhone1 = clientModel.ComPhone1,
                ComMainContact = clientModel.ComMainContact,
                ComWeb = clientModel.ComWeb,
                ComCountry = clientModel.ComCountry
            };

            this._dbContext.Entry<Company>(newClient).State = EntityState.Added;
            this._dbContext.SaveChanges();
            var programModule = this._dbContext.ProgramModules.SingleOrDefault(m => m.Id == clientModel.ComSW);
            var comSW = new Comsw
            {
                ComId = newClient.ComId,
                SwType = 1,
                SwId = clientModel.ComSW
            };

            this._dbContext.Entry(comSW).State = EntityState.Added;
            this._dbContext.SaveChanges();
            return newClient.ComId;
        }

        public long UpdateClient(int clientID, ClientUpdateModel clientModel)
        {
            var existingClient = this._dbContext.Companies.SingleOrDefault(comp => comp.ComId == clientID);
            existingClient.ComCompanyvat = clientModel.ComCompanyvat;
            existingClient.ComCompanyname = clientModel.ComCompanyname;
            existingClient.ComAdd = clientModel.ComAdd;
            existingClient.ComZip = clientModel.ComZip;
            existingClient.ComCity = clientModel.ComCity;
            existingClient.ComCountry = clientModel.ComCountry;
            existingClient.ComStatus = clientModel.ComStatus;
            existingClient.ComGuid = clientModel.ComGuid;
            existingClient.ComLogo = clientModel.ComLogo;
            existingClient.ComPhone1 = clientModel.ComPhone1;
            existingClient.ComPhone2 = clientModel.ComPhone2;
            existingClient.ComMainContact = clientModel.ComMainContact;
            existingClient.ComEmail = clientModel.ComEmail;
            existingClient.ComWeb = clientModel.ComWeb;
            existingClient.ComCreatedttm = clientModel.ComCreatedttm;
            existingClient.ComToken = clientModel.ComToken;
            existingClient.ComPageText = clientModel.ComPageText;
            existingClient.ComEpdinfo1 = clientModel.ComEpdinfo1;
            existingClient.ComEpdinfo2 = clientModel.ComEpdinfo2;
            existingClient.ComEpdinfo3 = clientModel.ComEpdinfo3;
            existingClient.ComEpdinfo4 = clientModel.ComEpdinfo4;
            existingClient.ComManagmentSys = clientModel.ComManagmentSys;
            existingClient.ComPaidTo = clientModel.ComPaidTo;
            existingClient.ComType = clientModel.ComType;
            existingClient.ComProgramOperator = clientModel.ComProgramOperator;
            existingClient.ComModulSubFase = clientModel.ComModulSubFase;
            existingClient.ComModulSharing = clientModel.ComModulSharing;

            this._dbContext.Entry<Company>(existingClient).State = EntityState.Modified;

            this._dbContext.Comsws.RemoveRange(this._dbContext.Comsws.Where(sw => sw.ComId == clientID));
            if (clientModel.ComSws != null && clientModel.ComSws.Length > 0)
            {
                foreach (int sw in clientModel.ComSws)
                {
                    var programModule = this._dbContext.ProgramModules.SingleOrDefault(m => m.Id == sw);
                    if (programModule != null)
                    {
                        var comSW = new Comsw
                        {
                            ComId = clientID,
                            SwType = 1,
                            SwId = sw
                        };

                        this._dbContext.Entry(comSW).State = EntityState.Added;
                    }
                }
            }

            this._dbContext.ComPcrlinks.RemoveRange(this._dbContext.ComPcrlinks.Where(pcr => pcr.ComId == clientID));
            if (clientModel.ComPcrs != null && clientModel.ComPcrs.Length > 0)
            {
                foreach (int pcr in clientModel.ComPcrs)
                {
                    var epdPcr = this._dbContext.Epdpcrs.SingleOrDefault(e => e.Id == pcr);
                    if (epdPcr != null)
                    {
                        var comPcrLink = new ComPcrlink
                        {
                            ComId = clientID,
                            PcrId = pcr
                        };
                        this._dbContext.Entry(comPcrLink).State = EntityState.Added;
                    }
                }
            }

            this._dbContext.SaveChanges();
            return clientID;
        }

        public long DeleteClient(int clientID)
        {
            this._dbContext.Companies.RemoveRange(this._dbContext.Companies.Where(comp => comp.ComId == clientID));
            this._dbContext.SaveChanges();
            return clientID;
        }
    }
}
