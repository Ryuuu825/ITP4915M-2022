using TheBetterLimited_Server.Data;
namespace TheBetterLimited_Server.AppLogic.Controllers
{
    public class MulitTableQueryController
    {
        private readonly DataContext db;
        public MulitTableQueryController(DataContext db)
        {
            this.db = db;
        }
        // perform a query on two tables
        public async Task<List<Hashtable>> Get(List<string> tables , string quertString , string lang = "en")
        {
            
            // example: SELECT * FROM [Table1] , [Table2] , [Table3]
            string sql = Helpers.Sql.QueryStringBuilder.CreateCrossTableSQLQuery(quertString , tables);
            
            // excute the query and store the result in a list of hashtables or DataTables
            // var list = await db.QueryAsync<Hashtable>(sql); // wrong !!!  this method not exist

            List<Hashtable> res = new List<Hashtable>();
            using (var conn = db.Database.GetDbConnection())
            {
                await conn.OpenAsync();
                using (var command = conn.CreateCommand())
                {
                    command.CommandText = sql;
                    try
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            int  tableCounter = 0;
                            while(await reader.ReadAsync())
                            {
                                var entry = new Hashtable();
                                for (var i = 0 ; i < reader.FieldCount ; i++)
                                {
                                    ConsoleLogger.Debug(reader.GetName(i) + " : " + reader.GetValue(i));
                                    if (reader.GetName(i).ToLower() == "id")
                                    {
                                        entry.Add(tables[tableCounter++] + " " + reader.GetName(i) , reader.GetValue(i));
                                    }
                                    else
                                    {
                                        entry.Add(reader.GetName(i) , reader.GetValue(i));
                                    }
                                }
                                res.Add(entry);
                            }
                        }
                    }catch(Exception e)
                    {
                        throw new BadArgException(e.Message);
                    }
                    
                }
            }

            return res;


            // now add match the query string
        }
    }

}