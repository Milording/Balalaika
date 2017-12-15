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
            var playlistService = new PlaylistService();
            GlobalHost.DependencyResolver.Register(
                typeof(BarHub),
                () => new BarHub(playlistService));

            app.UseCors(CorsOptions.AllowAll);
            app.MapSignalR();
        }
        
    }
}
