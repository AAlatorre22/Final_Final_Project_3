using Final_Final_Project_3.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Net.Http;

namespace Final_Final_Project_3
{
    public class MovieRepository : IMovieRepository
    {
        private readonly string _conn;

        public MovieRepository(string conn)
        {
            _conn = conn;
        }

        public Movie GetApiResponse()
        {
            var movie = new Movie();

            //var client = new HttpClient();

            //var apiCall = $"https://imdb-top-100-movies.p.rapidapi.com";
            //var request = new RestRequest();

            // // Not completed yet, so if it doesnt make sense dont yell
            //request.AddHeader("content-type", "application/octet-stream");
            //request.AddHeader("X-RapidAPI-Key", $"{_conn}");
            //request.AddHeader("X-RapidAPI-Host", "imdb-top-100-movies.p.rapidapi.com");
            //movie.APIResponse = client.GetStringAsync(apiCall).Result;

            //var response = client.SendAsync(request);

            //RestSharp Code
            var client = new RestClient("https://imdb-top-100-movies.p.rapidapi.com/");
            var request = new RestRequest();
            request.AddHeader("content-type", "application/octet-stream");
            request.AddHeader("X-RapidAPI-Key", $"{_conn}");
            request.AddHeader("X-RapidAPI-Host", "imdb-top-100-movies.p.rapidapi.com");
            var response = client.Execute(request);

            movie.APIResponse = response.Content;

            movie = ParseAllTheMovies(movie);

            // Adding parse methods here

            //movie.Title = JArray.Parse(movie.APIResponse)[0]["title"].ToString();
            //movie.Year = JArray.Parse(movie.APIResponse)[0]["year"].ToString();           
            //movie.Genre = JArray.Parse(movie.APIResponse)[0]["genre"][0].ToString();
            //movie.Rank = JArray.Parse(movie.APIResponse)[0]["rank"].ToString();
            //movie.Rating = JArray.Parse(movie.APIResponse)[0]["rating"].ToString();



            //returns everything we parsed
            return movie;
        }

        public static Movie ParseAllTheMovies(Movie movie)
        {
            for (int i = 0; i < 100; i++)
            {
                var tempMovie = new Movie();

                tempMovie.Title = JArray.Parse(movie.APIResponse)[i]["title"].ToString();
                tempMovie.Year = JArray.Parse(movie.APIResponse)[i]["year"].ToString();
                tempMovie.Genre = JArray.Parse(movie.APIResponse)[i]["genre"][0].ToString();
                tempMovie.Rank = JArray.Parse(movie.APIResponse)[i]["rank"].ToString();
                tempMovie.Rating = JArray.Parse(movie.APIResponse)[i]["rating"].ToString();

                movie.MoviesList.Add(tempMovie);               
            }

            return movie;
        }
    }
}
