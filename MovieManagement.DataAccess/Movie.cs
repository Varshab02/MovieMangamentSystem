using System;

namespace MovieManagement.DataAccess
{
    public class Movie
    {
        public int MovieID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int ReleaseYear { get; set; }
        public string Director { get; set; }
    }
}

