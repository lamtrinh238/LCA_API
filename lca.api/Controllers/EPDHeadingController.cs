using LCA.Services.Interface;
using LCA.Services.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LCA.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EPDHeadingController : ControllerBase
    {
        private readonly IEPDHeadingService _epdHeadingService;
        public EPDHeadingController(IEPDHeadingService epdHeadingService)
        {
            _epdHeadingService = epdHeadingService;
        }

        // GET api/<EPDHeadingController>/5
        [HttpGet()]
        public IEnumerable<EPDHeading> Get([FromQuery] int page, int pageSize)
        {
            return this._epdHeadingService.GetAllEPDHeading(page, pageSize);
        }

        // POST api/<EPDHeadingController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EPDHeadingController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EPDHeadingController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
