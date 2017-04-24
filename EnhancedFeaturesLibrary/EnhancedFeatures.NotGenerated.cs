using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

// xsd.exe /c /l:cs /f EnhancedFeatures.xsd /n:DoenaSoft.DVDProfiler.EnhancedFeatures

namespace DoenaSoft.DVDProfiler.EnhancedFeatures
{
    public sealed partial class EnhancedFeaturesList
    {
        private static XmlSerializer s_XmlSerializer;

        [XmlIgnore]
        public static XmlSerializer XmlSerializer
        {
            get
            {
                if (s_XmlSerializer == null)
                {
                    s_XmlSerializer = new XmlSerializer(typeof(EnhancedFeaturesList));
                }

                return (s_XmlSerializer);
            }
        }

        public static EnhancedFeaturesList Deserialize(String fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                EnhancedFeaturesList instance = (EnhancedFeaturesList)(XmlSerializer.Deserialize(fs));

                return (instance);
            }
        }

        public static void Serialize(EnhancedFeaturesList instance
            , String fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.Read))
            {
                using (XmlTextWriter xtw = new XmlTextWriter(fs, Encoding.UTF8))
                {
                    xtw.Formatting = Formatting.Indented;

                    XmlSerializer.Serialize(xtw, instance);
                }
            }
        }

        public void Serialize(String fileName)
        {
            Serialize(this, fileName);
        }
    }

    public sealed partial class EnhancedFeatures
    {
        private static XmlSerializer s_XmlSerializer;

        [XmlIgnore]
        public static XmlSerializer XmlSerializer
        {
            get
            {
                if (s_XmlSerializer == null)
                {
                    s_XmlSerializer = new XmlSerializer(typeof(EnhancedFeatures));
                }

                return (s_XmlSerializer);
            }
        }

        public static EnhancedFeatures Deserialize(String fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                EnhancedFeatures instance = (EnhancedFeatures)(XmlSerializer.Deserialize(fs));

                return (instance);
            }
        }

        public static void Serialize(EnhancedFeatures instance
            , String fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.Read))
            {
                using (XmlTextWriter xtw = new XmlTextWriter(fs, Encoding.UTF8))
                {
                    xtw.Formatting = Formatting.Indented;

                    XmlSerializer.Serialize(xtw, instance);
                }
            }
        }

        public void Serialize(String fileName)
        {
            Serialize(this, fileName);
        }
    }
}