using LCA.Data.Domain;
using System;

namespace LCA.Services.Models
{
    public class EPDHeadingModel
    {
        public int Id { get; set; }
        public string Epdnumber { get; set; }
        public string Epdname { get; set; }
        public string Epddescription { get; set; }
        public string Epdspesification { get; set; }
        public string Epdtech { get; set; }
        public string Epdmarket { get; set; }
        public long? UserId { get; set; }
        public DateTime? Epddate { get; set; }
        public DateTime? EpdapprovedDate { get; set; }
        public DateTime? EpdexpirationDate { get; set; }
        public string Epdeditor { get; set; }
        public string Epdresponsible { get; set; }
        public int? Epdstatus { get; set; }
        public string Comments { get; set; }

        public EPDHeadingModel(Epdheading epdHeading)
        {
            this.Id = epdHeading.Id;
            this.Epdnumber = epdHeading.Epdnumber;
            this.Epdname = epdHeading.Epdname;
            this.Epddescription = epdHeading.Epddescription;
            this.Epdspesification = epdHeading.Epdspesification;
            this.Epdtech = epdHeading.Epdtech;
            this.Epdmarket = epdHeading.Epdmarket;
            this.UserId = epdHeading.UserId;
            this.Epddate = epdHeading.Epddate;
            this.EpdexpirationDate = epdHeading.EpdexpirationDate;
            this.EpdapprovedDate = epdHeading.EpdapprovedDate;
            this.Epdeditor = epdHeading.Epdeditor;
            this.Epdresponsible = epdHeading.Epdresponsible;
            this.Epdstatus = epdHeading.Epdstatus;
            this.Comments = epdHeading.Comments;
        }
    }
}
