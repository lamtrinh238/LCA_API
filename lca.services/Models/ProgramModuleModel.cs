using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LCA.Data.Domain;

namespace LCA.Services.Models
{
    public class ProgramModuleModel
    {
        public ProgramModuleModel()
        {
        }

        public ProgramModuleModel(ProgramModule programModule)
        {
            Id = programModule.Id;
            Name = programModule.Name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

    }
}
