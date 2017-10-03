using System;

namespace Netflex.Models{
    public class Movie{
        public long Id { get; set; }

        public string Title {get;set;}

        public DateTime PostedAt { get; set; }

        public string VideoUrl { get; set; }

    }
}