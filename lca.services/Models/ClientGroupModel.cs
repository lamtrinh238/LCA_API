using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LCA.Data.Domain;

namespace LCA.Services.Models
{
    public class ClientGroupModel
    {
        public ClientGroupModel()
        {
        }

        public ClientGroupModel(ClientGroup clientGroup)
        {
            Id = clientGroup.Id;
            GroupName = clientGroup.GroupName;
        }

        public int Id { get; set; }
        public string GroupName { get; set; }

    }
}
