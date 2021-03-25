using System;
using System.Collections.Generic;
using System.Text;
using Antra.MovieShop.Data.Models;
using Antra.MovieShop.Data.Repository;

namespace Antra.MovieShop.Data.Services
{
    public class MovieCastServices
    {
        IRepository<MovieCast> movieCastRepository;

        public MovieCastServices()
        {
            movieCastRepository = new MovieCastRepository();
        }

        public void PrintMovieCastWithMovieTitle()
        {

            //no idea why is is null?????????????
            IEnumerable<MovieCast> movieCastCollection = movieCastRepository.GetAll();
            foreach(var item in movieCastCollection)
            {
                Console.WriteLine(item.MovieId + "\t" + item.CastId + "\t" + item.Character + "\t" + item.Movie.Title);
            }
        }

    }
}
