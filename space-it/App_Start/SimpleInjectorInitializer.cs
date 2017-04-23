using System.Linq;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using SimpleInjector.Integration.WebApi;
using Space_it.Core.Repositories.Impl;
using Space_it.Core.Services.Impl;
using Space_it.Web;

[assembly: WebActivatorEx.PostApplicationStartMethod(typeof(SimpleInjectorInitializer), "Initialize")]
namespace Space_it.Web
{
    public static class SimpleInjectorInitializer
    {
        /// <summary>Initialize the container and register it as MVC3 Dependency Resolver.</summary>
        public static void Initialize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            InitializeContainer(container);

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());

            container.RegisterMvcIntegratedFilterProvider();

            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            container.Verify();

            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }

        private static void InitializeContainer(Container container)
        {
            var assembly = typeof(NhUserRepo).Assembly;

            foreach (
                var exportedType in
                assembly.GetExportedTypes()
                    .Where(t => t.Namespace == "Space_it.Core.Repositories.Impl" && !t.IsAbstract))
            {
                var i = exportedType.GetInterfaces();
                container.Register(i.Last(), exportedType, Lifestyle.Transient);
            }

            assembly = typeof(AuthService).Assembly;

            foreach (
                var exportedType in
                assembly.GetExportedTypes()
                    .Where(t => t.Namespace == "Space_it.Core.Services.Impl" && !t.IsAbstract))
            {
                var i = exportedType.GetInterfaces();
                container.Register(i.Last(), exportedType, Lifestyle.Transient);
            }
        }
    }
}