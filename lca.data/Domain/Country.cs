using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class Country
    {
        public int Int { get; set; }
        public string CountryName { get; set; }
        public string Alpha2Code { get; set; }
        public string Alpha3Code { get; set; }
        public int? NumericCode { get; set; }
        public string Language { get; set; }
    }
}
