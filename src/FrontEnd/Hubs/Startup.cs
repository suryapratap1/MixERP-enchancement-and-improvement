using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(MixERP.Net.FrontEnd.Hubs.Startup))]

namespace MixERP.Net.FrontEnd.Hubs
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}