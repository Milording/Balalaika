using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BalalaikaAlpha.Models;
using BalalaikaAlpha.Services;

namespace BalalaikaAlpha.Services
{
    public class PlaylistService : IPlaylistService
    {
        private Playlist premiumPlaylist;
        private Playlist freePlaylist;

        public Playlist CurrentPlaylist => new Playlist(premiumPlaylist.Songs.Concat(freePlaylist.Songs));

        public PlaylistService()
        {
            premiumPlaylist = new Playlist();
            freePlaylist = new Playlist();
        }

        public void AddPremiumSong(string songId)
        {
            throw new NotImplementedException();
        }

        public void Dislike()
        {
            throw new NotImplementedException();
        }

        public Playlist GetCurrentPlaylist()
        {
            throw new NotImplementedException();
        }

        public void Next()
        {
            throw new NotImplementedException();
        }

        public Playlist StartDefaultPlaylist()
        {
            premiumPlaylist = new Playlist();

            freePlaylist = new Playlist()
            {
                Songs = new List<Song>() {
                new Song() { Id="139473"},
                new Song() { Id="38427"},
                new Song() { Id="31423"},
                new Song() { Id="30325"} }
            };

            return CurrentPlaylist;
        }

        
    }
}