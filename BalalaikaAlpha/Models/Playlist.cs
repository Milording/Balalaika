using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BalalaikaAlpha.Models
{
    public class Playlist
    {
        public List<Song> Songs { get; set; }

        public Playlist() => Songs = new List<Song>();
        
        public Playlist(List<Song> songs)
        {
            Songs = songs;
        }

    }
}