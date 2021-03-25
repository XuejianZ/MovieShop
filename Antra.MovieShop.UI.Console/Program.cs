using System;
using Antra.MovieShop.Data.Services;

namespace Antra.MovieShop.UI.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Manage manage = new Manage();
            manage.RunMenu();
        }
    }
}
