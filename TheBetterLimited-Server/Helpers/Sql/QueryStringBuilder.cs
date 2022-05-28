using TheBetterLimited_Server.AppLogic.Exceptions;
namespace TheBetterLimited_Server.Helpers.Sql;

public static class QueryStringBuilder
{
    public static readonly string query = "SELECT @ATTRIBUTE FROM @TABLE WHERE @CONDITION";

    public static string GetSqlStatement<T>(string condString )
    {
        string queryStr;

        if (condString.Contains(":"))
            queryStr = Helpers.Sql.QueryStringBuilder.CreateSQLQuery( condString , typeof(T).Name );
        else 
            queryStr = Helpers.Sql.QueryStringBuilder.LazyCreateSQLQuery<T>( condString, typeof(T).Name);

#if DEBUG
       ConsoleLogger.Debug(queryStr);
#endif      
        return queryStr;
    }

    public static string CreateCrossTableSQLQuery(string condString , List<string> tables)
    {
        // SELECT * FROM Account JOIN Staff ON Account._StaffId = Staff.Id WHERE Account.Id LIKE '%A0001%';
        // JOIN Staff ON Account._StaffId = Staff.Id

        string CrossTablesString = "SELECT @ATTRIBUTE FROM @TABLE @JOIN WHERE @CONDITION";

        var builder = new StringBuilder(CrossTablesString);
        builder.Replace("@TABLE", tables[0] );
        builder.Replace("@ATTRIBUTE", "*");
        builder.Replace("@CONDITION", ConditionBuilder(tables[0] , condString));
        StringBuilder sb = new StringBuilder();
        // inner join the tables
        for(int i = 1; i <tables.Count ; i++)
        {
            // inner join table1 on table1.id = table2.id
            sb.Append(" JOIN ");
            sb.Append(tables[i]);
            sb.Append(" ON ");
            sb.Append(tables[0]);
            sb.Append(".");
            sb.Append("_" + tables[i] + "Id = ");
            sb.Append(tables[i]);
            sb.Append(".id");
        }
        builder.Replace("@JOIN", sb.ToString());
        return builder.ToString();
    }



    // Two type of condString
    // lazy one : value;value;value
    // readable one : key=value;key=value;
    private static string CreateSQLQuery<T>(string condString)
    {
        var builder = new StringBuilder(query);
       
        builder.Replace("@TABLE", typeof(T).Name.ToLower() + "s" );
        builder.Replace("@ATTRIBUTE", "*");
        builder.Replace("@CONDITION", ConditionBuilder(condString));
        return builder.ToString();

    }
    
    private static string CreateSQLQuery(string condString , string table)
    {
        var builder = new StringBuilder(query);
        builder.Replace("@TABLE", table );
        builder.Replace("@ATTRIBUTE", "*");
        builder.Replace("@CONDITION", ConditionBuilder(condString));
        return builder.ToString();
    }
    private static string LazyCreateSQLQuery<T>(string condString)
    {
        var builder = new StringBuilder(query);
        
        builder.Replace("@TABLE", typeof(T).Name.ToLower() + "s" );
        builder.Replace("@ATTRIBUTE", "*");
        builder.Replace("@CONDITION", LazyConditionBuilder<T>(condString));
        return builder.ToString();

    }
    
    private static string LazyCreateSQLQuery<T>(string condString , string table)
    {
        var builder = new StringBuilder(query);
       
        builder.Replace("@TABLE", table );
        builder.Replace("@ATTRIBUTE", "*");
        builder.Replace("@CONDITION", LazyConditionBuilder<T>(condString));
        return builder.ToString();

    }

    private static string ConditionBuilder(string condString)
    {
        // if emailAddress:example.com|userName:example.com use OR
        // else emailAddress:example.com;userName:example.com use AND
        var condBuilder = new StringBuilder();

        string sqlSeparter = condString.Contains("|") ? " OR " : " AND ";
        var cond = condString.Contains("|") ? condString.Split('|') : condString.Split(';');
        var pair = cond[0].Split(":");
        
        if (pair[1].Equals("null"))
            condBuilder.Append($" {pair[0]} is {pair[1]}");
        else 
            condBuilder.Append($" {pair[0]} LIKE '%{pair[1]}%'");
        
        for (var i = 1;  i < cond.Length; i++)
        {
            if (!cond[i].Equals(""))
            {

                condBuilder.Append($" {sqlSeparter} ");

                pair = cond[i].Split(":");
                if (pair[1].Equals("null"))
                    condBuilder.Append($"{pair[0]} is {pair[1]}");
                else
                    condBuilder.Append($"{pair[0]} LIKE '%{pair[1]}%'");
            }
        }

        return condBuilder.ToString();
    }

    private static string ConditionBuilder(string table , string condString)
    {
        // if emailAddress:example.com|userName:example.com use OR
        // else emailAddress:example.com;userName:example.com use AND
        var condBuilder = new StringBuilder();

        string sqlSeparter = condString.Contains("|") ? " OR " : " AND ";
        var cond = condString.Contains("|") ? condString.Split('|') : condString.Split(';');
        var pair = cond[0].Split(":");
        
        if (pair[1].Equals("null"))
            condBuilder.Append($" {table}.{pair[0]} is {pair[1]}");
        else 
            condBuilder.Append($" {table}.{pair[0]} LIKE '%{pair[1]}%'");
        
        for (var i = 1;  i < cond.Length; i++)
        {
            if (!cond[i].Equals(""))
            {

                condBuilder.Append($" {sqlSeparter} ");

                pair = cond[i].Split(":");
                if (pair[1].Equals("null"))
                    condBuilder.Append($"{table}.{pair[0]} is {pair[1]}");
                else
                    condBuilder.Append($"{table}.{pair[0]} LIKE '%{pair[1]}%'");
            }
        }

        return condBuilder.ToString();
    }

    private static string LazyConditionBuilder<T>(string condString)
    {
        var condBuilder = new StringBuilder();
        var cond = condString.Split(";");

        if (!cond[0].Equals(""))
        {
            if (cond[0].Equals("null"))
                condBuilder.Append($"{typeof(T).GetProperties()[0].Name} is {cond[0]} ");
            else 
                condBuilder.Append($"{typeof(T).GetProperties()[0].Name} = '{cond[0]}' ");
        }

        for (var i = 1; i < typeof(T).GetProperties().Length && i < cond.Length; i++)
        {
            if (!cond[i].Equals(""))
            {
                if (cond[i].Equals("null"))
                    condBuilder.Append($"{typeof(T).GetProperties()[i].Name} is {cond[i]} ");
                else 
                    condBuilder.Append($"{typeof(T).GetProperties()[i].Name} = '{cond[i]}' ");
            }
        }

        return condBuilder.ToString();
    }
    
}