using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using Umbrella.Mvc.Hubs;

namespace Umbrella.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            RandomTicker.Instance.WakeUp();
            return View();
        }
    }


    /// <summary>
    /// Singleton, to guarantee
    /// </summary>
    public class RandomTicker
    {
        private static readonly Lazy<RandomTicker> instance = new Lazy<RandomTicker>();
        private static readonly TimeSpan updateInterval = TimeSpan.FromMilliseconds(500);
        private readonly Timer timer;

        public RandomTicker()
        {
            timer = new Timer(Tick, null, updateInterval, updateInterval); // loop controller
        }

        public static RandomTicker Instance
        {
            get { return instance.Value; }
        }

        /// <summary>
        /// Guarantee that the object will be called / instantiated at least once.
        /// </summary>
        public void WakeUp()
        {
#if DEBUG
            System.Diagnostics.Trace.TraceInformation("RandomTicker.WakeUp();");
#endif
            Console.WriteLine("RandomTicker.WakeUp();");
        }

        /// <summary>
        /// Will trigger the message to all clients.
        /// </summary>
        /// <param name="state">Not necessary.</param>
        private void Tick(object state)
        {
            TickerHub.SendRandom();
        }
    }
        



}