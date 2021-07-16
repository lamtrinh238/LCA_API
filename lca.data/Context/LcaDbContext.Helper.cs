using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Linq;

#nullable disable

namespace LCA.Data.Context
{
    public partial class LcaDbContext : DbContext
    {
        public DataTable RawSqlQuery(string query, CommandType commandType = CommandType.Text)
        {
            using (var command = Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = query;
                command.CommandType = CommandType.Text;

                Database.OpenConnection();

                using (var result = command.ExecuteReader())
                {
                    var dt = new DataTable();
                    dt.Load(result);
                    var results = dt.AsEnumerable().ToList();
                    return dt;
                }
            }
        }
    }
}
