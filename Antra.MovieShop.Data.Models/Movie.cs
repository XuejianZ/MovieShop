using System;
using System.Collections.Generic;
using System.Text;

namespace Antra.MovieShop.Data.Models
{
    public class Movie
    {
        public int Id { set; get; }
        public string Title { set; get; }
        public string Overview { set; get; }
        public string Tagline { set; get; }
        public decimal Budget { set; get; }
        public decimal Revenue { set; get; }
        public string ImdbUrl { set; get; }
        public string TmdbUrl { set; get; }
        public string PosterUrl { set; get; }
        public string BackdropUrl { set; get; }
        public string OriginalLanguage { set; get; }
        public DateTime ReleaseDate { set; get; }
        public int RunTime { set; get; }
        public decimal Price { set; get; }
        public DateTime CreatedDate { set; get; }
        public DateTime UpdatedDate { set; get; }
        public string UpdatedBy { set; get; }
        public string CreatedBy { set; get; }

        public MovieCast movieCast { get; set; }
        //navagation property
        public MovieGenre MovieGenre { set; get; }

    }
}
