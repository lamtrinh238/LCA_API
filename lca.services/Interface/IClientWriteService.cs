using LCA.Service.Models.filters;
using LCA.Services.Models;
using System.Collections.Generic;

namespace LCA.Service.Interface
{
    public interface IClientWriteService
    {
        long CreateClient(ClientModel client);
        long UpdateClient(int clientID, ClientUpdateModel client);
        long DeleteClient(int clientID);
        long CreateCompanyLink(CompanyLinkModel companyLink);
        long CreateEPDDefaultA2(EPDDefaultA2Model ePDDefaultA2);
        long UpdateEPDDefaultA2(int epdID, EPDDefaultA2Model ePDDefaultA2);
        long DeleteEPDDefaultA2(int epdID);
        long CreateEPDDefaultA3(EPDDefaultA3Model ePDDefaultA3);
        long UpdateEPDDefaultA3(int epdID, EPDDefaultA3Model ePDDefaultA3);
        long DeleteEPDDefaultA3(int epdID);
        long CreateEPDDefaultA4(EPDDefaultA4Model ePDDefaultA4);
        long UpdateEPDDefaultA4(int epdID, EPDDefaultA4Model ePDDefaultA4);
        long DeleteEPDDefaultA4(int epdID);
    }
}
