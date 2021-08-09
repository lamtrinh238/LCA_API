using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LCA.Data.Domain;

namespace LCA.Services.Models
{
    public class EPDMaterialsSIMAModel
    {
        public EPDMaterialsSIMAModel()
        {
        }

        public int Id { get; set; }
        public string EpdmaterialId { get; set; }
        public string EpdmaterialName { get; set; }
    }
}
