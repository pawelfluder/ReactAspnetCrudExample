using SharpCSVServiceProg.Service;
using System.Reflection;

namespace SharpCountriesProg.Models
{
    internal class Seeder
    {
        public List<Country> GetDefault()
        {
            var assemblyName = Assembly.GetExecutingAssembly().GetName();
            var embeddedResourceFilePath = "EmbededResources.CountriesDataSeeding.csv";
            var embeddedString = GetEmbeddedResource(assemblyName, embeddedResourceFilePath);
            var csvService = new CsvService();
            var result = csvService.ReadString<Country>(embeddedString);
            return result;
        }

        public string GetEmbeddedResource(AssemblyName assemblyName, string filename)
        {
            var namespacename = assemblyName.Name;
            var resourceName = namespacename + "." + filename;
            var assembly = Assembly.Load(assemblyName);

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                if (stream == null)
                {
                    var msg = GetType().Name + " - Please check assembly file path, bacause file stream was null!";
                    throw new Exception(msg);
                }

                using (StreamReader reader = new StreamReader(stream))
                {
                    string result = reader.ReadToEnd();
                    return result;
                }
            }
        }
    }
}
