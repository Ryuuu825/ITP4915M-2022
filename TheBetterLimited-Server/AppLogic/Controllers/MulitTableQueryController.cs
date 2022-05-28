namespace TheBetterLimited_Server.AppLogic.Controllers
{
    public class MulitTableQueryController
    {
        // perform a query on two tables
        public async Task<List<Hashtable>> Get(List<string> tables , string quertString , string lang = "en")
        {
            
            // example: SELECT * FROM [Table1] , [Table2] , [Table3]
            string sql = Helpers.Sql.QueryStringBuilder.CreateCrossTableSQLQuery(quertString , tables);
            ConsoleLogger.Debug(sql);
            return new List<Hashtable>(){};
            
            // now add match the query string
        }

    }
}