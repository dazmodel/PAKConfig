using System;
using System.Reflection;
using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Conventions.Helpers;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System.IO;

namespace PAK_Command_Editor.Repository
{
    public static class PAKDataSessionFactory
    {
        private static String _dbConnectionString = "data source={0}";
        private static String _dbFile = "C:\\PAK.sqlite";
        private static Boolean _overwriteExisting = false;
        private static ISessionFactory _sessionFactory;

        public static String DbFileName
        {
            get { return _dbFile; }
            set { _dbFile = value; }
        }

        public static Boolean OverwriteExistingDb
        {
            get { return _overwriteExisting; }
            set { _overwriteExisting = value; }
        }

        public static void Init(String dbFileName, Boolean overwriteExistingDb)
        {
            _dbFile = dbFileName;
            _overwriteExisting = overwriteExistingDb;
            _sessionFactory = CreateSessionFactory();
        }

        public static ISession GetSession()
        {
            return _sessionFactory.OpenSession();
        }

        public static IStatelessSession GetStatelessSession()
        {
            return _sessionFactory.OpenStatelessSession();
        }

        private static ISessionFactory CreateSessionFactory()
        {
            return Fluently.Configure()
                .Database(
                    SQLiteConfiguration.Standard.ConnectionString(x=>x.Is(String.Format(_dbConnectionString, _dbFile)))
                )
                .Mappings(m =>m.AutoMappings.Add(CreateMappings))
                .ExposeConfiguration(BuildSchema)
                .BuildSessionFactory();
        }

        // Returns our mappings
        private static AutoPersistenceModel CreateMappings()
        {
            return AutoMap
                .Assembly(Assembly.GetAssembly(typeof(PAKDataSessionFactory)), new PAKAutoMappingConfig())
                .Where(t => t.Namespace != null && t.Namespace.Equals("PAK_Command_Editor.Entities"))
                .Conventions.Setup(c => c.Add(DefaultCascade.SaveUpdate()));
        }

        private static void BuildSchema(Configuration config)
        {
            // delete the existing db on each run
            if ((_overwriteExisting) && (File.Exists(_dbFile)))
                File.Delete(_dbFile);

            // this NHibernate tool takes a configuration (with mapping info in)
            // and exports a database schema from it
            new SchemaUpdate(config).Execute(false, true);
        }
    }
}
