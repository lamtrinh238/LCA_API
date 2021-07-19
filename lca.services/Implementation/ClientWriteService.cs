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

        public long UpdateClient(int clientID, ClientModel clientModel)
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
            this._dbContext.SaveChanges();
            return clientID;
        }
    }
}
