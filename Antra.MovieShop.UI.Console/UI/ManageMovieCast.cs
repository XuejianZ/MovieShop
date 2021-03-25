using System;
using System.Collections.Generic;
using System.Text;
using Antra.MovieShop.Data.Services;
using Antra.MovieShop.Data.Models;
using Antra.MovieShop.UI.ConsoleApp.Utility;

namespace Antra.MovieShop.UI.ConsoleApp
{


    class ManageMovieCast { 
        
        MovieCastServices movieCastServices;
        public ManageMovieCast()
        {
            movieCastServices = new MovieCastServices();
        }
        public void RunMenu()
        {
            int choice = 0;
            do
            {
                Menu m = new Menu();
                choice = m.Print_2();
                switch (choice)
                {
                    //case (int)MenuOptions.SearchById:
                    //    MovieCastServices.GetAllMovies();
                    //    break;
                    //case (int)MenuOptions.SearchByName:
                    //    MovieCastServices.GetById();
                    //    break;
                    case (int)MenuOptions.PrintAll:
                        movieCastServices.PrintMovieCastWithMovieTitle();
                        break;
                    case (int)MenuOptions.Exit:
                        Console.WriteLine("Thanks for visit. Please Visit again !!!!");
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
                Console.WriteLine("Press Enter to continue......");
                Console.ReadLine();
                Console.Clear();
            } while (choice != (int)MenuOptions.Exit);

        }

    }
}
