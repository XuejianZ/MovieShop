using System;
using System.Collections.Generic;
using System.Text;
using Antra.MovieShop.Data.Services;
using Antra.MovieShop.Data.Models;
using Antra.MovieShop.UI.ConsoleApp.Utility;

namespace Antra.MovieShop.UI.ConsoleApp
{

    class Manage
    {

        public void RunMenu()
        {
            int choice = 0;
            do
            {
                Menu m = new Menu();
                choice = m.Print();
                switch (choice)
                {
                    case (int) MainMenu.Movie:
                        new ManageMovie().RunMenu();
                        break;
                    case (int)MainMenu.MovieCast:
                        new ManageMovieCast().RunMenu();
                        break;
                    case (int)MainMenu.Exit:
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
