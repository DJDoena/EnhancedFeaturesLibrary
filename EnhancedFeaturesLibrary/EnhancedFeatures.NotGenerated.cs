using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

// xsd.exe /c /l:cs /f /n:DoenaSoft.DVDProfiler.EnhancedFeatures EnhancedFeatures.xsd

namespace DoenaSoft.DVDProfiler.EnhancedFeatures
{
    public sealed partial class EnhancedFeaturesList
    {
        private static XmlSerializer _xmlSerializer;

        [XmlIgnore]
        public static XmlSerializer XmlSerializer
        {
            get
            {
                if (_xmlSerializer == null)
                {
                    _xmlSerializer = new XmlSerializer(typeof(EnhancedFeaturesList));
                }

                return _xmlSerializer;
            }
        }

        public static EnhancedFeaturesList Deserialize(string fileName)
        {
            using (var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                var instance = (EnhancedFeaturesList)(XmlSerializer.Deserialize(fs));

                return instance;
            }
        }

        public static void Serialize(EnhancedFeaturesList instance, string fileName)
        {
            using (var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.Read))
            {
                using (var xtw = new XmlTextWriter(fs, Encoding.UTF8))
                {
                    xtw.Formatting = Formatting.Indented;
                    xtw.Namespaces = false;

                    var ns = new XmlSerializerNamespaces();
                    ns.Add(string.Empty, string.Empty);

                    XmlSerializer.Serialize(xtw, instance, ns);
                }
            }
        }

        public void Serialize(string fileName)
        {
            Serialize(this, fileName);
        }
    }

    public sealed partial class EnhancedFeatures
    {
        private static XmlSerializer _xmlSerializer;

        [XmlIgnore]
        public static XmlSerializer XmlSerializer
        {
            get
            {
                if (_xmlSerializer == null)
                {
                    _xmlSerializer = new XmlSerializer(typeof(EnhancedFeatures));
                }

                return _xmlSerializer;
            }
        }

        public static EnhancedFeatures Deserialize(string fileName)
        {
            using (var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                var instance = (EnhancedFeatures)(XmlSerializer.Deserialize(fs));

                return instance;
            }
        }

        public static void Serialize(EnhancedFeatures instance, string fileName)
        {
            using (var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.Read))
            {
                using (var xtw = new XmlTextWriter(fs, Encoding.UTF8))
                {
                    xtw.Formatting = Formatting.Indented;
                    xtw.Namespaces = false;

                    var ns = new XmlSerializerNamespaces();
                    ns.Add(string.Empty, string.Empty);

                    XmlSerializer.Serialize(xtw, instance, ns);
                }
            }
        }

        public void Serialize(string fileName)
        {
            Serialize(this, fileName);
        }
    }
}