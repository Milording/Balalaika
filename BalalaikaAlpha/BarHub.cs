using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace BalalaikaAlpha
{
    public class BarHub : Hub
    {
        public string Hello(string name)
        {
            return "Hey " + name;
        }
    }
}