using CsvHelper;
using CsvHelper.Configuration;
using System.Collections;
using System.Globalization;

namespace SharpCSVServiceProg.Service
{
    // https://joshclose.github.io/CsvHelper

    public class CsvService
    {
        private readonly DelimiterHelper helper;
        private string delimiter;

        public CsvService()
        {
            helper = new DelimiterHelper();
            delimiter = ",";
        }

        public void SetDelimiter(string inputString)
        {
            if (helper.CheckAndConvert(ref inputString))
            {
                delimiter = inputString;
            }
        }

        public List<T> ReadString<T>(string inputString) where T : class
        {
            try
            {
                List<T> result;
                using (var reader = new StringReader(inputString))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var tmp = csv.GetRecords<T>();
                    result = tmp.ToList();
                }
                return result;
            }
            catch
            {
                return default;
            }
        }

        public static StreamReader StreamReaderFromString(string s)
        {
            var stream = GenerateStreamFromString(s);
            var streamReader = new StreamReader(stream);
            return streamReader;
        }

        public static Stream GenerateStreamFromString(string s)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }

        public List<T> Read<T>(string filePath) where T : class
        {
            try
            {
                List<T> result;
                using (var reader = new StreamReader(filePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var tmp = csv.GetRecords<T>();
                    result = tmp.ToList();
                }
                return result;
            }
            catch
            {
                return default;
            }
        }

        public List<object?> Read(string filePath, Type type)
        {
            try
            {
                List<object?> result;
                using (var reader = new StreamReader(filePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    result = csv.GetRecords(type).ToList();
                }

                return result;
            }
            catch
            {
                return default;
            }
        }

        public bool Export(IList objList, string filePath)
        {
            try
            {
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    Delimiter = delimiter,
                };

                using (var writer = new StreamWriter(filePath, false))
                using (var csvWriter = new CsvWriter(writer, config))
                {
                    csvWriter.WriteRecords(objList);
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
