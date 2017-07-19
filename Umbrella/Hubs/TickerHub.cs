using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace Umbrella.Mvc.Hubs
{
    public class TickerHub : Hub
    {

        // clientReceiveMessage
        private static Random rng = new Random();

        public static void SendRandom()
        {
            var message = string.Format("Message: {0}", rng.Next(0, 100));
            var hubContext = GlobalHost.ConnectionManager.GetHubContext<TickerHub>();
            hubContext.Clients.All.clientReceiveMessage(message);
        }



#if DEBUG
        public override Task OnConnected()
        {
            System.Diagnostics.Trace.TraceInformation($"TickerHub.OnReconnected: {this.Context.ConnectionId}");
            return base.OnConnected();
        }
        public override Task OnDisconnected(bool stopCalled)
        {
            System.Diagnostics.Trace.TraceInformation($"TickerHub.OnReconnected: {this.Context.ConnectionId}, stopCalled={stopCalled}");
            return base.OnDisconnected(stopCalled);
        }
        public override Task OnReconnected()
        {
            System.Diagnostics.Trace.TraceInformation($"TickerHub.OnReconnected: {this.Context.ConnectionId}");
            return base.OnReconnected();
        }
#endif

    }
}