using System;
using System.Collections.Generic;
using System.Linq;
using BalalaikaAlpha.Models;
using BalalaikaAlpha.Services;
using Microsoft.AspNet.SignalR;
using Newtonsoft.Json;

namespace BalalaikaAlpha.Hubs
{
    public class BarHub : Hub
    {
        private readonly IPlaylistService _playlistService;

        public BarHub(IPlaylistService playlistService)
        {
            _playlistService = playlistService;
        }

        public string Hello(string name) => "Hey " + name;

        public string StartDefaultPlaylist()
        {
            var defaultPlaylist = _playlistService.StartDefaultPlaylist();
            return JsonConvert.SerializeObject(defaultPlaylist);
        }

        public void Next()
        {
            _playlistService.Next();
            Clients.Others.nextSong();
        }
        public void AddPremiumSong(string songId)
        {
            _playlistService.AddPremiumSong(songId);
            Clients.Others.playlistUpdated();
        }

        public void Dislike()
        {
            var isNextNeeded = _playlistService.Dislike();
            if (isNextNeeded)
                Clients.All.nextSong();
        }

        public string GetActualPlaylist() => JsonConvert.SerializeObject(_playlistService.GetCurrentPlaylist());
    }
}