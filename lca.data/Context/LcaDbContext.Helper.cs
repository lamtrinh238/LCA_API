using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using LCA.Data.Domain;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;

#nullable disable

namespace LCA.Data.Context
{
    public partial class LcaDbContext : DbContext
    {
        public List<DataRow> RawSqlQuery(string query, CommandType commandType = CommandType.Text)
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

                    //Populate a list
                    var results = dt.AsEnumerable().ToList();

                    //while (result.Read())
                    //{
                    //    entities.Add(map(result));
                    //}

                    return results;
                }
            }
        }
    }
}
