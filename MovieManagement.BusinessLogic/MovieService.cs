using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using MovieManagement.DataAccess;

namespace MovieManagement.BusinessLogic
{
    public class MovieService : IMovieService
    {

        private Dictionary<int, Movie> movieTable = new Dictionary<int, Movie>();
    
        public void AddMovie(Movie movie)
        {
            if (movieTable.ContainsKey(movie.MovieID))
                throw new Exception("Movie ID already exists.");

            movieTable[movie.MovieID] = movie;
        }

        public void UpdateMovie(Movie movie)
        {
            if (!movieTable.ContainsKey(movie.MovieID))
                throw new Exception("Movie not found.");

            movieTable[movie.MovieID] = movie;
        }

  
        public void DeleteMovie(int movieId)
        {
            if (!movieTable.ContainsKey(movieId))
                throw new Exception("Movie not found.");

            movieTable.Remove(movieId);
        }

        public List<Movie> GetAllMovies()
        {
            return new List<Movie>(movieTable.Values);
        }

        public Movie GetMovie(int movieId)
        {
            return movieTable.ContainsKey(movieId) ? movieTable[movieId] : null;
        }

        public void SaveToFile(string filePath)
        {
            var movies = GetAllMovies();
            File.WriteAllText(filePath, JsonConvert.SerializeObject(movies, Formatting.Indented));
        }

     
        public void LoadFromFile(string filePath)
        {
            if (!File.Exists(filePath)) return;

            var movies = JsonConvert.DeserializeObject<List<Movie>>(File.ReadAllText(filePath));
            movieTable.Clear();
            foreach (var movie in movies)
                movieTable[movie.MovieID] = movie;
        }
    }
}

