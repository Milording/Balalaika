using System;
using System.Threading.Tasks;
using BalalaikaAlpha.Hubs;
using BalalaikaAlpha.Services;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Owin;

[assembly: OwinStartup(typeof(BalalaikaAlpha.Startup))]

namespace BalalaikaAlpha
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            GlobalHost.DependencyResolver.Register(
                typeof(BarHub),
                () => new BarHub(new PlaylistService()));

            app.UseCors(CorsOptions.AllowAll);
            app.MapSignalR();
        }
        
    }
}
