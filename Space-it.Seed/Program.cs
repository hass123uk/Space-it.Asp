
using System;
using System.Configuration;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Context;
using NHibernate.Linq;
using NHibernate.Tool.hbm2ddl;
using Space_it.Core.NHibernate_Data;
using System.Linq;
using Space_it.Core.Entities;
using System.Collections.Generic;

namespace Space_it.Seed
{
    public class Program
    {
        private static ISession _session;

        public static void Main(string[] args)
        {
            var config = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012
                    .ConnectionString(c => c.FromConnectionStringWithKey("db")))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<NHibernateSessionManager>());

            _session = config.ExposeConfiguration(c => new SchemaUpdate(c).Execute(true, true))
                .BuildConfiguration()
                .BuildSessionFactory()
                .OpenSession();

            Console.WriteLine("DB Config done. Seed Starting..");

            Seed();

            Console.WriteLine("Seed Done");
        }

        public static void Seed()
        {
            using (var transaction = _session.BeginTransaction())
            {
                var projects = _session.Query<Project>().ToList();

                var msg = new Message
                {
                    Text = "This is a message",
                    Modified = DateTime.UtcNow,
                    Created = DateTime.UtcNow
                };

                AddProject(projects, "Dev", new List<Message> { msg });



                transaction.Commit();
            }
        }

        private static void AddProject(List<Project> projects, string name, List<Message> messages)
        {
            var project = projects.FirstOrDefault(p => p.Name == name);
            if (project == null)
            {
                _session.Save(new Project
                {
                    Name = name,
                    Messages = messages,
                    Modified = DateTime.UtcNow,
                    Created = DateTime.UtcNow
                });
            }
            else
            {
                Console.WriteLine("Project with that name already exists");
            }
        }
    }
}
