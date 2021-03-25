using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using System.Data.SqlClient;
using Antra.MovieShop.Data.Models;

namespace Antra.MovieShop.Data.Repository
{
    public class MovieCastRepository : IRepository<MovieCast>
    {
        public IEnumerable<MovieCast> GetAll()
        {
            SqlConnection connection = new SqlConnection(DbHelper.ConnectionString);
            try
            {    
                string cmd = "Select mc.MovieId, mc.CastId, mc.Character, m.Title from MovieCast mc inner join Movie m on mc.MovieId = m.Id";
                return connection.Query<MovieCast, Movie, MovieCast>(cmd, (mc, m) => { mc.Movie = m; return mc; });
               
            }
            catch (Exception ex)
            {
              
            }
            finally
            {
                connection.Dispose();
            }
            return null;
        }

        public MovieCast GetById(int id)
        {
            throw new NotImplementedException();
        }

        public MovieCast GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Insert(MovieCast item)
        {
            throw new NotImplementedException();
        }
    }
}
