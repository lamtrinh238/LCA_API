using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class CompanyProductList
    {
        public int Id { get; set; }
        public int? ComId { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public int? ProductGroup { get; set; }
        public string Comments { get; set; }
        public long? DataSet { get; set; }
        public int? DataSetType { get; set; }
    }
}
