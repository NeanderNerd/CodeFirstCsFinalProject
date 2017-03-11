using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstCsFinalProject.Models
{
    public class Episode
    {
        public int EpisodeId { get; set; }
        public string Title { get; set; }
        public string Synopsis { get; set; }
        public DateTime OrigionalAirDate { get; set; }
        public int Duration { get; set; }
    }
}