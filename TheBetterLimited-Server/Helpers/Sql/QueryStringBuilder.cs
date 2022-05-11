using System.Reflection;

namespace TheBetterLimited_Server.Helpers.Sql;

public static class QueryStringBuilder
{
    public static readonly string query = "SELECT @ATTRIBUTE FROM @TABLE WHERE @CONDITION";

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
    
    // Two type of condString
    // lazy one : value;value;value
    // readable one : key=value;key=value;
    public static string CreateSQLQuery<T>(string condString)
    {
        var builder = new StringBuilder(query);
       
        builder.Replace("@TABLE", typeof(T).Name.ToLower() + "s" );
        builder.Replace("@ATTRIBUTE", "*");
        builder.Replace("@CONDITION", ConditionBuilder(condString));
        return builder.ToString();

    }
    
    public static string CreateSQLQuery(string condString , string table)
    {
        var builder = new StringBuilder(query);
        builder.Replace("@TABLE", table );
        builder.Replace("@ATTRIBUTE", "*");
        builder.Replace("@CONDITION", ConditionBuilder(condString));
        return builder.ToString();
    }
    public static string LazyCreateSQLQuery<T>(string condString)
    {
        var builder = new StringBuilder(query);
        
        builder.Replace("@TABLE", typeof(T).Name.ToLower() + "s" );
        builder.Replace("@ATTRIBUTE", "*");
        builder.Replace("@CONDITION", LazyConditionBuilder<T>(condString));
        return builder.ToString();

    }
    
    public static string LazyCreateSQLQuery<T>(string condString , string table)
    {
        var builder = new StringBuilder(query);
       
        builder.Replace("@TABLE", table );
        builder.Replace("@ATTRIBUTE", "*");
        builder.Replace("@CONDITION", LazyConditionBuilder<T>(condString));
        return builder.ToString();

    }
    // public static void Create(object data, string queryString)
    // {
    //     var builder = new StringBuilder(query);
    //     var condBuilder = new StringBuilder();
    //
    //
    //     MemberInfo[] infos = type.GetProperties();
    //     for (var i = 0; i < infos.Length; i++)
    //         // Display name and type of the member of 'MyClass'.
    //         Console.WriteLine("'{0}' is a {1}", infos[i].Name, infos[i].MemberType);
    //
    //     builder.Replace("@TABLE", type.Name);
    //     builder.Replace("@ATTRIBUTE", "*");
    //     Console.WriteLine(builder.ToString());
    // }
    //
    // public static void Create(string table, string queryString)
    // {
    //     var argv = queryString.Split(";");
    //     for (var i = 0; i < argv.Length; i++) Console.WriteLine(argv[i]);
    //     Console.WriteLine(argv[argv.Length - 1].Equals(""));
    // }
}