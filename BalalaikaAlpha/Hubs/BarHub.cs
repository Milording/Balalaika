using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BalalaikaAlpha.Services;
using Microsoft.AspNet.SignalR;
using Newtonsoft.Json;

namespace BalalaikaAlpha.Hubs
{
    public class BarHub : Hub
    {
        private IPlaylistService playlistService;

        public BarHub(IPlaylistService playlistService)
        {
            this.playlistService = playlistService;
        }

        public string Hello(string name)
        {
            return "Hey " + name;
        }

        public string StartDefaultPlaylist()
        {
            var defaultPlaylist = playlistService.StartDefaultPlaylist();
            return JsonConvert.SerializeObject(defaultPlaylist);
        }

        public void Next()
        {
            this.playlistService.Next();
            Clients.Others.nextSong();
        }
        public void AddPremiumSong(string songId)
        {
            this.playlistService.AddPremiumSong(songId);
            Clients.Others.playlistUpdated();
        }

        public void Dislike()
        {

        }

    }
}