using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class ProductDatum
    {
        public int DataCollectionId { get; set; }
        public int ProductId { get; set; }
        public int? SalesVolume { get; set; }
        public int? WasteVolume { get; set; }
    }
}
