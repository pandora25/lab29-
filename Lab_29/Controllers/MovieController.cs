using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Lab_29.Models;

namespace Lab_29.Controllers
{
    public class MovieController : ApiController
    {
        //1.
        [HttpGet]
        public List<Table_MovieS> ShowAllMovies()
        {
            Movie_TableEntities ORM = new Movie_TableEntities();
            return ORM.Table_MovieS.ToList();

        }

        //2.
        [HttpGet]
        public List<Table_MovieS> ShowMovieSpecCat(string discription)
        {
            Movie_TableEntities ORM = new Movie_TableEntities();
            return ORM.Table_MovieS.Where(c => c.Movie_Name.Contains(discription)).ToList();
            // the requsit link
            // http://localhost:54840/api/Movie/ShowMovieCat?Discription=Colette
        }

        //3.
        [HttpGet]
        public Table_MovieS RandomMoviePicker()
        {
            // we but table movie iunstead of movie list cuz the asking for onwe movie
            Movie_TableEntities ORM = new Movie_TableEntities();
            Random R = new Random();
            return ORM.Table_MovieS.ToList()[R.Next(0, ORM.Table_MovieS.ToList().Count)];
            //http://localhost:54840/api/Movie/RandomMoviePicker
        }

        //4.
        [HttpGet]
        public Table_MovieS RandomSpecCAtogry(int MovieID)
        {
            Movie_TableEntities ORM = new Movie_TableEntities();
            Random R = new Random();
            return ORM.Table_MovieS.ToList()[R.Next(0, MovieID)];
        }

        //5.
        [HttpGet]
        public List<Table_MovieS> MovieRandQuantity(int Quantity)
        {
            Movie_TableEntities ORM = new Movie_TableEntities();
            Random Rnd = new Random();
            List<Table_MovieS> All_Movies = ORM.Table_MovieS.ToList();
            List<Table_MovieS> Added_movies = new List<Table_MovieS>();//empty list
            //List<Table_MovieS> google =  ORM.Table_MovieS.ToList().Take(Quantity);
            for (int i = 0; i < Quantity; i++)
            {
                int result = Rnd.Next(All_Movies.Count);
                Added_movies.Add(All_Movies[result]);
                All_Movies.RemoveAt(result);
            }
            return Added_movies;
        }

        //6.



    }
}


////*        public List<Table_MovieS MovieQuantity(int Quantity)
//            {
//        List<Table_MovieS> AllMovies = ORM.Table_MovieS.ToList();
//        List<Table_MovieS> R_movies = new List<Table_MovieS>();//empty list
//        Random Rnd = new Random();
//List<KeyValuePair<string, Double>> elements = ORM.Table_MovieS.

//                return  ORM.Table_MovieS.OrderBy(x => Rnd.Next()).Take(Quantity);

// * 
// * 
// * /
//while (R_movies.Count < Quantity)
//{
//    R_movies.Add(AllMovies);
//}
//for (int i = 0; i <= Quantity; i++)
//{
//    Table_MovieS;

//  return ORM.Table_MovieS.Where(x => Rnd.Next(3).Take(Quantity));
   //         return Added_movies;
