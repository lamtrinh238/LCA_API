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

        public long CreateCompanyLink(CompanyLinkModel companyLink)
        {
            var newCompanyLink = new Comlink
            {
                ComId = companyLink.ComId,
                LinkId = companyLink.LinkId,
                Type = companyLink.Type,
            };

            this._dbContext.Entry(newCompanyLink).State = EntityState.Added;
            this._dbContext.SaveChanges();
            return newCompanyLink.Id;

        }

        public long CreateEPDDefaultA2(EPDDefaultA2Model ePDDefaultA2)
        {
            var newEPDDefaultA2 = new EpddefaultA2
            {
                ComId = ePDDefaultA2.ComId,
                Epda2id = ePDDefaultA2.Epda2id,
                Epda2km = ePDDefaultA2.Epda2km,
                GroupId = ePDDefaultA2.GroupId,
                Comments = ePDDefaultA2.Comments,
            };

            this._dbContext.Entry(newEPDDefaultA2).State = EntityState.Added;
            this._dbContext.SaveChanges();
            return newEPDDefaultA2.Id;
        }

        public long UpdateEPDDefaultA2(int epdID, EPDDefaultA2Model ePDDefaultA2)
        {
            var existingEPD = this._dbContext.EpddefaultA2s.SingleOrDefault(epd => epd.Id == epdID);
            existingEPD.Epda2id = ePDDefaultA2.Epda2id;
            existingEPD.Epda2km = ePDDefaultA2.Epda2km;
            existingEPD.GroupId = ePDDefaultA2.GroupId;
            existingEPD.Comments = ePDDefaultA2.Comments;

            this._dbContext.Entry<EpddefaultA2>(existingEPD).State = EntityState.Modified;
            this._dbContext.SaveChanges();
            return epdID;
        }

        public long DeleteEPDDefaultA2(int epdID)
        {
            this._dbContext.EpddefaultA2s.RemoveRange(this._dbContext.EpddefaultA2s.Where(epd => epd.Id == epdID));
            this._dbContext.SaveChanges();
            return epdID;
        }

        public long CreateEPDDefaultA3(EPDDefaultA3Model ePDDefaultA3)
        {
            var newEPDDefaultA3 = new EpddefaultA3
            {
                ComId = ePDDefaultA3.ComId,
                Epda3id = ePDDefaultA3.Epda3id,
                Epda3quantity = ePDDefaultA3.Epda3quantity,
                GroupId = ePDDefaultA3.GroupId,
                UnitCalc = ePDDefaultA3.UnitCalc,
                Comments = ePDDefaultA3.Comments,
            };

            this._dbContext.Entry(newEPDDefaultA3).State = EntityState.Added;
            this._dbContext.SaveChanges();
            return newEPDDefaultA3.Id;
        }

        public long UpdateEPDDefaultA3(int epdID, EPDDefaultA3Model ePDDefaultA3)
        {
            var existingEPD = this._dbContext.EpddefaultA3s.SingleOrDefault(epd => epd.Id == epdID);
            existingEPD.Epda3id = ePDDefaultA3.Epda3id;
            existingEPD.Epda3quantity = ePDDefaultA3.Epda3quantity;
            existingEPD.GroupId = ePDDefaultA3.GroupId;
            existingEPD.UnitCalc = ePDDefaultA3.UnitCalc;
            existingEPD.Comments = ePDDefaultA3.Comments;

            this._dbContext.Entry<EpddefaultA3>(existingEPD).State = EntityState.Modified;
            this._dbContext.SaveChanges();
            return epdID;
        }

        public long DeleteEPDDefaultA3(int epdID)
        {
            this._dbContext.EpddefaultA3s.RemoveRange(this._dbContext.EpddefaultA3s.Where(epd => epd.Id == epdID));
            this._dbContext.SaveChanges();
            return epdID;
        }

        public long CreateEPDDefaultA4(EPDDefaultA4Model ePDDefaultA4)
        {
            var newEPDDefaultA4 = new EpddefaultA4
            {
                ComId = ePDDefaultA4.ComId,
                Epda4id = ePDDefaultA4.Epda4id,
                Epda4km = ePDDefaultA4.Epda4km,
                GroupId = ePDDefaultA4.GroupId,
                Comments = ePDDefaultA4.Comments,
            };

            this._dbContext.Entry(newEPDDefaultA4).State = EntityState.Added;
            this._dbContext.SaveChanges();
            return newEPDDefaultA4.Id;
        }

        public long UpdateEPDDefaultA4(int epdID, EPDDefaultA4Model ePDDefaultA4)
        {
            var existingEPD = this._dbContext.EpddefaultA4s.SingleOrDefault(epd => epd.Id == epdID);
            existingEPD.Epda4id = ePDDefaultA4.Epda4id;
            existingEPD.Epda4km = ePDDefaultA4.Epda4km;
            existingEPD.GroupId = ePDDefaultA4.GroupId;
            existingEPD.Comments = ePDDefaultA4.Comments;

            this._dbContext.Entry<EpddefaultA4>(existingEPD).State = EntityState.Modified;
            this._dbContext.SaveChanges();
            return epdID;
        }

        public long DeleteEPDDefaultA4(int epdID)
        {
            this._dbContext.EpddefaultA4s.RemoveRange(this._dbContext.EpddefaultA4s.Where(epd => epd.Id == epdID));
            this._dbContext.SaveChanges();
            return epdID;
        }
    }
}
