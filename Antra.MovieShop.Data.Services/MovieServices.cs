using System;
using System.Collections.Generic;
using System.Text;
using Antra.MovieShop.Data.Repository;
using Antra.MovieShop.Data.Models;
using System.Threading.Tasks;

namespace Antra.MovieShop.Data.Services
{
    public class MovieServices
    {
        IRepository<Movie> movieRepository;
        public MovieServices()
        {
            movieRepository = new MovieRepository();
        }



        public void GetAllMovies()
        {
            IEnumerable<Movie> movieCollection = movieRepository.GetAll();
            foreach (var item in movieCollection)
            {
                Console.WriteLine(item.Id + "\t" + item.Title);
            }
        }
        public void GetById()
        {
            Console.WriteLine("Enter movie ID :");
            int Id = Convert.ToInt32(Console.ReadLine());
            Movie m = movieRepository.GetById(Id);
            Console.WriteLine("Id: " + m.Id);
            Console.WriteLine("Title:" + m.Title);
            Console.WriteLine("Overview:" + m.Overview);
        }

        public void GetByName()
        {
            Console.Write("Enter Movie Name:");
            string name = Console.ReadLine();
            Movie m = movieRepository.GetByName(name);
            Console.WriteLine("Id: " + m.Id);
            Console.WriteLine("Title: " + m.Title);
            Console.WriteLine("Overview: " + m.Overview);
        }

        
    }
}
