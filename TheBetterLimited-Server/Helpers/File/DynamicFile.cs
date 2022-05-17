namespace TheBetterLimited_Server.Helpers.File;

using TheBetterLimited_Server.AppLogic.Models;
public class DynamicFile
{
    public static readonly string DefaultFileDir = AppDomain.CurrentDomain.BaseDirectory + "/resources/";

    /**
     * <summary>
     *     Replace the {key} with value provided passing in. <br></br>
     *     The argv shoule provide keys and values like "key=value;key1=value"
     * </summary>
     */
    public static string UpdatePlaceHolder(string FileName, in List<UpdateObjectModel> model, string prefix = "{", string postfix = "}")
    {
        var buffer = new StringBuilder(System.IO.File.ReadAllText(DefaultFileDir + FileName));
            
        foreach (var item in model)
        {
             buffer.Replace($"{prefix}${item.Attribute}{postfix}", $"{item.Value}");
        }
        return buffer.ToString();
    }
}