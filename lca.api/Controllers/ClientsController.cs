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
        public IEnumerable<EPDDefaultA2Model> GetEPDDefaultA2(int clientID, [FromQuery] BaseFilter filter)
        {
            return _clientReadService.FilterEPDDefaultA2(clientID, filter);
        }
    }
}
