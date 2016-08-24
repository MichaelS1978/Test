using System.Data;
using System.Data.SqlServerCe;
using System.IO;
using System.Text.RegularExpressions;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using OnkoSoft.Data.Domain;
using OnkoSoft.Data.Exceptions;

namespace OnkoSoft.Data
{
    public sealed class DatabaseManager
    {
        public enum DatabaseMode
        { 
            Online,
            Offline
        }

        private static volatile DatabaseManager s_Instance;
        private static object s_SyncRoot = new object();
        private static volatile ISessionFactory s_SessionFactory;
        private static DatabaseMode s_DatabaseMode = DatabaseMode.Online; 

        public string ConnectionString { get; set; }
        public string OfflineDatabasePath { get; set; }
        public bool BatchInsertMode { get; set; }

        private DatabaseManager()
        { }

        public static DatabaseManager Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (s_SyncRoot)
                    {
                        if (s_Instance == null)
                            s_Instance = new DatabaseManager();
                    }
                }

                return s_Instance;
            }
        }

        private static void InitializeSessionFactory(string connectionString)
        {
            if (s_SessionFactory == null)
            {
                lock (s_SyncRoot)
                {
                    if (s_SessionFactory == null)
                    {
                        s_SessionFactory = GetFluentConfiguration(connectionString)
#if SQLDBG
                            .Diagnostics(d => d.Enable(true))
                            
#endif
                            .BuildSessionFactory();

#if SQLDBG
                        s_SessionFactory.Statistics.IsStatisticsEnabled = true;

#else
                        s_SessionFactory.Statistics.IsStatisticsEnabled = false;

#endif
                    }
                }
            }
        }

        private static FluentConfiguration GetFluentConfiguration(string connectionString)
        {
            if (s_DatabaseMode == DatabaseMode.Offline)
            {
                return Fluently.Configure()
                    .Database(
                        MsSqlCeConfiguration.Standard.ConnectionString(connectionString)
                        .Driver<NHibernate.Driver.SqlServerCeDriver>()
                        .Dialect<NHibernate.Dialect.MsSqlCe40Dialect>()
#if SQLDBG
                        .ShowSql()
#endif
)
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Patient>());
            }
            else
            {
                return Fluently.Configure()
                    .Database(
                        MsSqlConfiguration.MsSql2008.ConnectionString(connectionString)
                        .Driver<NHibernate.Driver.Sql2008ClientDriver>()
                        .Dialect<NHibernate.Dialect.MsSql2008Dialect>()

#if SQLDBG
                        .ShowSql()
#endif
                        )
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Patient>());
            }
        }

        private void CheckConnectionString()
        {
            if (string.IsNullOrWhiteSpace(ConnectionString))
                throw new DatabaseManagerException("ConnectionString is missing!");
        }

        private void CheckOfflineDatabasePath()
        {
            if (string.IsNullOrWhiteSpace(OfflineDatabasePath))
                throw new DatabaseManagerException("OfflineDatabasePath is missing!");
        }

        private void CreateOfflineDatabaseFile()
        {
            if (File.Exists(OfflineDatabasePath))
            {
                File.Delete(OfflineDatabasePath);
            }

            Directory.CreateDirectory(Path.GetDirectoryName(OfflineDatabasePath));

            SqlCeEngine en = new SqlCeEngine(ConnectionString);
            en.CreateDatabase();
        }

        private void WriteOfflineDatabaseCreateScriptToFile(string scriptFile)
        {
            CheckConnectionString();

            GetFluentConfiguration(ConnectionString)
                .ExposeConfiguration(cfg =>
                {
                    SchemaExport schemaExport = new SchemaExport(cfg);
                    schemaExport.SetOutputFile(scriptFile);
                    schemaExport.Execute(false, false, false);
                })
                .BuildConfiguration();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:SQL-Abfragen auf Sicherheitsrisiken überprüfen")]
        private void CreateOfflineDatabaseStructure(string scriptFile)
        {
            ISession session = OpenSession();

            string scriptContents;
            using (StreamReader sr = new StreamReader(scriptFile))
            {
                scriptContents = sr.ReadToEnd();
            }

            Regex regex = new Regex(@"^\s*\n", RegexOptions.IgnoreCase | RegexOptions.Multiline);
            string[] sqlcommands = regex.Split(scriptContents);

            using (IDbCommand command = session.Connection.CreateCommand())
            {
                foreach (string sqlcmd in sqlcommands)
                {
                    if (sqlcmd.Length > 0)
                    {
                        command.CommandText = sqlcmd;
                        command.CommandType = CommandType.Text;

                        try
                        {
                            command.ExecuteNonQuery();
                        }
                        catch (SqlCeException ex)
                        {
                            if (ex.NativeError != 0)
                                throw;
                        }
                    }
                }
            }

            session.Close();
        }

        public void ConfigureDatabaseMode(DatabaseMode dbMode)
        {
            if (s_SessionFactory != null)
                throw new DatabaseManagerException("Session is already open!");

            s_DatabaseMode = dbMode;
        }

        public void CreateOfflineDatabase()
        {
            CheckOfflineDatabasePath();
            CheckConnectionString();

            CreateOfflineDatabaseFile();

            string scriptFile = Path.GetTempFileName();
            WriteOfflineDatabaseCreateScriptToFile(scriptFile);
            CreateOfflineDatabaseStructure(scriptFile);
        }

        public ISession OpenSession()
        {
            CheckConnectionString();

            InitializeSessionFactory(ConnectionString);

            return s_SessionFactory.OpenSession();
        }

        public void CloseSessionFactory()
        {
            if (s_SessionFactory == null)
                return;

            s_SessionFactory.Close();
            s_SessionFactory = null;
        }
    }
}