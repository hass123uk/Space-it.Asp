using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Context;

namespace Space_it.Core.NHibernate_Data
{
    public class NHibernateSessionManager
    {
        public static ISessionFactory SessionFactory { get; set; }
        public static string ConnectionString { get; set; }

        static NHibernateSessionManager()
        {
            ConnectionString = string.Empty;
        }

        private static ISessionFactory GetFactory<T>() where T : ICurrentSessionContext
        {
            return Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012
                    .ConnectionString(c => c.Is(ConnectionString)))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<NHibernateSessionManager>())
                .CurrentSessionContext<T>().BuildSessionFactory();
        }

        public static ISession GetCurrentSession()
        {
            if (SessionFactory == null)
            {
                SessionFactory = HttpContext.Current != null
                    ? GetFactory<WebSessionContext>()
                    : GetFactory<ThreadStaticSessionContext>();
            }

            try
            {
                if (CurrentSessionContext.HasBind(SessionFactory))
                {
                    return SessionFactory.GetCurrentSession();
                }
            }
            catch (Exception e)
            {
                SessionFactory = GetFactory<ThreadStaticSessionContext>();
            }

            var session = SessionFactory.OpenSession();
            CurrentSessionContext.Bind(session);
            return session;
        }

        public static void CloseSession()
        {
            if (SessionFactory != null && CurrentSessionContext.HasBind(SessionFactory))
            {
                var session = CurrentSessionContext.Unbind(SessionFactory);
                session.Close();
            }
        }

        public static void CommitSession(ISession session)
        {
            try
            {
                session.Transaction.Commit();
            }
            catch (Exception e)
            {
                session.Transaction.Rollback();
                throw;
            }
        }
    }
}