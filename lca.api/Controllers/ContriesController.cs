using LCA.Service.Interface;
using LCA.Service.Models.filters;
using LCA.Services.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LCA.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly ICountryReadService _countryReadService;

        public CountriesController(ICountryReadService countryReadService)
        {
            this._countryReadService = countryReadService;
        }

        // GET api/<ClientsController>/5
        [HttpGet()]
        public IEnumerable<CountryModel> Get([FromQuery] BaseFilter filter)
        {
            return _countryReadService.Filter(filter);
        }
    }
}
