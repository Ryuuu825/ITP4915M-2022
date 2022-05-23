using CsvHelper;
using System.Xml;

namespace TheBetterLimited_Server.Helpers
{
    // EN is the default language, the data in database is EN.
    // Therefore, if the language type is "EN", there is no need to localize.
    public class Localizer
    {
        private static readonly string FilePath = AppDomain.CurrentDomain.BaseDirectory + "./resources/localization/{0}.xml";

        public static bool isLanguageSupported<T>( string language)
        {   
            XmlDocument xml = new XmlDocument();
            xml.Load(string.Format(FilePath, typeof(T).Name));
            var nodes = xml.SelectNodes("/root/meta/supported_languages/language");
            foreach (XmlNode node in nodes)
            {
                if(node.InnerText.Equals(language))
                {
                    return true;
                }
            }
            return false;
        }



        public static T TryLocalize<T>(string language , T target)
        {

            XmlDocument xml = new XmlDocument();
            xml.Load(string.Format(FilePath, typeof(T).Name ));

            var entity = target.CopyAs<T>();
            // check if the property has the TranslatableAttribute
            foreach (var item in entity.GetType().GetProperties())
            {
                if (Attribute.IsDefined(item, typeof(AppLogic.Attribute.TranslatableAttribute)))
                {
                    // check if the property value startwith @$
                    if (item.GetValue(entity).ToString().StartsWith("@$"))
                    {
                        var key = item.GetValue(entity).ToString().Substring(2);
                        try
                        {
                            var value = xml.SelectSingleNode($"/root/Translation/{key}/{language}").InnerText;
                            item.SetValue(entity, value);
                        }catch(NullReferenceException e)
                        {
                            // if the language is not supported, place "Translation Not Found" as the result
                            // do not throw an exception
                            item.SetValue(entity, "Translation Not Found" );
                        }
                        
                    }
                }
            }

            return entity;

        }

        public static void UpdateWord<T>(string language , string id , string word)
        {
            ConsoleLogger.Debug($"Add word {word} to {language} Type {typeof(T).Name}");
            XmlDocument xml = new XmlDocument();
            xml.Load(string.Format(FilePath, typeof(T).Name));

            if (!isLanguageSupported<T>(language))
            {
                var lans = xml.SelectSingleNode("/root/meta/supported_languages");
                var newLan = xml.CreateElement("language");
                newLan.InnerXml = $"<code>{language}</code>";
                lans.AppendChild(newLan);
            }

            var Troot = xml.SelectSingleNode($"/root/Translation");
            if (id.Contains("@$"))
            {
                id = id.Substring(2);
            }
            var node = xml.SelectSingleNode( $"/root/Translation/{id}");
            if(node is not null)
            {
                var target = node.SelectSingleNode($"{language}");
                if ( target is not null)
                {
                    target.InnerText = word;
                }
                else
                {
                    var newLan = xml.CreateElement(language);
                    newLan.InnerXml = word;
                    node.AppendChild(newLan);
                }
            }
            else  // this translation with this id is not exist
            {
                var newT = xml.CreateElement(language);
                newT.InnerText = word;
                var newNode = xml.CreateElement(id);
                newNode.InnerXml = newT.OuterXml;
                Troot.AppendChild(newNode);
            }
            xml.Save(string.Format(FilePath, typeof(T).Name ));
        }

        // public static T TryLocalize<T>(string language , T target)
        // {
        //     if (language.ToLower().Equals("en"))  
        //         return target;

        //     try
        //     {
        //         var entity = target.CopyAs<T>();

        //         using (var reader = new StreamReader(string.Format(FilePath , typeof(T).Name , language)))
        //         using (var csv = new CsvReader(reader , System.Globalization.CultureInfo.CurrentCulture))
        //         {
        //             var records = csv.GetRecords<Foo>();
                    
        //             foreach (var item in entity.GetType().GetProperties())
        //             {
        //                 // check if the property value startwith @$
        //                 if (item.GetValue(entity).ToString().StartsWith("@$"))
        //                 {
        //                     var key = item.GetValue(entity).ToString().Substring(2);
        //                     var value = records.FirstOrDefault(x => x.Key == key);
        //                     if (value is null)
        //                     {
        //                         throw new BadArgException("The key is not exist in localization file.");
        //                     }
        //                     item.SetValue(entity, value.Content);
        //                 }
        //             }
        //         }

        //         return entity;
        //     }catch(System.IO.FileNotFoundException e)
        //     {
        //         ConsoleLogger.Debug(e.Message);
        //         throw new BadArgException("The language type not support.");
        //     }
            
        // }
    }

    internal class Foo
    {
        public string Key { get; set; }
        public string Content { get; set; }
    }
}