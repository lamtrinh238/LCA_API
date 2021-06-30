using System;
using System.Collections.Generic;

#nullable disable

namespace LCA.Data.Domain
{
    public partial class ProductsLine
    {
        public ProductsLine()
        {
            PackMaterialListSelections = new HashSet<PackMaterialListSelection>();
        }

        public int Id { get; set; }
        public int? HeadId { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public int? ProductGroup { get; set; }
        public int? FpakDpak { get; set; }
        public int? DpakPall { get; set; }
        public double? NetWeight { get; set; }
        public double? SalesVolume { get; set; }
        public double? WasteVolume { get; set; }
        public double? WastePrecent { get; set; }
        public string Comments { get; set; }
        public int? TransportGroup { get; set; }
        public int? UsrId { get; set; }
        public decimal? NoFpakT { get; set; }
        public decimal? NoDpakT { get; set; }
        public decimal? NoPallT { get; set; }
        public int? NsEn { get; set; }
        public bool? PartOfSelection { get; set; }

        public virtual EPackHeading Head { get; set; }
        public virtual ICollection<PackMaterialListSelection> PackMaterialListSelections { get; set; }
    }
}
