using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace LCA.Service.Models.filters
{
    public class BaseFilter
    {
        public BaseFilter()
        {
            this.PageSize = 20;
            this.Page = 1;
            FilterItems = new List<FilterItem>();
            SortItems = new SortItem();
        }

        public int Page { get; set; }
        public int PageSize { get; set; }

        public string SortText { get; set; }

        public string FilterText { get; set; }

        public string GlobalSearch { get; set; }

        [JsonIgnore]
        internal int SkipSize { get
            {
                return (this.Page - 1) * this.PageSize;
            }
        }

        [JsonIgnore]
        internal List<FilterItem> FilterItems { get; set; }

        [JsonIgnore]
        internal SortItem SortItems { get; set; }
    }

    public class FilterItem
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
