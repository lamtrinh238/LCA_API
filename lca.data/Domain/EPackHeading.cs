using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class EPackHeading
    {
        public EPackHeading()
        {
            ProductsLines = new HashSet<ProductsLine>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Comments { get; set; }
        public long? ComId { get; set; }

        public virtual Company Com { get; set; }
        public virtual ICollection<ProductsLine> ProductsLines { get; set; }
    }
}
