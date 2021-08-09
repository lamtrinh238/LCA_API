using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LCA.Data.Domain;

namespace LCA.Services.Models
{
    public class EPDDefaultA3Model
    {
        public EPDDefaultA3Model()
        {
        }

        public EPDDefaultA3Model(EpddefaultA3 epddefaultA3)
        {
            Id = epddefaultA3.Id;
            ComId = epddefaultA3.ComId;
            Epda3id = epddefaultA3.Epda3id;
            Epda3name = epddefaultA3.Epda3name;
            Epda3quantity = epddefaultA3.Epda3quantity;
            Comments = epddefaultA3.Comments;
            Epda3unit = epddefaultA3.Epda3unit;
            GroupId = epddefaultA3.GroupId;
            Type = epddefaultA3.Type;
            UnitCalc = epddefaultA3.UnitCalc;
        }

        public int Id { get; set; }
        public int ComId { get; set; }
        public int Epda3id { get; set; }
        public string Epda3name { get; set; }
        public decimal? Epda3quantity { get; set; }
        public string Comments { get; set; }
        public string Epda3unit { get; set; }
        public int? GroupId { get; set; }
        public int? Type { get; set; }
        public decimal? UnitCalc { get; set; }
    }
}
