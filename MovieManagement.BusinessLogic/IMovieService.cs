using System.Collections.Generic;
using MovieManagement.DataAccess;

namespace MovieManagement.BusinessLogic
{
    public interface IMovieService
    {
        void AddMovie(Movie movie);
        void UpdateMovie(Movie movie);
        void DeleteMovie(int movieId);
        List<Movie> GetAllMovies();
        Movie GetMovie(int movieId);
        void SaveToFile(string filePath);
        void LoadFromFile(string filePath);
    }
}

