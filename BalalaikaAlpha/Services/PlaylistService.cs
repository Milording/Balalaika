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
        private Playlist _premiumPlaylist;
        private Playlist _freePlaylist;

        private int _dislikes;

        public Playlist CurrentPlaylist
        {
            get
            {
                if (!_premiumPlaylist.Songs.Any())
                    return _freePlaylist;
                var newList = _premiumPlaylist.Songs.ToList();
                newList.AddRange(_freePlaylist.Songs);
                return new Playlist(newList);
            }
        }

        public PlaylistService()
        {
            _premiumPlaylist = new Playlist();
            _freePlaylist = new Playlist();
            _dislikes = 0;
        }

        public void AddPremiumSong(string songId)
        {
            _premiumPlaylist.Songs.Add(new Song(songId));
        }

        public bool Dislike()
        {
            _dislikes++;
            return _dislikes >= 10;
        }

        public Playlist GetCurrentPlaylist()
        {
            return CurrentPlaylist;
        }

        public void Next()
        {
            throw new NotImplementedException();
        }

        public Playlist StartDefaultPlaylist()
        {
            _premiumPlaylist = new Playlist();
            _freePlaylist = new Playlist
            {
                Songs = new List<Song> {
                new Song { Id="139473"},
                new Song { Id="38427"},
                new Song { Id="31423"},
                new Song { Id="30325"} }
            };

            return CurrentPlaylist;
            
        }

        
    }
}