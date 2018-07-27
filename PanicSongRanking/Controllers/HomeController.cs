using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using PanicSongRanking.Models;

namespace PanicSongRanking.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Song> panicsongList = new List<Song>();
            panicsongList = BuildPanicSongList();
            ViewBag.PanicSongList = panicsongList;

            List<Song> phishSongList = new List<Song>();
            phishSongList = BuildPhishSongList();
            ViewBag.PhishSongList = phishSongList;

            return View();
        }

        private List<Song> BuildPanicSongList()
        {
            var masterList = System.IO.File.ReadAllLines(HostingEnvironment.MapPath(@"~/App_Data/SongList.txt"));
            List<Song> songs = new List<Song>();
            int id = 1;

            foreach (var song in masterList)
            {
                songs.Add(new Song(id, song));
                id++;
            }
            return songs;
        }

        private List<Song> BuildPhishSongList()
        {
            var masterList = System.IO.File.ReadAllLines(HostingEnvironment.MapPath(@"~/App_Data/PhishSongList.txt"));
            List<Song> songs = new List<Song>();
            int id = 1;

            foreach (var song in masterList)
            {
                songs.Add(new Song(id, song));
                id++;
            }
            return songs;
        }
    }
}