using System;
using System.Collections.Generic;
using System.Text;
using Antra.MovieShop.Data.Models;
using Dapper;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;


namespace Antra.MovieShop.Data.Repository
{
    public class MovieRepository :  IRepository<Movie>
    {

        public IEnumerable<Movie> GetAll()
        {
            SqlConnection connection = new SqlConnection(DbHelper.ConnectionString);
            try
            {
                return connection.Query<Movie>("select Id,Title from Movie");

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Dispose();
            }
            return null;
        }

        public Movie GetById(int id)
        {
           //using doesn't include exception, only include try,and finally(dispose)
           using(SqlConnection connection= new SqlConnection(DbHelper.ConnectionString))
            {
                return connection.QueryFirstOrDefault<Movie>("select Id,Title,Overview from Movie where Id=@Id", new { Id = id });
            }
            return null;
        }

        public Movie GetByName(string name)
        {
                SqlConnection connection = new SqlConnection(DbHelper.ConnectionString);
                try
                {
                    return connection.QueryFirstOrDefault<Movie>("select Id, Title, Overview, Price from Movie where Title=@Title", new { Title = name });
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

        public void Insert(Movie item)
        {
            throw new NotImplementedException();
        }
    }
}
