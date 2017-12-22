using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Architecture.SharedLibrary
{
    public class XMLSerializer
    {
        public static string Serialize(object o)
        {
            StringWriter sw = new StringWriter();
            XmlTextWriter tw = null;
            try
            {
                XmlSerializer serializer = new XmlSerializer(o.GetType());
                tw = new XmlTextWriter(sw);
                serializer.Serialize(tw, o);
            }
            catch (Exception ex)
            {
                //Handle Exception Code
            }
            finally
            {
                sw.Close();
                if (tw != null)
                {
                    tw.Close();
                }
            }
            return sw.ToString();
        }
        public static T Deserialize<T>(string xml)
        {
            T obj = default(T);
            try
            {
                using (var strReader = new StringReader(xml))
                {
                    var serializer = new XmlSerializer(typeof(T));
                    using (var xmlReader = new XmlTextReader(strReader))
                    {
                        obj = (T)serializer.Deserialize(xmlReader);
                    }
                }
            }
            catch (Exception exp)
            {
                //Handle Exception Code
            }

            return obj;
        }
    }
}
