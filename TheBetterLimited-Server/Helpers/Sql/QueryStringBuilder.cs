using System.Reflection;

namespace TheBetterLimited_Server.Helpers.Sql;

public static class QueryStringBuilder
{
    public static readonly string query = "SELECT @ATTRIBUTE FROM @TABLE WHERE @CONDITION";
    
    // Two type of condString
    // lazy one : value;value;value
    // readable one : key=value;key=value;
    public static string CreateSQLQuery<T>(string condString)
    {
        var builder = new StringBuilder(query);
        var condBuilder = new StringBuilder();
        var cond = condString.Split(";");

        var pair = cond[0].Split("=");
        condBuilder.Append($" {pair[0]} = '{pair[1]}'");

        for (var i = 1;  i < cond.Length; i++)
        {
            if (!cond[i].Equals(""))
            {
                pair = cond[i].Split("=");
                condBuilder.Append($" AND {pair[0]} = '{pair[1]}'");
            }

        }
        builder.Replace("@TABLE", typeof(T).Name.ToLower() + "s" );
        builder.Replace("@ATTRIBUTE", "*");
        builder.Replace("@CONDITION", condBuilder.ToString());
        return builder.ToString();

    }
    public static string LazyCreateSQLQuery<T>(string condString)
    {
        var builder = new StringBuilder(query);
        var condBuilder = new StringBuilder();
        var cond = condString.Split(";");
        var counter = 0; // check how many condition

        if (!cond[0].Equals(""))
        {
            condBuilder.Append($"{typeof(T).GetProperties()[0].Name} = '{cond[0]}' ");
            counter++;
        }

        for (var i = 1; i < typeof(T).GetProperties().Length && i < cond.Length; i++)
        {
            if (!cond[i].Equals(""))
            {
                if (counter!=0)
                    condBuilder.Append($" AND {typeof(T).GetProperties()[i].Name} = '{cond[i]}' ");
                else 
                    condBuilder.Append($" {typeof(T).GetProperties()[i].Name} = '{cond[i]}' ");
  
            }
        }
        builder.Replace("@TABLE", typeof(T).Name.ToLower() + "s" );
        builder.Replace("@ATTRIBUTE", "*");
        builder.Replace("@CONDITION", condBuilder.ToString());
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