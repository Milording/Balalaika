﻿using System;
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

        private int dislikes;

        public Playlist CurrentPlaylist => new Playlist(premiumPlaylist.Songs.Concat(freePlaylist.Songs));

        public PlaylistService()
        {
            premiumPlaylist = new Playlist();
            freePlaylist = new Playlist();
            this.dislikes = 0;
        }

        public void AddPremiumSong(string songId)
        {
            throw new NotImplementedException();
        }

        public bool Dislike()
        {
            this.dislikes++;
            if (this.dislikes >= 10)
                return true;
            else return false;
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