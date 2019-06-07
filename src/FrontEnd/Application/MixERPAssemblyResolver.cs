using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using Serilog;

namespace MixERP.Net.FrontEnd.Application
{
    public class ClassicAssemblyResolver : DefaultAssembliesResolver
    {
        public override ICollection<Assembly> GetAssemblies()
        {
            ICollection<Assembly> baseAssemblies = base.GetAssemblies();
            List<Assembly> assemblies = new List<Assembly>(baseAssemblies);

            Type type = typeof(ApiController);

            IEnumerable<Assembly> items = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => p.IsSubclassOf(type)).Select(t => t.Assembly);

            foreach (Assembly item in items)
            {
                baseAssemblies.Add(item);
            }

            var names = string.Join(Environment.NewLine, baseAssemblies.Select(x => x.GetName().Name));
            Log.Information("Registered the following assemblies. {names}", names);

            return assemblies;
        }
    }

    public class MixERPAssemblyResolver : DefaultAssembliesResolver
    {
        public override ICollection<Assembly> GetAssemblies()
        {
            ICollection<Assembly> baseAssemblies = base.GetAssemblies();
            List<Assembly> assemblies = new List<Assembly>(baseAssemblies);

            try
            {
                Type type = typeof(ApiController);

                IEnumerable<Assembly> items = AppDomain.CurrentDomain.GetAssemblies()
                    .SelectMany(s => s.GetTypes())
                    .Where(p => p.IsSubclassOf(type)).Select(t => t.Assembly);

                foreach (Assembly item in items)
                {
                    baseAssemblies.Add(item);
                }

                var names = string.Join(Environment.NewLine, baseAssemblies.Select(x => x.GetName().Name));
                Log.Information("Registered the following assemblies. {names}", names);
            }
            catch (ReflectionTypeLoadException ex)
            {
                Log.Information("An error occured while registering assemblies. {ex}", ex);

                foreach (Exception exception in ex.LoaderExceptions)
                {
                    Log.Error("Could not load assemblies containing MixERP Web API. Exception: {Exception}", exception);
                }
            }

            return assemblies;
        }
    }
}