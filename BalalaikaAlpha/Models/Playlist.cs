using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BalalaikaAlpha.Models
{
    public class Playlist
    {
        public IEnumerable<Song> Songs { get; set; }

        public Playlist() => Songs = new List<Song>();
        
        public Playlist(IEnumerable<Song> songs)
        {
            Songs = songs;
        }

    }
}