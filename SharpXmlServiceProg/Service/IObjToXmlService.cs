
namespace SharpObjToXmlServiceProg.Service
{
    public interface IObjToXmlService
    {
        bool Deserialize<T>(string inputString, out T result);
        bool DeserializeFromFile<T>(string filePath, out T result);
        bool Serialize<T>(T objRoot, out string result);
        bool SerializeToFile<T>(string filePath, T objRoot);
    }
}