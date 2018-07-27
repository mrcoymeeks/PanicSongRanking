using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PanicSongRanking.Models
{
    public class Song
    {
        public Song()
        {

        }
        public Song(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public int ID { get; set; }
        public string Name { get; set; }

    }
}