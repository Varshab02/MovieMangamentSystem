using MovieManagement.BusinessLogic;
using MovieManagement.DataAccess;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Movie_Management_System
{
    public partial class Form1 : Form
    {
        private readonly IMovieService movieService;  // Fix: Declare movieService
        private List<Movie> movieList = new List<Movie>();  // Fix: Declare movieList
        private int currentIndex = 0;  // Fix: Declare currentIndex

        public Form1()
        {
            InitializeComponent();
            movieService = new MovieService(); // Initialize movieService
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var movie = new Movie
                {
                    MovieID = int.Parse(txtMovieID.Text),
                    Title = txtTitle.Text,
                    Genre = txtGenre.Text,
                    ReleaseYear = int.Parse(txtYear.Text),
                    Director = txtDirector.Text
                };

                movieService.AddMovie(movie);
                LoadMovies();
                MessageBox.Show("Movie Added Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var movie = new Movie
                {
                    MovieID = int.Parse(txtMovieID.Text),
                    Title = txtTitle.Text,
                    Genre = txtGenre.Text,
                    ReleaseYear = int.Parse(txtYear.Text),
                    Director = txtDirector.Text
                };

                movieService.UpdateMovie(movie);
                LoadMovies();
                MessageBox.Show("Movie Updated Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int movieId = int.Parse(txtMovieID.Text);
                movieService.DeleteMovie(movieId);
                LoadMovies();
                MessageBox.Show("Movie Deleted Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            movieService.SaveToFile("movies.json");
            MessageBox.Show("Movies Saved Successfully!");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            movieService.LoadFromFile("movies.json");
            LoadMovies();
            MessageBox.Show("Movies Loaded Successfully!");
        }

        private void LoadMovies()
        {
            movieList = movieService.GetAllMovies();
            if (movieList.Count > 0)
            {
                currentIndex = 0;
                DisplayMovie();
            }
        }

        private void DisplayMovie()
        {
            if (movieList.Count > 0 && currentIndex >= 0 && currentIndex < movieList.Count)
            {
                var movie = movieList[currentIndex];
                txtMovieID.Text = movie.MovieID.ToString();
                txtTitle.Text = movie.Title;
                txtGenre.Text = movie.Genre;
                txtYear.Text = movie.ReleaseYear.ToString();
                txtDirector.Text = movie.Director;
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (movieList.Count > 0)
            {
                currentIndex = 0;
                DisplayMovie();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (movieList.Count > 0)
            {
                currentIndex = movieList.Count - 1;
                DisplayMovie();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentIndex < movieList.Count - 1)
            {
                currentIndex++;
                DisplayMovie();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                DisplayMovie();
            }
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            try
            {
                var allMovies = movieService.GetAllMovies();
                if (allMovies.Count == 0)
                {
                    MessageBox.Show("No movies available.");
                }
                else
                {
                    string movieList = "";
                    foreach (var movie in allMovies)
                    {
                        movieList += $"ID: {movie.MovieID}, Title: {movie.Title}, Genre: {movie.Genre}, Year: {movie.ReleaseYear}, Director: {movie.Director}\n";
                    }

                    MessageBox.Show(movieList, "All Movies");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
