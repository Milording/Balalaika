using BalalaikaAlpha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BalalaikaAlpha.Services
{
    public interface IPlaylistService
    {
        Playlist StartDefaultPlaylist();
        void Next();
        void AddPremiumSong(string songId);
        bool Dislike();
        Playlist GetCurrentPlaylist();
    }
}