using LCA.Services.Models;
using System.Collections.Generic;

namespace LCA.Services.Interface
{
    public interface IEPDHeadingService
    {
        IEnumerable<EPDHeading> GetAllEPDHeading(int page, int pageSize);
    }
}
