using TheBetterLimited_Server.AppLogic.Exceptions;
namespace TheBetterLimited_Server.Helpers.Sql;

public static class QueryStringBuilder
{
    public static readonly string query = "SELECT @ATTRIBUTE FROM @TABLE WHERE @CONDITION";

    public static string GetSqlStatement<T>(string condString , string table)
    {
        string queryStr;
        if (condString.Contains("="))
            throw new BadArgException("The condition string should not contain '='");

        if (condString.Contains(":"))
            queryStr = Helpers.Sql.QueryStringBuilder.CreateSQLQuery( condString , "accounts");
        else 
            queryStr = Helpers.Sql.QueryStringBuilder.LazyCreateSQLQuery<T>( condString, "accounts");
#if DEBUG
        Console.WriteLine(queryStr);
#endif      
        
        return queryStr;
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
        var condBuilder = new StringBuilder();

        var cond = condString.Split(";");
        var pair = cond[0].Split(":");
        
        if (pair[1].Equals("null"))
            condBuilder.Append($" {pair[0]} is {pair[1]}");
        else 
            condBuilder.Append($" {pair[0]} = '{pair[1]}'");
        
        for (var i = 1;  i < cond.Length; i++)
        {
            if (!cond[i].Equals(""))
            {
                pair = cond[i].Split(":");
                if (pair[1].Equals("null"))
                    condBuilder.Append($" AND {pair[0]} is {pair[1]}");
                else
                    condBuilder.Append($" AND {pair[0]} = '{pair[1]}'");
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