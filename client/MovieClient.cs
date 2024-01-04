using BlazorBasics.Models;

namespace BlazorBasics.client
{
    public static class MovieClient
    {
        private static readonly List<MoviesModel> movies = new()
           {
        new  MoviesModel
        {
            id=1,
            genre="Action",
            title="Small Ville",
            Rating=5
        },
         new  MoviesModel
        {
            id=2,
            genre="Action",
            title="Blindspot",
            Rating=8
        },
         new  MoviesModel
        {
            id=3,
            genre="Action",
            title="Legend of the seeker",
            Rating=3
        }

    };


        public static MoviesModel[] getMovies()
        {
            return movies.ToArray();
        }

        public static void AddMovies(MoviesModel moviesModel)
        {
           moviesModel.id=movies.Max(x => x.id)+1;
            movies.Add(moviesModel);

        }

        public static void DeleteMovie(int id)
        {
            MoviesModel moviesModel= movies.FirstOrDefault(e=>e.id==id);
            movies.Remove(moviesModel);
            
        }

    }
}
