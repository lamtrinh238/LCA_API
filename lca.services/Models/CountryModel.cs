using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LCA.Data.Domain;

namespace LCA.Services.Models
{
    public class CountryModel
    {
        public CountryModel()
        {
        }

        public CountryModel(Country country)
        {
            Int = country.Int;
            CountryName = country.CountryName;
            Alpha2Code = country.Alpha2Code;
            Alpha3Code = country.Alpha3Code;
            NumericCode = country.NumericCode;
            Language = country.Language;
        }

        public int Int { get; set; }
        public string CountryName { get; set; }
        public string Alpha2Code { get; set; }
        public string Alpha3Code { get; set; }
        public int? NumericCode { get; set; }
        public string Language { get; set; }

    }
}
