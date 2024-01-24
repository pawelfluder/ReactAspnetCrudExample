using System.Xml.Serialization;

namespace SharpObjToXmlServiceProg.Service
{
    internal class ObjToXmlService : IObjToXmlService
    {
        private XmlSerializer serializer;
        private Type objType;

        public bool Serialize<T>(T objRoot, out string result)
        {
            try
            {
                SetSerializer<T>();
                
                using (var stringWriter = new StringWriter())
                {
                    serializer.Serialize(stringWriter, objRoot);
                    result = stringWriter.ToString();
                }
                return true;
            }
            catch
            {
                result = default;
                return false;
            }
        }

        public bool SerializeToFile<T>(string filePath, T objRoot)
        {
            try
            {
                SetSerializer<T>();
                using (var stream = new StreamWriter(filePath))
                {
                    serializer.Serialize(stream, objRoot);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Deserialize<T>(string inputString, out T result)
        {
            try
            {
                SetSerializer<T>();
                using (var stringReader = new StringReader(inputString))
                {
                    var tmp = serializer.Deserialize(stringReader);
                    result = (T)tmp;
                }
                return true;
            }
            catch
            {
                result = default;
                return false;
            }
        }

        public bool DeserializeFromFile<T>(string filePath, out T result)
        {
            try
            {
                SetSerializer<T>();
                using (var stream = new StreamReader(filePath))
                {
                    var tmp = serializer.Deserialize(stream);
                    result = (T)tmp;
                }
                return true;
            }
            catch
            {
                result = default;
                return false;
            }
        }

        private void SetSerializer<T>()
        {
            var type = typeof(T);
            if (type == objType)
            {
                return;
            }

            serializer = new XmlSerializer(type);
            objType = type;
        }
    }
}
