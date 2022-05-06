﻿namespace TheBetterLimited_Server.Helpers.File;

public class DynamicFile
{
    public static readonly string DefaultFileDir = AppDomain.CurrentDomain.BaseDirectory + "/template/";

    /**
     * <summary>
     *     Replace the {key} with value provided passing in. <br></br>
     *     The argv shoule provide keys and values like "key=value;key1=value"
     * </summary>
     */
    public static string UpdatePlaceHolder(string FileName, string argv, string prefix = "{", string postfix = "}")
    {
        var buffer = new StringBuilder(System.IO.File.ReadAllText(DefaultFileDir + FileName));
        var KeyValuePairs = argv.Split(";");
        for (var i = 0; i < KeyValuePairs.Length; i++)
        {
            var para = KeyValuePairs[i].Split("=");
            buffer.Replace($"{prefix}{para[0]}{postfix}", $"{para[1]}");
        }

        return buffer.ToString();
    }
}