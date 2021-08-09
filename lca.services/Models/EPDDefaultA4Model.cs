using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LCA.Data.Domain;

namespace LCA.Services.Models
{
    public class EPDDefaultA4Model
    {
        public EPDDefaultA4Model()
        {
        }

        public EPDDefaultA4Model(EpddefaultA4 epddefaultA4)
        {
            Id = epddefaultA4.Id;
            ComId = epddefaultA4.ComId;
            Epda4id = epddefaultA4.Epda4id;
            Epda4km = epddefaultA4.Epda4km;
            Epda4filling = epddefaultA4.Epda4filling;
            Epda4return = epddefaultA4.Epda4return;
            Epda4reuse = epddefaultA4.Epda4reuse;
            Epda4name = epddefaultA4.Epda4name;
            Comments = epddefaultA4.Comments;
            GroupId = epddefaultA4.GroupId;
        }

        public int Id { get; set; }
        public int ComId { get; set; }
        public int Epda4id { get; set; }
        public int? Epda4km { get; set; }
        public int? Epda4filling { get; set; }
        public int? Epda4return { get; set; }
        public int? Epda4reuse { get; set; }
        public string Epda4name { get; set; }
        public string Comments { get; set; }
        public int? GroupId { get; set; }
    }
}
