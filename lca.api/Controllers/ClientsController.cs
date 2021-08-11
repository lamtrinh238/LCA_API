﻿using LCA.Service.Interface;
using LCA.Service.Models.filters;
using LCA.Services.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LCA.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly IClientReadService _clientReadService;
        private readonly IClientWriteService _clientWriteService;

        public ClientsController(IClientReadService clientReadService, IClientWriteService clientWriteService)
        {
            this._clientReadService = clientReadService;
            this._clientWriteService = clientWriteService;
        }

        // GET api/<ClientsController>/5
        [HttpGet("{clientID:int}")]
        public ClientGeneralModel Get(int clientID)
        {
            return _clientReadService.GetClientByID(clientID);
        }

        // GET api/<ClientsController>/5
        [HttpGet()]
        public IEnumerable<ClientModel> Get([FromQuery] BaseFilter filter)
        {
            return _clientReadService.Filter(filter);
        }

        // POST api/<ClientsController>
        [HttpPost()]
        public IActionResult Create([FromBody] ClientModel client)
        {
            var userID = _clientWriteService.CreateClient(client);
            return Ok(new
            {
                ID = userID
            });
        }

        // PUT api/<ClientsController>/5
        [HttpPut("{clientID:int}")]
        public IActionResult Update(int clientID, [FromBody] ClientUpdateModel client)
        {
            _clientWriteService.UpdateClient(clientID, client);
            return Ok(new
            {
                ID = clientID
            });
        }

        // DELETE api/<ClientsController>/5
        [HttpDelete("{clientID:int}")]
        public IActionResult Delete(int clientID)
        {
            _clientWriteService.DeleteClient(clientID);
            return Ok(new
            {
                ID = clientID
            });
        }

        // GET api/<ClientsController>/5
        [HttpGet("{clientID:int}/companies")]
        public IEnumerable<ClientModel> GetCompany(int clientID, [FromQuery] BaseFilter filter)
        {
            return _clientReadService.FilterCompany(clientID, filter);
        }

        // POST api/<ClientsController>
        [HttpPost("companies")]
        public IActionResult CreateCompanyLink([FromBody] CompanyLinkModel companyLink)
        {
            var compLink = _clientWriteService.CreateCompanyLink(companyLink);
            return Ok(new
            {
                ID = compLink
            });
        }

        // GET api/<ClientsController>/5
        [HttpGet("{clientID:int}/epd_default_a2")]
        public IEnumerable<EPDDefaultA2Model> GetEPDDefaultA2(int clientID)
        {
            return _clientReadService.FilterEPDDefaultA2(clientID);
        }

        // GET api/<ClientsController>/5
        [HttpGet("{clientID:int}/epd_default_a3")]
        public IEnumerable<EPDDefaultA3Model> GetEPDDefaultA3(int clientID)
        {
            return _clientReadService.FilterEPDDefaultA3(clientID);
        }

        // GET api/<ClientsController>/5
        [HttpGet("{clientID:int}/epd_default_a4")]
        public IEnumerable<EPDDefaultA4Model> GetEPDDefaultA4(int clientID)
        {
            return _clientReadService.FilterEPDDefaultA4(clientID);
        }

        // POST api/<ClientsController>/5/epd_default_a2
        [HttpPost("{clientID:int}/epd_default_a2")]
        public IActionResult CreateEPDDefaultA2(int clientID, [FromBody] EPDDefaultA2Model ePDDefaultA2)
        {
            ePDDefaultA2.ComId = clientID;
            var res = _clientWriteService.CreateEPDDefaultA2(ePDDefaultA2);
            return Ok(new
            {
                ID = res
            });
        }

        // POST api/<ClientsController>/5/epd_default_a3
        [HttpPost("{clientID:int}/epd_default_a3")]
        public IActionResult CreateEPDDefaultA3(int clientID, [FromBody] EPDDefaultA3Model ePDDefaultA3)
        {
            ePDDefaultA3.ComId = clientID;
            var res = _clientWriteService.CreateEPDDefaultA3(ePDDefaultA3);
            return Ok(new
            {
                ID = res
            });
        }

        // POST api/<ClientsController>/5/epd_default_a4
        [HttpPost("{clientID:int}/epd_default_a4")]
        public IActionResult CreateEPDDefaultA4(int clientID, [FromBody] EPDDefaultA4Model ePDDefaultA4)
        {
            ePDDefaultA4.ComId = clientID;
            var res = _clientWriteService.CreateEPDDefaultA4(ePDDefaultA4);
            return Ok(new
            {
                ID = res
            });
        }
    }
}
