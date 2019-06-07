using Microsoft.AspNet.SignalR;
using MixERP.Net.ApplicationState.Cache;
using System;

namespace MixERP.Net.FrontEnd.Hubs
{
    [CLSCompliant(false)]
    public class BaseHub : Hub
    {
        public void Terminate(int counter)
        {
            string catalog = AppUsers.GetCurrentUserDB();
            this.Clients.All.terminate(counter, catalog);
        }
    }
}