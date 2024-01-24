using Microsoft.Extensions.Configuration;
using SharpCountriesProg.Repet;

namespace SharpRepositoryServiceProg.Configurations
{
    public class ConnectionStringHelper
    {
        private readonly FolderFinder folderFinder;
        string repetPart;

        public ConnectionStringHelper()
        {
            folderFinder = new FolderFinder();

            var databaseName = "ReactAspnetExample";
            repetPart =
                $"Database={databaseName};" +
                "Trusted_Connection=True;" +
                "TrustServerCertificate=true;";
        }

        public string Get(IConfiguration configuration)
        {
            var isAppConfigOurChoice = false;
            var result = string.Empty;

            string GetName()
            {
                return ConnectionTypes.DebugSqlLite;
                //return ConnectionNames.ApplicationDbContextConnection;
                
                var machineName = Environment.MachineName;
                if (machineName == "DESKTOP-D1H8AMA") { return ConnectionNames.DesktopComputer; }
                if (machineName == "DESKTOP-FS2O85U") { return ConnectionNames.Surface; }
                return default;
            }

            var name = GetName();

            if (isAppConfigOurChoice)
            {
                result = configuration
                    .GetConnectionString(name);
                return result;
            }

            if (!isAppConfigOurChoice)
            {
                result = Get(name);
                return result;
            }

            return result;
        }

        public string Get(string type)
        {
            if (type == ConnectionNames.DesktopComputer)
            {
                var result = GetForDesktopComputer();
                return result;
            }
            if (type == ConnectionNames.Surface)
            {
                var result = GetForLaptop();
                return result;
            }
            if (type == ConnectionNames.DebugSqlLite)
            {
                var result = GetSqLite();
                return result;
            }
            if (type == ConnectionNames.ReleaseSqlLite)
            {
                return "";
            }

            return "";
        }

        public string GetSqLite()
        {
            var connectionString = "Data Source=" + GetSqLiteFilePath();
            return connectionString;
        }

        public string GetForLaptop()
        {
            return "Server=DESKTOP-FS2O85U;" + repetPart;
        }

        public string GetForDesktopComputer()
        {
            return "Server=DESKTOP-D1H8AMA;" + repetPart;
        }

        public string GetSqLiteFilePath()
        {
            var folderName = "SQLiteDatabase";
            var dbFileName = "MyCoolDataBase.db";
            var dbFolderPath = folderFinder.FindFolder(folderName, Environment.CurrentDirectory, "-4(2,4)");
            dbFolderPath = dbFolderPath.Replace('\\', '/');
            var dbFilePath = dbFolderPath + "/" + dbFileName;
            return dbFilePath;
        }
    }
}
