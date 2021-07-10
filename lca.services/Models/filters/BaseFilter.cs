using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LCA.Service.Models.filters
{
    public class BaseFilter
    {
        public BaseFilter()
        {
            this.PageSize = 20;
            this.Page = 1;
        }

        public int Page { get; set; }
        public int PageSize { get; set; }

        [JsonIgnore]
        internal int SkipSize { get
            {
                return (this.Page - 1) * this.PageSize;
            }
        }
    }
}
