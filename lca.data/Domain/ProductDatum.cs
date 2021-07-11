using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Keyless]
    public partial class ProductDatum
    {
        [Column("DataCollectionID")]
        public int DataCollectionId { get; set; }
        [Column("ProductID")]
        public int ProductId { get; set; }
        public int? SalesVolume { get; set; }
        public int? WasteVolume { get; set; }
    }
}
