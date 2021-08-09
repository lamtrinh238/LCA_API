using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LCA.Data.Domain;

namespace LCA.Services.Models
{
    public class EPDDefaultA2Model
    {
        public EPDDefaultA2Model()
        {
        }

        public EPDDefaultA2Model(EpddefaultA2 epddefaultA2, string epdmaterialName)
        {
            Id = epddefaultA2.Id;
            EpdmaterialName = epdmaterialName;
            ComId = epddefaultA2.ComId;
            Epda2id = epddefaultA2.Epda2id;
            Epda2km = epddefaultA2.Epda2km;
            Epda2filling = epddefaultA2.Epda2filling;
            Epda2return = epddefaultA2.Epda2return;
            Epda2reuse = epddefaultA2.Epda2reuse;
            Epda2name = epddefaultA2.Epda2name;
            Comments = epddefaultA2.Comments;
            GroupId = epddefaultA2.GroupId;
        }

        public int Id { get; set; }
        public string EpdmaterialName { get; set; }
        public int ComId { get; set; }
        public int Epda2id { get; set; }
        public int? Epda2km { get; set; }
        public int? Epda2filling { get; set; }
        public int? Epda2return { get; set; }
        public int? Epda2reuse { get; set; }
        public string Epda2name { get; set; }
        public string Comments { get; set; }
        public int? GroupId { get; set; }
    }
}
