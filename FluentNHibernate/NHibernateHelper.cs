using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentNHibernate
{
    public class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;

        private static ISessionFactory SessionFactory
        {
            get{
                if(_sessionFactory == null)
                {
                    string connection = "Server=localhost;Database=newdb;Uid=root;Pwd=root;";
                    _sessionFactory = Fluently.Configure()
                        .Database(MySQLConfiguration.Standard
                        .ConnectionString(connection))
                        .Mappings(m=>m.FluentMappings.AddFromAssemblyOf<Program>())
                        .BuildSessionFactory();
                }
                return _sessionFactory;
            }
        }
        public static ISession GetSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}
