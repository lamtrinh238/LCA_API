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

        [JsonIgnore]
        public List<SearchItem> SearchItems { get; set; }

        [JsonIgnore]
        public SortItem SortItems { get; set; }
    }

    public class SearchItem
    {
        public string FieldName { get; set; }

        public object Value { get; set; }

        public Operator Operator { get; set; }
    }

    public class SortItem
    {
        public string FieldName { get; set; }

        public SortType SortType { get; set; }
    }

    public enum Operator
    {
        Equal,
        NotEqual,
        GreaterThan,
        LessThan,
        GreaterThanOrEqual,
        LessThanOrEqual,
        Between,
        Like,
        In
    }

    public enum SortType
    {
        ASC = 0,
        DESC
    }
}
