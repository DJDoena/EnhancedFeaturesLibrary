using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

// xsd.exe /c /l:cs /f EnhancedFeatures.xsd /n:DoenaSoft.DVDProfiler.EnhancedFeatures

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

                    XmlSerializer.Serialize(xtw, instance);
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

                return (instance);
            }
        }

        public static void Serialize(EnhancedFeatures instance, string fileName)
        {
            using (var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.Read))
            {
                using (var xtw = new XmlTextWriter(fs, Encoding.UTF8))
                {
                    xtw.Formatting = Formatting.Indented;

                    XmlSerializer.Serialize(xtw, instance);
                }
            }
        }

        public void Serialize(string fileName)
        {
            Serialize(this, fileName);
        }
    }
}