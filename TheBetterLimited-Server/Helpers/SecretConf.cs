using System.Collections;

namespace TheBetterLimited_Server.Helpers;

public class SecretConf
{
    public static SecretConf Instance = new("etc/secret.conf");
    private readonly Hashtable table;

    public SecretConf(string path)
    {
        var buffer = System.IO.File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + path);
        table = new Hashtable();

        for (var i = 0; i < buffer.Length; i++)
            if (buffer[i].StartsWith("#") || buffer[i].Equals("")) // ignore the comment
            {
            }

            else
            {
                var tmp = buffer[i].Split("=", 2);

                table.Add(tmp[0], tmp[1].Trim('"'));
            }
    }

    public string this[string key]
    {
        get => GetValue(key);
        private set { }
    }


    public string GetValue(string key)
    {
        if (table.ContainsKey(key))
            return (string) table[key];

        throw new KeyNotFoundException();
    }
}