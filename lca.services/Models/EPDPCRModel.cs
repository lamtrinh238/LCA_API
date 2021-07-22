using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LCA.Data.Domain;

namespace LCA.Services.Models
{
    public class EPDPCRModel
    {
        public EPDPCRModel()
        {
        }

        public EPDPCRModel(Epdpcr epdpcr)
        {
            Id = epdpcr.Id;
            Pcrname = epdpcr.Pcrname;
        }

        public int Id { get; set; }
        public string Pcrname { get; set; }

    }
}
