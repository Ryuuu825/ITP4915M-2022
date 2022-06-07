using System.Xml;

namespace TheBetterLimited_Server.Helpers
{
    // EN is the default language, the data in database is EN.
    // Therefore, if the language type is "EN", there is no need to localize.
    public class Localizer
    {
        private static readonly string FilePath = AppDomain.CurrentDomain.BaseDirectory + "./resources/localization/{0}.xml";

        private static bool isLanguageSupported<T>( string language)
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

        public static bool isTransalatable<T>()
        {
            dynamic instance = Activator.CreateInstance(typeof(T));
            foreach (var property in typeof(T).GetProperties())
            {
                if (Attribute.IsDefined(property, typeof(AppLogic.Attribute.TranslatableAttribute)))
                {
                    return true;
                }
            }
            return false;
        }



        public static T TryLocalize<T>(string language , T target)
        {
            XmlDocument xml = new XmlDocument();

            if (! isTransalatable<T>())
                return target;

            xml.Load(string.Format(FilePath, typeof(T).Name ));

            var entity = target.TryCopy<T>();
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

            xml = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();

            return entity;
        }

        public static void UpdateWord<T>(string language , string id , string word)
        {
            XmlDocument xml = new XmlDocument();

            xml.Load(string.Format(FilePath, typeof(T).Name));

            if (!isLanguageSupported<T>(language))
            {
                var lans = xml.SelectSingleNode("/root/meta/supported_languages");
                var newLan = xml.CreateElement("language");
                newLan.InnerXml = $"<code>{language}</code>";
                lans.AppendChild(newLan);

                lans = null;
                newLan = null;
                GC.Collect();
                GC.WaitForPendingFinalizers();
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

                newT = null;
                newNode = null;
            }
            xml.Save(string.Format(FilePath, typeof(T).Name ));

            Troot = null;
            node = null;
            xml = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }

    internal class Foo
    {
        public string Key { get; set; }
        public string Content { get; set; }
    }
}